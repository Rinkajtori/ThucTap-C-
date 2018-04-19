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
    public partial class KhachHang : Form
    {
        public KhachHang()
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

        private DataTable getData(String query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.StackTrace);
            }
            return data;
        }

        private void showData()
        {
            string query = "SELECT * FROM KhachHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        MyControl myControl=new MyControl();

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            maKHTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            tenKHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            sdtTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
            diaChiTextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (maKHTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.KHachHang( makh ,tenkh, sdt, diachi)
                                VALUES  ( '" + maKHTextBox.Text.Trim() + "',N'" + tenKHTextBox.Text.Trim() + "','" 
                                             + sdtTextBox.Text.Trim() + "',N'" + diaChiTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã khách hàng ");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (maKHTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.KhachHang SET tenkh=N'" + tenKHTextBox.Text.Trim() + "', sdt='" 
                    + sdtTextBox.Text.Trim() + "', diachi=N'" + diaChiTextBox.Text.Trim() + "' WHERE makh= '" 
                    + maKHTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));                 
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (maKHTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.KhachHang Where makh='" + maKHTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.KhachHang WHERE (makh LIKE'%" + searchTextBox.Text.Trim() 
                + "%') OR (tenkh LIKE N'%" + searchTextBox.Text.Trim() + "%') OR (sdt LIKE '%" + searchTextBox.Text.Trim() 
                + "%') OR (diachi LIKE N'%" + searchTextBox.Text.Trim() + "%')";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sdtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                button1_Click(null, null);
            }
        }
    }
}
