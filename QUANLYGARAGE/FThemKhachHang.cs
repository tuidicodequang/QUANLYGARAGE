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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QUANLYGARAGE
{
    public partial class FThemKhachHang : Form
    {
        public FThemKhachHang()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-6ABDHJO\SQLEXPRESS;Initial Catalog=QuanlyOto;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

            string maKH = textMaKH.Text;
            string hoTen = textHoTen.Text;
            string diaChi = textDiaChiKH.Text;
            string sdt = textSDT.Text;
            string gioiTinh = TickNam.Checked ? TickNam.Text : TickNu.Text;
            DateTime ngaySinh = textNgaySinh.Value;
            string user = textUser.Text;
            string password = textPassword.Text;

            string query = "INSERT INTO KhachHang (Username, MaKH, HoTen, GioiTinh, NgaySinh,MatKhau, DiaChi, SDT) VALUES (@Username,@MaNV, @HoTen, @GioiTinh, @NgaySinh,@MatKhau, @DiaChi, @SDT)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user);
                command.Parameters.AddWithValue("@MaNV", maKH);
                command.Parameters.AddWithValue("@HoTen", hoTen);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@MatKhau", password);
                command.Parameters.AddWithValue("@SDT", sdt);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    // Thực hiện các công việc khác sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                }
            }
        }
    }
}
