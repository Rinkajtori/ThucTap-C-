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
    public partial class QuayHang : Form
    {
        public QuayHang()
        {
            InitializeComponent();
            setDefault();
            showData();
            showData2();
            setData();
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

        private void showButton_Click(object sender, EventArgs e)
        {
            
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

        private void setData()
        {
            String query = "SELECT * FROM dbo.Quayhang";
            quayHangComboBox.DisplayMember = "tenquay";
            quayHangComboBox.ValueMember = "maquay";
            quayHangComboBox.DataSource = getData(query);

            searchModeComboBox.SelectedIndex = 0;
            if (maSPTextBox.TextLength == 0)
            {
                soLuongPanel.Visible = false;
            }
            comboBox.SelectedIndex = 0;
        }

        private void showData()
        {
            string query = "SELECT * FROM QuayHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       
        private void showData2()
        {
            string query = "SELECT * FROM MatHang";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        MyControl myControl = new MyControl();

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            maQHTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            tenQHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

            string query = "SELECT *FROM dbo.MatHang WHERE maquay='" + maQHTextBox.Text.Trim() + "'";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row2 = e.RowIndex;
            maSPTextBox.Text = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
            tenSPTextBox.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
            giaTextBox.Text = dataGridView2.Rows[row2].Cells[2].Value.ToString().Trim();

            maQHTextBox2.Text = dataGridView2.Rows[row2].Cells[3].Value.ToString().Trim();
            quayHangComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[3].Value;

            doanhSoTextBox.Text = dataGridView2.Rows[row2].Cells[4].Value.ToString().Trim();
            ttinTextBox.Text = dataGridView2.Rows[row2].Cells[5].Value.ToString().Trim();
            giamGiaTextBox.Text = dataGridView2.Rows[row2].Cells[6].Value.ToString().Trim();
            trangThaiTextBox.Text = dataGridView2.Rows[row2].Cells[7].Value.ToString().Trim();
            nsxTextBox.Text = dataGridView2.Rows[row2].Cells[8].Value.ToString().Trim();

            soLuongPanel.Visible = true;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.QuayHang( maquay ,tenquay)
                                VALUES  ( '" + maQHTextBox.Text.Trim() + "' ,N'" + tenQHTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã quầy");
            }
        }

        private void changeButton1_Click(object sender, EventArgs e)
        {
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.QuayHang SET tenquay=N'" + tenQHTextBox.Text.Trim() + "' WHERE maquay= '" + maQHTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy quầy");
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.QuayHang Where maquay='" + maQHTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.QuayHang WHERE (maquay LIKE'%" + searchTextBox.Text.Trim() + "%') OR (tenquay LIKE '%" 
                + searchTextBox.Text.Trim() + "%')";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maSPTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.MatHang( mamh ,tenhang, dongia, maquay, doanhso, ghichu, giamgia, trangthai, hangsx)
                                VALUES  ( '" + maSPTextBox.Text.Trim() + "', N'" + tenSPTextBox.Text.Trim() + "', " + giaTextBox.Text.Trim() + ", '" + maQHTextBox2.Text.Trim() + "', "
                                             + doanhSoTextBox.Text.Trim() + ", N'" + ttinTextBox.Text.Trim() + "', " + giamGiaTextBox.Text.Trim() + ", " + trangThaiTextBox.Text.Trim() + ", N'" + nsxTextBox.Text.Trim() + "')";
                MessageBox.Show("" + query);
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData2();
            }
            else
            {
                MessageBox.Show("Không được để trống mã sản phẩm");
            }
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (maSPTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.MatHang SET tenhang=N'" + tenSPTextBox.Text.Trim() + "',dongia=" + giaTextBox.Text.Trim() + ",maquay='" + maQHTextBox2.Text.Trim() + "',doanhso=" + doanhSoTextBox.Text.Trim()
                                + ",ghichu=N'" + ttinTextBox.Text.Trim() + "',giamgia=" + giamGiaTextBox.Text.Trim() + ",trangthai=" + trangThaiTextBox.Text.Trim() + ",hangsx=N'" + nsxTextBox.Text.Trim()
                                + "' WHERE mamh= '" + maSPTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (maSPTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.MatHang Where mamh='" + maSPTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData2();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã hàng":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE mamh LIKE'%" + searchTextBox2.Text.Trim() + "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Tên hàng":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE tenhang LIKE N'%" + searchTextBox2.Text.Trim()+ "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giá":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE dongia BETWEEN " + searchGiaTextBox1.Text.Trim() + " AND " + searchGiaTextBox2.Text.Trim();
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giảm giá":
                    {
                       
                        break;
                    }
                case "Trang thái":
                    {
                        break;
                    }
                case "Hãng sản xuất":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE hangsx LIKE N'%" + searchTextBox2.Text.Trim() + "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }
            
        }

        private void searchGiaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void searchGiaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void searchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã hàng":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Tên hàng":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Giá":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = true;
                        break;
                    }
                case "Giảm giá":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Trạng thái":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Hãng sản xuất":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int soLuong=0;
            switch (comboBox.SelectedItem.ToString().Trim())
            {
                case "Thêm sản phẩm":
                    {
                        soLuong += (int)numericUpDown1.Value;
                        break;
                    }
                case "Bớt sản phẩm":
                    {
                        soLuong -= (int)numericUpDown1.Value;
                        break;
                    }
            }
            soLuong += Convert.ToInt16(trangThaiTextBox.Text);
            if (soLuong >= 0)
            {
                String query = @"UPDATE dbo.MatHang SET trangthai=" + soLuong + " WHERE mamh= '" + maSPTextBox.Text.Trim() + "'";
                MessageBox.Show(""+query);
                myControl.ExecuteMyQuery(query);
                showData2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn số lượng nhỏ hơn (<" + trangThaiTextBox.Text.Trim()+")");
            }
            
            
        }     
    }
}
