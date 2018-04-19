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
    public partial class NhapHang : Form
    {
        public NhapHang()
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

        private void showData() //do date len datagridview
        {
            string query = "SELECT * FROM NhapHang";
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

        int row = 0;// do du lieu tu datagrid len text
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            MaNhaptextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            NgayNhaptextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            MaCHtextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
            NhaCCtextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            MaNVtextBox.Text = dataGridView1.Rows[row].Cells[4].Value.ToString().Trim();

            MaNhaptextBox2.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            NhaCCtextBox2.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();

            ShowDataNhapHang();


        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (MaNhaptextBox.Text.Trim().Length != 0)
            {

                string query = @"INSERT dbo.NhapHang VALUES ( '" + MaNhaptextBox.Text.Trim() + "','" + NgayNhaptextBox.Text.Trim() 
                    + "','" + MaCHtextBox.Text.Trim() + "','" + NhaCCtextBox.Text.Trim() + "' ,'" + MaNVtextBox.Text.Trim() + "')";

                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            }
            else
            {
                MessageBox.Show("Không được để trống mã cửa hàng");
            }
        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            if (MaNhaptextBox.Text.Trim().Length != 0)
            {
                string query = "UPDATE dbo.NhapHang SET manhap='" + MaNhaptextBox.Text.Trim() + "' ,ngaynhap = '" 
                    + NgayNhaptextBox.Text.Trim() + "',mach = '" + MaCHtextBox.Text.Trim() + "',mancc ='" 
                    + NhaCCtextBox.Text.Trim() + "',manv ='" + MaNVtextBox.Text.Trim() + "'WHERE manhap ='" 
                    + MaNhaptextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.NhapHang WHERE manhap LIKE'%" + SearchtextBox.Text.Trim() 
                + "' OR ngaynhap LIKE '%" + SearchtextBox.Text.Trim() + "' OR mach LIKE'%" + SearchtextBox.Text.Trim() 
                + "' OR mancc LIKE '%" + SearchtextBox.Text.Trim() + "' OR  manv LIKE '%" + SearchtextBox.Text.Trim() + "'";

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
            if (MaNhaptextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE dbo.NhapHang WHERE manhap = '" + MaNhaptextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm nhập");
            }
        }


//////////////////////
        private void  ShowDataNhapHang()
        {
            try
            {
                if (MaNhaptextBox.Text.Trim().Length != 0)
                {
                    string query = "SELECT nh.manhap as mn,spn.mamh as mh,mh.tenhang as th,spn.soluong as sl,mh.dongia as dg FROM dbo.NhapHang AS nh, dbo.SpNhap AS spn ,dbo.MatHang AS mh WHERE nh.manhap = spn.manhap AND spn.mamh =mh.mamh AND nh.manhap = '" + MaNhaptextBox.Text.Trim() + "'";
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
    

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row2;
            row2 = e.RowIndex;
            matHangtextBox2.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
            soLuongtextBox.Text = dataGridView2.Rows[row2].Cells[3].Value.ToString().Trim();
        }



        private void addButton2_Click_1(object sender, EventArgs e)
        {
            if (MaNhaptextBox2.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.SpNhap ( manhap, mamh, soluong, mancc )
                            VALUES ('" + MaNhaptextBox2.Text.Trim() + "','" + matHangtextBox2.Text.Trim() + "'," 
                                       + soLuongtextBox.Text.Trim() + ",'" + NhaCCtextBox2.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                ShowDataNhapHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }



        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (MaNhaptextBox2.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.SpNhap SET mamh ='" + matHangtextBox2.Text.Trim() + "',soluong =" 
                    + soLuongtextBox.Text.Trim() + "WHERE manhap = '" + MaNhaptextBox2.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                ShowDataNhapHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập");
            }
        }

        private void Deletebutton2_Click(object sender, EventArgs e)
        {
            if (MaNhaptextBox2.Text.Trim().Length != 0)
            {
                string query = @"DELETE dbo.SpNhap WHERE manhap= '" + MaNhaptextBox2.Text.Trim() + "' AND mamh = '" + matHangtextBox2.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                    ShowDataNhapHang();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục");
            }
        }
    }
}
