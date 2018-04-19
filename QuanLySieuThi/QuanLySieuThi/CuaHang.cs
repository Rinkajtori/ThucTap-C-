using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
            setDefault(DangNhap.checkAceccpt);
            showData();
        }

        public void setDefault(int checkAccept)
        {
            if (checkAccept == 0)
            {
                addButton.Enabled = false;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else
            {
                if (checkAccept == 1 || checkAccept == 2)
                {
                    addButton.Enabled = true;
                    changeButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
            }
        }

        public void showData()
        {
            string query = "SELECT * FROM CuaHang";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                connection.Close();
            }


        }

        MyControl myControl = new MyControl();
      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CuaHang_Load(object sender, EventArgs e)
        {

        }

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            maCHTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            tenCHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            diaChiTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (maCHTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.CuaHang( mach,tenCuaHang,diachi)
                                VALUES  ( '" + maCHTextBox.Text.Trim() + "' ,N'" + tenCHTextBox.Text.Trim() + "', '" + diaChiTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));               
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã cửa hàng");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (maCHTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.CuaHang SET tenCuaHang=N'" + tenCHTextBox.Text.Trim() + "',diachi='" + diaChiTextBox.Text.Trim() + "' WHERE mach= '" + maCHTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng  chọn cửa hàng");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.CuaHang WHERE (mach LIKE'%" + searchTextBox.Text.Trim() + "%') OR (tenCuaHang LIKE '%" + searchTextBox.Text.Trim() + "%') OR (diachi LIKE'%" + searchTextBox.Text.Trim() + "%')";

            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                connection.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (maCHTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.CuaHang Where mach='" + maCHTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cửa hàng");
            }
        }
    }    
}
