﻿namespace QuanLySieuThi
{
    partial class DangKy
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
            this.saveButton = new System.Windows.Forms.Button();
            this.checkPassTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameRecomend = new System.Windows.Forms.Label();
            this.passWordRecomend = new System.Windows.Forms.Label();
            this.checkPassRecomend = new System.Windows.Forms.Label();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(182, 255);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 46);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Đăng ký";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkPassTextBox
            // 
            this.checkPassTextBox.Location = new System.Drawing.Point(182, 200);
            this.checkPassTextBox.Name = "checkPassTextBox";
            this.checkPassTextBox.Size = new System.Drawing.Size(163, 22);
            this.checkPassTextBox.TabIndex = 8;
            this.checkPassTextBox.UseSystemPasswordChar = true;
            this.checkPassTextBox.TextChanged += new System.EventHandler(this.checkPassTextBox_TextChanged);
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(182, 155);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(163, 22);
            this.passWordTextBox.TabIndex = 9;
            this.passWordTextBox.UseSystemPasswordChar = true;
            this.passWordTextBox.TextChanged += new System.EventHandler(this.passWordTextBox_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(182, 38);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.userNameTextBox.TabIndex = 11;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phân quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên tài khoản";
            // 
            // userNameRecomend
            // 
            this.userNameRecomend.AutoSize = true;
            this.userNameRecomend.Location = new System.Drawing.Point(351, 43);
            this.userNameRecomend.Name = "userNameRecomend";
            this.userNameRecomend.Size = new System.Drawing.Size(0, 17);
            this.userNameRecomend.TabIndex = 7;
            // 
            // passWordRecomend
            // 
            this.passWordRecomend.AutoSize = true;
            this.passWordRecomend.BackColor = System.Drawing.SystemColors.Control;
            this.passWordRecomend.ForeColor = System.Drawing.Color.Red;
            this.passWordRecomend.Location = new System.Drawing.Point(351, 155);
            this.passWordRecomend.Name = "passWordRecomend";
            this.passWordRecomend.Size = new System.Drawing.Size(0, 17);
            this.passWordRecomend.TabIndex = 7;
            // 
            // checkPassRecomend
            // 
            this.checkPassRecomend.AutoSize = true;
            this.checkPassRecomend.ForeColor = System.Drawing.Color.Red;
            this.checkPassRecomend.Location = new System.Drawing.Point(351, 203);
            this.checkPassRecomend.Name = "checkPassRecomend";
            this.checkPassRecomend.Size = new System.Drawing.Size(0, 17);
            this.checkPassRecomend.TabIndex = 7;
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.Checked = true;
            this.staffRadioButton.Location = new System.Drawing.Point(182, 82);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(209, 21);
            this.staffRadioButton.TabIndex = 13;
            this.staffRadioButton.TabStop = true;
            this.staffRadioButton.Text = "Đăng ký tài khoản nhân viên";
            this.staffRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(182, 118);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(223, 21);
            this.adminRadioButton.TabIndex = 13;
            this.adminRadioButton.Text = "Đăng ký tài khoản nhà quản trị";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 345);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.staffRadioButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkPassTextBox);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkPassRecomend);
            this.Controls.Add(this.passWordRecomend);
            this.Controls.Add(this.userNameRecomend);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox checkPassTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameRecomend;
        private System.Windows.Forms.Label passWordRecomend;
        private System.Windows.Forms.Label checkPassRecomend;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
    }
}