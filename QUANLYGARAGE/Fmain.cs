using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYGARAGE
{
    public partial class fTabManager : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize;

        public fTabManager()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size

        }


        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                iconButton1.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                iconButton1.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Buttlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flogin formLogin = (Flogin)Application.OpenForms["flogin"];
            this.Close();
            formLogin.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                fTabManager_Load(sender as Form, e);
            }
        }

        private void ButtNhanVien_Click(object sender, EventArgs e)
        {
            FNhanVien f = new FNhanVien();
            OpenchildForm(f);
        }

        private void ButtKhachHang_Click(object sender, EventArgs e)
        {
            FKhachHang f= new FKhachHang(); 
            OpenchildForm(f);
        }

        private void ButtSanPham_Click(object sender, EventArgs e)
        {
            FCarList f = new FCarList();
            OpenchildForm(f);
        }

        private void ButtDoanhThu_Click(object sender, EventArgs e)
        {
            FdoanhThu f= new FdoanhThu();
            OpenchildForm(f);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        public void fTabManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flogin formLogin = (Flogin)Application.OpenForms["flogin"];
            formLogin.Close();
        }

        private void fTabManager_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-LACK88J\SQLEXPRESS;Initial Catalog=QuanLyOTo;Integrated Security=True";
            string countNhanVien = "SELECT COUNT(*) FROM NhanVien";
            string countKhachHang = "SELECT COUNT(*) FROM KhachHang";
            string countSanPham = "SELECT COUNT(*) FROM SanPham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand(countNhanVien, connection);
                int NhanVien = (int)command1.ExecuteScalar();
                SqlCommand command2 = new SqlCommand(countKhachHang, connection);
                int KhachHang = (int)command2.ExecuteScalar();
                SqlCommand command3 = new SqlCommand(countSanPham, connection);
                int SanPham = (int)command3.ExecuteScalar();

                lblCountNhanVien.Text = NhanVien.ToString() ;
                lblCountKhachHang.Text = KhachHang.ToString();
                lblCountSanPham.Text = SanPham.ToString();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

