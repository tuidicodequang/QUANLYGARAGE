using System.Drawing;
using System.Windows.Forms;

namespace QUANLYGARAGE
{
    partial class fTabManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTabManager));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Buttlogout = new FontAwesome.Sharp.IconButton();
            this.ButtDoanhThu = new FontAwesome.Sharp.IconButton();
            this.ButtSanPham = new FontAwesome.Sharp.IconButton();
            this.ButtKhachHang = new FontAwesome.Sharp.IconButton();
            this.ButtNhanVien = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Controls.Add(this.Buttlogout);
            this.panelMenu.Controls.Add(this.ButtDoanhThu);
            this.panelMenu.Controls.Add(this.ButtSanPham);
            this.panelMenu.Controls.Add(this.ButtKhachHang);
            this.panelMenu.Controls.Add(this.ButtNhanVien);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(226, 676);
            this.panelMenu.TabIndex = 0;
            // 
            // Buttlogout
            // 
            this.Buttlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttlogout.FlatAppearance.BorderSize = 0;
            this.Buttlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttlogout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Buttlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buttlogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Buttlogout.IconColor = System.Drawing.Color.White;
            this.Buttlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buttlogout.IconSize = 30;
            this.Buttlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buttlogout.Location = new System.Drawing.Point(0, 639);
            this.Buttlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buttlogout.Name = "Buttlogout";
            this.Buttlogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Buttlogout.Size = new System.Drawing.Size(226, 37);
            this.Buttlogout.TabIndex = 8;
            this.Buttlogout.Tag = "Đăng xuất";
            this.Buttlogout.Text = "Đăng xuất";
            this.Buttlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buttlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buttlogout.UseVisualStyleBackColor = true;
            // 
            // ButtDoanhThu
            // 
            this.ButtDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtDoanhThu.FlatAppearance.BorderSize = 0;
            this.ButtDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtDoanhThu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtDoanhThu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtDoanhThu.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.ButtDoanhThu.IconColor = System.Drawing.Color.White;
            this.ButtDoanhThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtDoanhThu.IconSize = 30;
            this.ButtDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtDoanhThu.Location = new System.Drawing.Point(0, 281);
            this.ButtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtDoanhThu.Name = "ButtDoanhThu";
            this.ButtDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtDoanhThu.Size = new System.Drawing.Size(226, 46);
            this.ButtDoanhThu.TabIndex = 5;
            this.ButtDoanhThu.Tag = "Doanh thu";
            this.ButtDoanhThu.Text = "Doanh thu";
            this.ButtDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtDoanhThu.UseVisualStyleBackColor = true;
            // 
            // ButtSanPham
            // 
            this.ButtSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtSanPham.FlatAppearance.BorderSize = 0;
            this.ButtSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtSanPham.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtSanPham.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.ButtSanPham.IconColor = System.Drawing.Color.White;
            this.ButtSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtSanPham.IconSize = 30;
            this.ButtSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtSanPham.Location = new System.Drawing.Point(0, 235);
            this.ButtSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtSanPham.Name = "ButtSanPham";
            this.ButtSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtSanPham.Size = new System.Drawing.Size(226, 46);
            this.ButtSanPham.TabIndex = 4;
            this.ButtSanPham.Tag = "Sản phẩm";
            this.ButtSanPham.Text = "Sản phẩm";
            this.ButtSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtSanPham.UseVisualStyleBackColor = true;
            // 
            // ButtKhachHang
            // 
            this.ButtKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtKhachHang.FlatAppearance.BorderSize = 0;
            this.ButtKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtKhachHang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ButtKhachHang.IconColor = System.Drawing.Color.White;
            this.ButtKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtKhachHang.IconSize = 30;
            this.ButtKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtKhachHang.Location = new System.Drawing.Point(0, 189);
            this.ButtKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtKhachHang.Name = "ButtKhachHang";
            this.ButtKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtKhachHang.Size = new System.Drawing.Size(226, 46);
            this.ButtKhachHang.TabIndex = 3;
            this.ButtKhachHang.Tag = "Khách hàng";
            this.ButtKhachHang.Text = "Khách hàng";
            this.ButtKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtKhachHang.UseVisualStyleBackColor = true;
            // 
            // ButtNhanVien
            // 
            this.ButtNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtNhanVien.FlatAppearance.BorderSize = 0;
            this.ButtNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ButtNhanVien.IconColor = System.Drawing.Color.White;
            this.ButtNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtNhanVien.IconSize = 30;
            this.ButtNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtNhanVien.Location = new System.Drawing.Point(0, 143);
            this.ButtNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtNhanVien.Name = "ButtNhanVien";
            this.ButtNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtNhanVien.Size = new System.Drawing.Size(226, 46);
            this.ButtNhanVien.TabIndex = 2;
            this.ButtNhanVien.Tag = "Nhân viên";
            this.ButtNhanVien.Text = "Nhân viên";
            this.ButtNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtNhanVien.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 97);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(226, 46);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Tag = "Trang chủ";
            this.iconButton2.Text = " Trang chủ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 97);
            this.panel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(170, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(62, 44);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYGARAGE.Properties.Resources.lamborghini_loginpicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panel6);
            this.panelDesktop.Controls.Add(this.panel5);
            this.panelDesktop.Controls.Add(this.panel4);
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(226, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(851, 676);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.pictureBox14);
            this.panel6.Location = new System.Drawing.Point(339, 267);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 137);
            this.panel6.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.ForestGreen;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.ForestGreen;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(65, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Doanh thu";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox14.Image = global::QUANLYGARAGE.Properties.Resources.salary;
            this.pictureBox14.Location = new System.Drawing.Point(3, 8);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(191, 81);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pictureBox13);
            this.panel5.Location = new System.Drawing.Point(636, 53);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 137);
            this.panel5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(29, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(62, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khách hàng";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Gold;
            this.pictureBox13.Image = global::QUANLYGARAGE.Properties.Resources.kisspng_client_icon_businessman_icon_vector_design_5a6f77c8923c97_818921111517254600599;
            this.pictureBox13.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(191, 81);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Location = new System.Drawing.Point(636, 479);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 137);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(29, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(62, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khách hàng";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox12.Image = global::QUANLYGARAGE.Properties.Resources.cabriolet;
            this.pictureBox12.Location = new System.Drawing.Point(0, 0);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(191, 81);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Location = new System.Drawing.Point(37, 479);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 137);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(62, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doanh thu";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Navy;
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox11.Image = global::QUANLYGARAGE.Properties.Resources.checklist;
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(191, 81);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Location = new System.Drawing.Point(37, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 137);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân Viên";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox10.Image = global::QUANLYGARAGE.Properties.Resources.nhân_viên;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(191, 81);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // fTabManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 676);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTabManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý garga";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ButtDoanhThu;
        private FontAwesome.Sharp.IconButton ButtNhanVien;
        private FontAwesome.Sharp.IconButton ButtSanPham;
        private FontAwesome.Sharp.IconButton ButtKhachHang;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private FontAwesome.Sharp.IconButton Buttlogout; 
    }
}