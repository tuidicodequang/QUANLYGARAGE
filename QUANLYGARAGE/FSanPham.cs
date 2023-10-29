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
using WindowsFormsApp1;

namespace Project
{
    public partial class FCarList : Form
    {
        public FCarList()
        {
            InitializeComponent();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FThemXe f= new FThemXe();
            OpenchildForm(f);
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

        private void dgvListCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FCarList_Load(object sender, EventArgs e)
        {

            string connectionString = DataProvider.Instance.connectionString;

                string query = "SELECT * FROM SanPham"; // Truy vấn để lấy dữ liệu nhân viên

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                dgvListCar.DataSource = dataTable; // Gán dữ liệu vào DataGridView
                }
         }
        

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString;
            string tensanpham = TimXe.Text;
            string query = "SELECT * FROM SanPham WHERE TenSP = @TenSanPham"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenSanPham", tensanpham);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvListCar.DataSource = dataTable; // Gán dữ liệu vào DataGridView
            }
        }
    }
}
