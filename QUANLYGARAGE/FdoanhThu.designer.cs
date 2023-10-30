
namespace DashboardApp
{
    partial class FdoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(14, 15);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 27);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(156, 16);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 27);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Location = new System.Drawing.Point(942, 14);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLast30Days.Location = new System.Drawing.Point(792, 14);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "30 ngày trước";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLast7Days.Location = new System.Drawing.Point(641, 14);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnToday.Location = new System.Drawing.Point(495, 14);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCustomDate.Location = new System.Drawing.Point(341, 13);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(130, 35);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "tùy chỉnh";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Location = new System.Drawing.Point(286, 14);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(45, 34);
            this.btnOkCustomDate.TabIndex = 8;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 73);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "+15%";
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(74, 34);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(97, 29);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(75, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số đơn ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(302, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 73);
            this.panel2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(273, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "+21%";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(74, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(97, 29);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(75, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doanh Thu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblNumSuppliers);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(14, 403);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 230);
            this.panel4.TabIndex = 10;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(59, 185);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(97, 29);
            this.lblNumProducts.TabIndex = 6;
            this.lblNumProducts.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(60, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Products";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.AutoSize = true;
            this.lblNumSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSuppliers.Location = new System.Drawing.Point(59, 125);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(97, 29);
            this.lblNumSuppliers.TabIndex = 4;
            this.lblNumSuppliers.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(60, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Suppliers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Counters";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(59, 65);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(97, 29);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(254, 403);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(493, 230);
            this.panel5.TabIndex = 11;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(15, 45);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.Size = new System.Drawing.Size(456, 194);
            this.dgvUnderstock.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Low stock products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(75, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lợi nhuận";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(74, 34);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(97, 29);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "100000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label11.Location = new System.Drawing.Point(179, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "+19%";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(707, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 73);
            this.panel3.TabIndex = 11;
            // 
            // chartDT
            // 
            chartArea7.Name = "ChartDT";
            this.chartDT.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartDT.Legends.Add(legend7);
            this.chartDT.Location = new System.Drawing.Point(12, 138);
            this.chartDT.Name = "chartDT";
            series7.ChartArea = "ChartDT";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartDT.Series.Add(series7);
            this.chartDT.Size = new System.Drawing.Size(735, 257);
            this.chartDT.TabIndex = 12;
            this.chartDT.Text = "Doanh Thu";
            // 
            // chartTopProducts
            // 
            chartArea8.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend8);
            this.chartTopProducts.Location = new System.Drawing.Point(752, 138);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            this.chartTopProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartTopProducts.Series.Add(series8);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 495);
            this.chartTopProducts.TabIndex = 14;
            this.chartTopProducts.Text = "chartTopProducts";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.Name = "Title1";
            title4.Text = "5 Best selling products";
            this.chartTopProducts.Titles.Add(title4);
            // 
            // FdoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FdoanhThu";
            this.Text = "Store statistics";
            this.Load += new System.EventHandler(this.FdoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
    }
}