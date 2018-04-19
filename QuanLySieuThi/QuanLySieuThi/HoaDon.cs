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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            setDefault(DangNhap.checkAceccpt);
            showData();

            setData();
        }

        private void setDefault(int checkAccept)
        {
            if (checkAccept == 0)
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
                if (checkAccept == 1 || checkAccept == 2)
                {
                    addButton1.Enabled = true;
                    changeButton1.Enabled = true;
                    deleteButton1.Enabled = true;
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

        private void setData(){
            String queryMH = "SELECT * FROM MatHang";
            matHangComboBox.DisplayMember = "tenhang";
            matHangComboBox.ValueMember = "mamh";
            matHangComboBox.DataSource = getData(queryMH);

            String queryKH = "SELECT * FROM KhachHang";
            khachHangComboBox.DisplayMember = "tenkh";
            khachHangComboBox.ValueMember = "makh";
            khachHangComboBox.DataSource = getData(queryKH);

            String queryNV = "SELECT * FROM NhanVien";
            nhanVienComboBox.DisplayMember = "tennv";
            nhanVienComboBox.ValueMember = "manv";
            nhanVienComboBox.DataSource = getData(queryNV);
        }

        private void showData()
        {
            string query = "SELECT * FROM HoaDon";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;          
        }

        MyControl myControl = new MyControl();

        private void showHoaDon(){
            try
            {
                if (maHDTextBox.Text.Trim().Length != 0)
                {
                    string query = @"SELECT a.mamh,a.tenhang,a.dongia,(a.giamgia*100) AS khuyenMai,"
                        + chietKhauNumericUpDown.Value.ToString().Trim()
                        + " AS chietKhau,(a.dongia*(1-a.giamgia-" + ((float)chietKhauNumericUpDown.Value / 100).ToString().Trim()
                        + ")) AS giaban,b.soluong,b.soluong*a.dongia*(1-a.giamgia-" + ((float)chietKhauNumericUpDown.Value / 100).ToString().Trim()
                        + ") AS tongGia FROM dbo.MatHang AS a,dbo.ThanhToan  AS b WHERE a.mamh = b.mamh AND b.mahd='" 
                        + maHDTextBox.Text.Trim() + "'";
                    
                    dataGridView2.DataSource = getData(query);
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    float tongTien=0;
                    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                    {
                        tongTien += float.Parse(dataGridView2.Rows[i].Cells["tongGia"].Value.ToString());
                    }
                    tongGiaTextBox.Text = tongTien.ToString().Trim();                  
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

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            maHDTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            maHDTextBox2.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            khachHangComboBox.SelectedValue=dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            maKHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            ngayGhiDateTimePicker.Value = (DateTime)dataGridView1.Rows[row].Cells[2].Value;
            nhanVienComboBox.SelectedValue = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            maNVTextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();

            showHoaDon();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row2;
            row2 = e.RowIndex;
            matHangComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
            maMHTextBox.Text = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
            giaBanTextBox.Text = dataGridView2.Rows[row2].Cells[2].Value.ToString().Trim();
            numericUpDown1.Value = (int)dataGridView2.Rows[row2].Cells[6].Value;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        

        private void addButton1_Click(object sender, EventArgs e)
        {
            if (maHDTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.HoaDon( mahd , makh, ngayghi, manv)
                                VALUES  ( '" + maHDTextBox.Text.Trim() + "' ,'" + khachHangComboBox.SelectedValue.ToString().Trim() 
                                             + "' ,'" + ngayGhiDateTimePicker.Value.ToString().Trim() + "', '" 
                                             + nhanVienComboBox.SelectedValue.ToString().Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã hóa đơn");
            }   
        }

        private void changeButton1_Click(object sender, EventArgs e)
        {
            if (maHDTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.HoaDon SET makh='" + khachHangComboBox.SelectedValue.ToString().Trim() 
                    + "',ngayghi='" + ngayGhiDateTimePicker.Value.ToString().Trim() + "',manv='" 
                    + nhanVienComboBox.SelectedValue.ToString().Trim() + "' WHERE mahd= '" + maHDTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã hóa đơn");
            }
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.HoaDon WHERE (mahd LIKE'%" + searchTextBox.Text.Trim() + "%') OR (makh LIKE '%" 
                + searchTextBox.Text.Trim() + "%') OR (ngayghi LIKE'%" + searchTextBox.Text.Trim() + "%') OR (manv LIKE'%" 
                + searchTextBox.Text.Trim() + "%')";

            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (maHDTextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.HOADON Where mahd='" + maHDTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maHDTextBox2.Text.Trim().Length != 0)
            {               
                string query = @"INSERT dbo.ThanhToan( mahd , mamh, soluong)
                                VALUES  ( '" + maHDTextBox2.Text.Trim() + "' ,'" + matHangComboBox.SelectedValue.ToString().Trim()
                                             + "' ," + numericUpDown1.Value.ToString().Trim() + ")";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }   
        }       

        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (maHDTextBox2.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.ThanhToan SET mamh='" + matHangComboBox.SelectedValue.ToString().Trim() 
                    + "',soluong=" + numericUpDown1.Value.ToString().Trim() + " WHERE mahd= '" + maHDTextBox2.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showHoaDon();
            }
            else
            {
                MessageBox.Show("Không được để trống mã hóa đơn");
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (maHDTextBox2.Text.Trim().Length != 0)
            {
                string query = @"DELETE FROM dbo.ThanhToan Where  mamh='" + matHangComboBox.SelectedValue.ToString().Trim() 
                    + "' AND mahd= '" + maHDTextBox2.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //PrintDialog print = new PrintDialog();
           // print.ShowDialog();
            new Form1().ShowDialog();
            
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                searchButton1_Click(null, null);
            }
        }

        private void matHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMHTextBox.Text = matHangComboBox.SelectedValue.ToString().Trim();
            String query="SELECT dongia FROM dbo.MatHang WHERE mamh ='"+maMHTextBox.Text.Trim()+"'";
            giaBanTextBox.Text = myControl.ExecuteMyQueryScalar(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showHoaDon();
        }

        private void giaBanTextBox_TextChanged(object sender, EventArgs e)
        {

        }   
    }
}
