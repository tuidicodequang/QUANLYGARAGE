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
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString; // Thay thế bằng chuỗi kết nối của bạn

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
    }
}
