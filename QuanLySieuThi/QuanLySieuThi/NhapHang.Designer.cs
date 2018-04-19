namespace QuanLySieuThi
{
    partial class NhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NhaCCtextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.changeButton2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soLuongtextBox = new System.Windows.Forms.TextBox();
            this.matHangtextBox2 = new System.Windows.Forms.TextBox();
            this.MaNhaptextBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.changeButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MaNVtextBox = new System.Windows.Forms.TextBox();
            this.NhaCCtextBox = new System.Windows.Forms.TextBox();
            this.MaCHtextBox = new System.Windows.Forms.TextBox();
            this.NgayNhaptextBox = new System.Windows.Forms.TextBox();
            this.MaNhaptextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.Searchbutton);
            this.panel3.Controls.Add(this.SearchtextBox);
            this.panel3.Location = new System.Drawing.Point(12, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 343);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhap,
            this.ngaynhap,
            this.mach,
            this.mancc,
            this.manv});
            this.dataGridView1.Location = new System.Drawing.Point(20, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 263);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // manhap
            // 
            this.manhap.DataPropertyName = "manhap";
            this.manhap.HeaderText = "Mã phiếu nhập";
            this.manhap.Name = "manhap";
            this.manhap.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // mach
            // 
            this.mach.DataPropertyName = "mach";
            this.mach.HeaderText = "Mã cửa hàng";
            this.mach.Name = "mach";
            this.mach.ReadOnly = true;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Nhà cung cấp";
            this.mancc.Name = "mancc";
            this.mancc.ReadOnly = true;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Nhân viên nhập";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(477, 14);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(83, 46);
            this.Searchbutton.TabIndex = 4;
            this.Searchbutton.Text = "Tìm kiếm";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(20, 26);
            this.SearchtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(439, 22);
            this.SearchtextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NhaCCtextBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.deleteButton2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.changeButton2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addButton2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.soLuongtextBox);
            this.panel2.Controls.Add(this.matHangtextBox2);
            this.panel2.Controls.Add(this.MaNhaptextBox2);
            this.panel2.Location = new System.Drawing.Point(589, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 524);
            this.panel2.TabIndex = 3;
            // 
            // NhaCCtextBox2
            // 
            this.NhaCCtextBox2.Location = new System.Drawing.Point(120, 367);
            this.NhaCCtextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhaCCtextBox2.Name = "NhaCCtextBox2";
            this.NhaCCtextBox2.ReadOnly = true;
            this.NhaCCtextBox2.Size = new System.Drawing.Size(245, 22);
            this.NhaCCtextBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhà cung cấp";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mn,
            this.mh,
            this.th,
            this.sl,
            this.dg});
            this.dataGridView2.Location = new System.Drawing.Point(13, 14);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(351, 295);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // mn
            // 
            this.mn.DataPropertyName = "mn";
            this.mn.HeaderText = "Mã nhập";
            this.mn.Name = "mn";
            this.mn.ReadOnly = true;
            // 
            // mh
            // 
            this.mh.DataPropertyName = "mh";
            this.mh.HeaderText = "Mặt hàng";
            this.mh.Name = "mh";
            this.mh.ReadOnly = true;
            // 
            // th
            // 
            this.th.DataPropertyName = "th";
            this.th.HeaderText = "Tên hàng";
            this.th.Name = "th";
            this.th.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "sl";
            this.sl.HeaderText = "Số lượng";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "dg";
            this.dg.HeaderText = "Đơn giá";
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(283, 464);
            this.deleteButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(83, 46);
            this.deleteButton2.TabIndex = 4;
            this.deleteButton2.Text = "Xóa";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.Deletebutton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã mặt hàng";
            // 
            // changeButton2
            // 
            this.changeButton2.Location = new System.Drawing.Point(153, 464);
            this.changeButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton2.Name = "changeButton2";
            this.changeButton2.Size = new System.Drawing.Size(83, 46);
            this.changeButton2.TabIndex = 4;
            this.changeButton2.Text = "Sửa";
            this.changeButton2.UseVisualStyleBackColor = true;
            this.changeButton2.Click += new System.EventHandler(this.changeButton2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã nhập";
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(13, 464);
            this.addButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(83, 46);
            this.addButton2.TabIndex = 4;
            this.addButton2.Text = "Thêm";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Lượng";
            // 
            // soLuongtextBox
            // 
            this.soLuongtextBox.Location = new System.Drawing.Point(120, 423);
            this.soLuongtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soLuongtextBox.Name = "soLuongtextBox";
            this.soLuongtextBox.Size = new System.Drawing.Size(245, 22);
            this.soLuongtextBox.TabIndex = 3;
            // 
            // matHangtextBox2
            // 
            this.matHangtextBox2.Location = new System.Drawing.Point(120, 396);
            this.matHangtextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matHangtextBox2.Name = "matHangtextBox2";
            this.matHangtextBox2.Size = new System.Drawing.Size(245, 22);
            this.matHangtextBox2.TabIndex = 3;
            // 
            // MaNhaptextBox2
            // 
            this.MaNhaptextBox2.Location = new System.Drawing.Point(117, 331);
            this.MaNhaptextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaNhaptextBox2.Name = "MaNhaptextBox2";
            this.MaNhaptextBox2.ReadOnly = true;
            this.MaNhaptextBox2.Size = new System.Drawing.Size(245, 22);
            this.MaNhaptextBox2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton1);
            this.panel1.Controls.Add(this.changeButton1);
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MaNVtextBox);
            this.panel1.Controls.Add(this.NhaCCtextBox);
            this.panel1.Controls.Add(this.MaCHtextBox);
            this.panel1.Controls.Add(this.NgayNhaptextBox);
            this.panel1.Controls.Add(this.MaNhaptextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 175);
            this.panel1.TabIndex = 2;
            // 
            // deleteButton1
            // 
            this.deleteButton1.Location = new System.Drawing.Point(228, 113);
            this.deleteButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(83, 46);
            this.deleteButton1.TabIndex = 4;
            this.deleteButton1.Text = "Xóa";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton1
            // 
            this.changeButton1.Location = new System.Drawing.Point(124, 113);
            this.changeButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton1.Name = "changeButton1";
            this.changeButton1.Size = new System.Drawing.Size(83, 46);
            this.changeButton1.TabIndex = 4;
            this.changeButton1.Text = "Sửa";
            this.changeButton1.UseVisualStyleBackColor = true;
            this.changeButton1.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(20, 113);
            this.addButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(83, 46);
            this.addButton1.TabIndex = 4;
            this.addButton1.Text = "Thêm";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // MaNVtextBox
            // 
            this.MaNVtextBox.Location = new System.Drawing.Point(400, 52);
            this.MaNVtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaNVtextBox.Name = "MaNVtextBox";
            this.MaNVtextBox.Size = new System.Drawing.Size(160, 22);
            this.MaNVtextBox.TabIndex = 3;
            // 
            // NhaCCtextBox
            // 
            this.NhaCCtextBox.Location = new System.Drawing.Point(400, 22);
            this.NhaCCtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhaCCtextBox.Name = "NhaCCtextBox";
            this.NhaCCtextBox.Size = new System.Drawing.Size(160, 22);
            this.NhaCCtextBox.TabIndex = 3;
            // 
            // MaCHtextBox
            // 
            this.MaCHtextBox.Location = new System.Drawing.Point(113, 73);
            this.MaCHtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaCHtextBox.Name = "MaCHtextBox";
            this.MaCHtextBox.Size = new System.Drawing.Size(153, 22);
            this.MaCHtextBox.TabIndex = 3;
            // 
            // NgayNhaptextBox
            // 
            this.NgayNhaptextBox.Location = new System.Drawing.Point(113, 46);
            this.NgayNhaptextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NgayNhaptextBox.Name = "NgayNhaptextBox";
            this.NgayNhaptextBox.Size = new System.Drawing.Size(153, 22);
            this.NgayNhaptextBox.TabIndex = 3;
            // 
            // MaNhaptextBox
            // 
            this.MaNhaptextBox.Location = new System.Drawing.Point(113, 17);
            this.MaNhaptextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaNhaptextBox.Name = "MaNhaptextBox";
            this.MaNhaptextBox.Size = new System.Drawing.Size(153, 22);
            this.MaNhaptextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã cửa hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhập";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soLuongtextBox;
        private System.Windows.Forms.TextBox matHangtextBox2;
        private System.Windows.Forms.TextBox MaNhaptextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button changeButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaNVtextBox;
        private System.Windows.Forms.TextBox NhaCCtextBox;
        private System.Windows.Forms.TextBox MaCHtextBox;
        private System.Windows.Forms.TextBox NgayNhaptextBox;
        private System.Windows.Forms.TextBox MaNhaptextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn th;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.TextBox NhaCCtextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mach;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
    }
}