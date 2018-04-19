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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            setDefault(DangNhap.checkAceccpt);
            showData();
            showData2();
            setData();
        }

        public void setDefault(int checkAccept)
        {
            if (checkAccept == 0)
            {
                addButton.Enabled = false;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;

                addButton2.Enabled = false;
                changeButton2.Enabled = false;
                deleteButton2.Enabled = false;
            }
            else
            {
                if (checkAccept == 1 || checkAccept == 2)
                {
                    addButton.Enabled = true;
                    changeButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
                if (checkAccept == 1)
                {
                    addButton2.Enabled = true;
                    changeButton2.Enabled = true;
                    deleteButton2.Enabled = true;
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

        private void showData2()
        {
            string query = "SELECT * FROM PhongBan";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void showData()
        {
            string query = "SELECT * FROM NhanVien";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setData()
        {
            String queryNQL = "SELECT tenNV,maNV FROM dbo.NhanVien WHERE maNV IN (	SELECT maNQL FROM dbo.NhanVien) ";
            nqlComboBox.DisplayMember = "tenNV";
            nqlComboBox.ValueMember = "maNV";
            nqlComboBox.DataSource = getData(queryNQL);

            String queryPB = "SELECT * FROM PhongBan";
            phongComboBox.DisplayMember = "tenphong";
            phongComboBox.ValueMember = "maphong";
            phongComboBox.DataSource = getData(queryPB);

            String queryCH = "SELECT * FROM CuaHang";
            cuaHangComboBox.DisplayMember = "tenCuaHang";
            cuaHangComboBox.ValueMember = "mach";
            cuaHangComboBox.DataSource = getData(queryCH);

            gioiTinhComboBox.Items.Add("Nam");
            gioiTinhComboBox.Items.Add("Nữ");
            gioiTinhComboBox.Items.Add("Khác");
            gioiTinhComboBox.SelectedIndex = 0;

            searchModeComboBox.SelectedIndex = 0;
            searchSexComboBox.SelectedIndex = 0;
        }

        MyControl myControl = new MyControl();

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void maNVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nuRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox1.Text = searchDateTimePicker1.Value.ToString("yyyy/MM/dd").Trim();
        }
        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                //MessageBox.Show(""+row);
                maNVTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                tenNVTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

                sdtTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();

                if (dataGridView1.Rows[row].Cells[3].Value.ToString().Trim().Length != 0)
                {
                    ngaySinhDateTimePicker.Value = (DateTime)dataGridView1.Rows[row].Cells[3].Value;
                    //ngaySinhTextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
                }

                gioiTinhComboBox.SelectedItem = dataGridView1.Rows[row].Cells[4].Value;
                luongTextBox.Text = dataGridView1.Rows[row].Cells[5].Value.ToString().Trim();

                phongTextBox.Text = dataGridView1.Rows[row].Cells[6].Value.ToString().Trim();
                phongComboBox.SelectedValue = dataGridView1.Rows[row].Cells[6].Value;

                maCHTextBox.Text = dataGridView1.Rows[row].Cells[7].Value.ToString().Trim();
                cuaHangComboBox.SelectedValue = dataGridView1.Rows[row].Cells[7].Value;

                nqlTextBox.Text = dataGridView1.Rows[row].Cells[8].Value.ToString().Trim();
                nqlComboBox.SelectedValue = dataGridView1.Rows[row].Cells[8].Value;
            }
            catch (Exception ex)
            {
                
            }
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row2 = e.RowIndex;
                maPhongTextBox.Text = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
                tenPhongTextBox.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();

                string query = "SELECT * FROM dbo.NhanVien WHERE maPhong ='" + maPhongTextBox.Text.Trim() + "'";
                dataGridView1.DataSource = getData(query);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                
            }   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (maNVTextBox.Text.Trim().Length != 0)
            {
                String query = @"INSERT dbo.NhanVien( maNV ,tenNV, sdt, ngaySinh, gioiTinh, luong, maPhong, maCH, maNQL)
                                VALUES  ( '" + maNVTextBox.Text.Trim() + "',N'" + tenNVTextBox.Text.Trim() + "','" 
                                             + sdtTextBox.Text.Trim() + "','" + ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim()
                                             + "',N'" + gioiTinhComboBox.SelectedText.Trim() + "'," + luongTextBox.Text.Trim() + ",'" + maPhongTextBox.Text.Trim() + "','" + maCHTextBox.Text.Trim() + "','" + nqlTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã nhân viên");
            }
        }

        

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (maNVTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.NhanVien SET tenNV=N'" + tenNVTextBox.Text.Trim() + "',sdt='" + sdtTextBox.Text.Trim()
                    + "',ngaySinh='" + ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim() + "',gioiTinh=N'" + gioiTinhComboBox.SelectedItem.ToString().Trim()
                    + "',luong=" + luongTextBox.Text.Trim() + ",maPhong='" + phongTextBox.Text.Trim() + "',maCH='" 
                    + maCHTextBox.Text.Trim() + "',maNQL='" + nqlTextBox.Text.Trim() + "' WHERE maNV= '" + maNVTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (maNVTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.NhanVien Where maNV='" + maNVTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE maNV LIKE '%" + searchTextBox.Text.Trim()+ "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Tên nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE tenNV LIKE N'%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Số điện thoại":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE sdt LIKE '%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Ngày sinh":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE ngaySinh BETWEEN '" + searchDateTextBox1.Text.Trim() + "' AND '" + searchDateTextBox2.Text.Trim()+"'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giới tính":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE gioiTinh LIKE N'%" + searchSexComboBox.SelectedItem.ToString().Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Lương":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE Luong BETWEEN "+ searchLuongTextBox1.Text.Trim()+" AND "+ searchLuongTextBox2.Text.Trim();
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Mã cửa hàng":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE maCH LIKE '%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }          
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.PhongBan( maphong ,tenphong)
                                VALUES  ( '" + maPhongTextBox.Text.Trim() + "',N'" + tenPhongTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData2();
            }
            else
            {
                MessageBox.Show("Không được để trống mã phòng ");
            }
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.PhongBan SET tenphong=N'" + tenPhongTextBox.Text.Trim() + "' WHERE maphong= '" 
                    + maPhongTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng");
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.PhongBan Where maphong='" + maPhongTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData2();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng");
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.PhongBan WHERE (maphong LIKE'%" + searchTextBox2.Text.Trim() 
                + "%') OR (tenphong LIKE N'%" + searchTextBox2.Text.Trim() + "%')";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sdtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int) e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void luongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void searchTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                searchButton2_Click(null, null);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                searchButton_Click(null, null);
            }
        }

        private void nqlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nqlTextBox.Text = nqlComboBox.SelectedValue.ToString().Trim();
        }

        private void phongComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            phongTextBox.Text = phongComboBox.SelectedValue.ToString().Trim();
        }

        private void cuaHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maCHTextBox.Text = cuaHangComboBox.SelectedValue.ToString().Trim();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString())
            {
                case "Lương":
                    {
                        searchLuongPanel.Visible = true;
                        searchTextBox.Visible = false;
                        searchDatePanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
                case "Ngày sinh":
                    {
                        searchDatePanel.Visible = true;
                        searchTextBox.Visible = false;
                        searchLuongPanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
                case "Giới tính":
                    {
                        searchSexPanel.Visible = true;
                        searchLuongPanel.Visible = false;
                        searchDatePanel.Visible = false;
                        searchTextBox.Visible = false;
                        break;
                    }
                default:
                    {
                        searchTextBox.Visible = true;
                        searchLuongPanel.Visible = false;
                        searchDatePanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar!=13)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox2.Text = searchDateTimePicker2.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void ngaySinhDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ngaySinhTextBox.Text = ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void searchDateTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}



           