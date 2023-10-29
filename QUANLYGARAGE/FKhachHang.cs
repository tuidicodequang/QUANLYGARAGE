using QUANLYGARAGE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Project
{
    public partial class FKhachHang : Form
    {

        public FKhachHang()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenchildForm(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panel1.Controls.Add(childFrom);
            panel1.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FThemKhachHang f= new FThemKhachHang();
            OpenchildForm(f);
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dgvCustomer.DataSource= data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenKhachHang = TimKH.Text;
            string query = "SELECT * FROM KhachHang where HoTen = '"+tenKhachHang+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dgvCustomer.DataSource = data;
        }
    }
}
