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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public partial class FThemXe : Form
    {
       
        public FThemXe()
        {
            InitializeComponent();
            LoadcboModel();
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString;

            string maSanPham = textMaSP.Text;
            string Hangxe = cboModel.Text;
            string model = textModel.Text;
            string mausac = textMau.Text;
            string giatien=textGia.Text;
          
   

            string query = "INSERT INTO SanPham (MaSP, TenSP, Hang, Mau, Gia) VALUES (@MaSanPham,@Model,@HangXe,@MauSac,@GiaTien)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                command.Parameters.AddWithValue("@HangXe", Hangxe);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@MauSac", mausac);
                command.Parameters.AddWithValue("@GiaTien", giatien);
              

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    // Thực hiện các công việc khác sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }
            }
        }
        void LoadcboModel()
        {
            SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionString);
            string query = "select * from dbo.Hang";
            {
                conn.Open();
        
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                cboModel.DataSource = dataTable;
                cboModel.DisplayMember = "TenHang";

            }
            
        }

        private void FThemXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyOtoDataSet.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.quanlyOtoDataSet.Hang);

        }
    }
}
