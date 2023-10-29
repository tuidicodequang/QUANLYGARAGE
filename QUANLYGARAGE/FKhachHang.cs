using QUANLYGARAGE;
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
            string connectionString = @"Data Source=DESKTOP-6ABDHJO\SQLEXPRESS;Initial Catalog=QuanlyOto;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

            string query = "SELECT * FROM KhachHang"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvKH.DataSource = dataTable; // Gán dữ liệu vào DataGridView
            }
        }
    }
}
