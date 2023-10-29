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
using WindowsFormsApp1;

namespace QUANLYGARAGE
{
    public partial class FHoaDon : Form
    {
        public FHoaDon()
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
        private void FHoaDon_Load(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString;

            string query = "SELECT * FROM HoaDon"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvHD.DataSource = dataTable; // Gán dữ liệu vào DataGridView
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FthemHoaDon f = new FthemHoaDon();
            OpenchildForm(f);
        }
    }
}
