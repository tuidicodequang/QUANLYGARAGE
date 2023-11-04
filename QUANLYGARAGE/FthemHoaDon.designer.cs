namespace Project
{
    partial class FthemHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FthemHoaDon));
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.dateTimePickerNgayGD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.buttonThemXe = new System.Windows.Forms.Button();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCountSP = new System.Windows.Forms.NumericUpDown();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.NewOrder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountSP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 692);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tổng  : ";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(160, 129);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 17);
            this.lblOrderId.TabIndex = 24;
            // 
            // dateTimePickerNgayGD
            // 
            this.dateTimePickerNgayGD.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerNgayGD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgayGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayGD.Location = new System.Drawing.Point(195, 301);
            this.dateTimePickerNgayGD.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgayGD.Name = "dateTimePickerNgayGD";
            this.dateTimePickerNgayGD.Size = new System.Drawing.Size(172, 27);
            this.dateTimePickerNgayGD.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(38, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày Giao dịch";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 56);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tạo hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTenKH
            // 
            this.cbTenKH.Enabled = false;
            this.cbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(184, 146);
            this.cbTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(172, 28);
            this.cbTenKH.TabIndex = 33;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Enabled = false;
            this.buttonHuy.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.Image")));
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(612, 692);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(88, 35);
            this.buttonHuy.TabIndex = 29;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(460, 692);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 35);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Thoát";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // buttonThemXe
            // 
            this.buttonThemXe.Enabled = false;
            this.buttonThemXe.Image = ((System.Drawing.Image)(resources.GetObject("buttonThemXe.Image")));
            this.buttonThemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemXe.Location = new System.Drawing.Point(652, 147);
            this.buttonThemXe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemXe.Name = "buttonThemXe";
            this.buttonThemXe.Size = new System.Drawing.Size(153, 79);
            this.buttonThemXe.TabIndex = 26;
            this.buttonThemXe.Text = "Thêm Xe";
            this.buttonThemXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemXe.UseVisualStyleBackColor = true;
            this.buttonThemXe.Click += new System.EventHandler(this.buttonThemXe_Click);
            // 
            // buttonDongY
            // 
            this.buttonDongY.Enabled = false;
            this.buttonDongY.Image = ((System.Drawing.Image)(resources.GetObject("buttonDongY.Image")));
            this.buttonDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDongY.Location = new System.Drawing.Point(728, 692);
            this.buttonDongY.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(88, 35);
            this.buttonDongY.TabIndex = 27;
            this.buttonDongY.Text = "Đồng ý";
            this.buttonDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(38, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên khách hàng";
            // 
            // dgvSP
            // 
            this.dgvSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSP.ColumnHeadersHeight = 29;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSP.Location = new System.Drawing.Point(12, 357);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 27;
            this.dgvSP.Size = new System.Drawing.Size(847, 301);
            this.dgvSP.TabIndex = 38;
            this.dgvSP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSP_MouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 125;
            // 
            // textMaHD
            // 
            this.textMaHD.Enabled = false;
            this.textMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHD.Location = new System.Drawing.Point(184, 87);
            this.textMaHD.Name = "textMaHD";
            this.textMaHD.Size = new System.Drawing.Size(172, 27);
            this.textMaHD.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(38, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(38, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(216, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Màu";
            // 
            // nmCountSP
            // 
            this.nmCountSP.Enabled = false;
            this.nmCountSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmCountSP.Location = new System.Drawing.Point(122, 251);
            this.nmCountSP.Name = "nmCountSP";
            this.nmCountSP.Size = new System.Drawing.Size(71, 27);
            this.nmCountSP.TabIndex = 43;
            // 
            // cbColor
            // 
            this.cbColor.Enabled = false;
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(264, 250);
            this.cbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(92, 28);
            this.cbColor.TabIndex = 44;
            // 
            // textTongTien
            // 
            this.textTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTongTien.Location = new System.Drawing.Point(108, 690);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(223, 27);
            this.textTongTien.TabIndex = 45;
            // 
            // cbTenSP
            // 
            this.cbTenSP.Enabled = false;
            this.cbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(184, 201);
            this.cbTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(172, 28);
            this.cbTenSP.TabIndex = 46;
            this.cbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbTenSP_SelectedIndexChanged);
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(652, 68);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(153, 42);
            this.NewOrder.TabIndex = 47;
            this.NewOrder.Text = "NewOrder";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.xóaToolStripMenuItem.Text = "&Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // FthemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.textTongTien);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.nmCountSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMaHD);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTenKH);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonThemXe);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.dateTimePickerNgayGD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FthemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountSP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThemXe;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayGD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TextBox textMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCountSP;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}