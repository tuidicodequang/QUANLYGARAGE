using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace QUANLYGARAGE
{
    public partial class FNhanVien : Form
    {
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-6ABDHJO\SQLEXPRESS;Initial Catalog=QuanLyOTo;Integrated Security=True");
            try
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT * FROM NhanVien";
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                BangNhanVien.DataSource=dataTable;
                sqlConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
