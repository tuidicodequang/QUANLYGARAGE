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
    public partial class FthemNhanVien : Form
    {
        public FthemNhanVien()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FthemNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            string connectionString = DataProvider.Instance.connectionString;

                string maNV = textMANV.Text;
                string hoTen = textHoTen.Text; 
                string diaChi = txtDiaChiNV.Text;
                string sdt = textSDT.Text;
                string gioiTinh = TickNam.Checked ? TickNam.Text : TichNu.Text;
                DateTime ngaySinh = textNgaySinh.Value;
                string user = textUser.Text;
                string password = textPassword.Text;

                string query = "INSERT INTO NhanVien (Username, MaNV, HoTen, GioiTinh, NgaySinh,MatKhau, DiaChi, SDT) VALUES (@Username,@MaNV, @HoTen, @GioiTinh, @NgaySinh,@MatKhau, @DiaChi, @SDT)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", user);
                    command.Parameters.AddWithValue("@MaNV", maNV);
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

