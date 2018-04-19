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
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
            setDefault();
            showData();
        }

        private void setDefault()
        {
            if (DangNhap.checkAceccpt == 0)
            {
                addButton1.Enabled = false;
                changeButton1.Enabled = false;
                deleteButton1.Enabled = false;

                addButton2.Enabled = false;
                changeButton2.Enabled = false;
                deleteButton2.Enabled = false;
            }
            else
            {
                if (DangNhap.checkAceccpt == 2)
                {
                    addButton1.Enabled = false;
                    changeButton1.Enabled = false;
                    deleteButton1.Enabled = false;

                    addButton2.Enabled = true;
                    changeButton2.Enabled = true;
                    deleteButton2.Enabled = true;
                }
                else
                {
                    if (DangNhap.checkAceccpt == 1)
                    {
                        addButton1.Enabled = true;
                        changeButton1.Enabled = true;
                        deleteButton1.Enabled = true;

                        addButton2.Enabled = true;
                        changeButton2.Enabled = true;
                        deleteButton2.Enabled = true;
                    }
                }
            }
        }

        MyControl myControl = new MyControl();

        private void showData()
        {
            string query = "SELECT * FROM XuatHang";
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

        private void ShowDataXuatHang()
        {
            try
            {
                if (maXuattextBox.Text.Trim().Length != 0)
                {
                    string query = "SELECT nh.maxuat as mx,spx.mamh as mh,mh.tenhang as th,spx.soluong as sl,mh.dongia as dg FROM dbo.XuatHang AS nh, dbo.SpXuat AS spx ,dbo.MatHang AS mh WHERE nh.maxuat = spx.maxuat AND spx.mamh =mh.mamh AND nh.maxuat = '" + maXuattextBox.Text.Trim() + "'";
                    using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        dataGridView2.DataSource = data;
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống mã hóa đơn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        int row = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            maXuattextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            ngayXuattextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            maCHTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
            maNVTextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();

            maXuattextBox2.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            ShowDataXuatHang();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {

                string query = @"INSERT dbo.XuatHang ( maxuat , ngayxuat , mach, manv ) VALUES  ( '" + maXuattextBox.Text.Trim() 
                    + "','" + ngayXuattextBox.Text.Trim() + "','" + maCHTextBox.Text.Trim() + "','" + maNVTextBox.Text.Trim() + "')";

                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.XuatHang SET maxuat ='" + maXuattextBox.Text.Trim() + "',ngayxuat = '" 
                    + ngayXuattextBox.Text.Trim() + "', mach = '" + maCHTextBox.Text.Trim() + "' , manv = '" 
                    + maNVTextBox.Text.Trim() + "' WHERE  maxuat = '" + maXuattextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE dbo.XuatHang WHERE maxuat = '" + maXuattextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void searchButtonXH_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.XuatHang WHERE maxuat LIKE '%" + searchTextBox.Text.Trim() + "'OR ngayxuat LIKE '%" + searchTextBox.Text.Trim() + "' OR mach LIKE '%" + searchTextBox.Text.Trim() + "' OR manv LIKE '%" + searchTextBox.Text.Trim() + "'";

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row2;
            row2 = e.RowIndex;
            maSPtextBox2.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
            soLuongtextBox.Text = dataGridView2.Rows[row2].Cells[3].Value.ToString().Trim();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.SpXuat VALUES  ( '" + maXuattextBox2.Text.Trim() + "','" + maSPtextBox2.Text.Trim() + "'," + soLuongtextBox.Text.Trim() + "  )";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                ShowDataXuatHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void updateButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.SpXuat SET mamh = '" + maSPtextBox2.Text.Trim() + "', soluong = '" + soLuongtextBox.Text.Trim() + "' WHERE maxuat ='" + maXuattextBox2.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                ShowDataXuatHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void delButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE dbo.SpXuat WHERE maxuat = '" + maXuattextBox2.Text.Trim() + "' AND mamh = '" + maSPtextBox2.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    ShowDataXuatHang();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }
    }
}
