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
using WindowsFormsApp1;

namespace Project
{
    public partial class FKhachHang : Form
    {
        List<KhachHang> dskhachhang = new List<KhachHang>();
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
            string connectionString = DataProvider.Instance.connectionString;

            string query = "SELECT * FROM KhachHang"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvKH.DataSource = dataTable; // Gán dữ liệu vào DataGridView
                dskhachhang = ConvertDataTableToList(dataTable);
            }
        }
        private List<KhachHang> ConvertDataTableToList(DataTable dataTable)
        {
            List<KhachHang> dskhachhang = new List<KhachHang>();

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHang nhanVien = new KhachHang();
                nhanVien.Username = row["Username"].ToString();
                nhanVien.Makh = row["MaKH"].ToString();
                nhanVien.Hoten = row["HoTen"].ToString();
                nhanVien.Gioitinh = row["GioiTinh"].ToString();
                nhanVien.Ngaysinh = Convert.ToDateTime(row["NgaySinh"]);
                nhanVien.Matkhau = row["MatKhau"].ToString();
                nhanVien.Diachi = row["DiaChi"].ToString();
                nhanVien.Sdt = row["Sdt"].ToString();


                dskhachhang.Add(nhanVien);
            }

            return dskhachhang;
        }

        private void dgvKH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvKH.HitTest(e.X, e.Y);
                dgvKH.Rows[hti.RowIndex].Selected = true;
                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvKH.SelectedRows[0].Index;
                    string Username = dgvKH.Rows[selectedRowIndex].Cells["Username"].Value.ToString();

                    string connectionString = DataProvider.Instance.connectionString;
                    string query = "DELETE FROM KhachHang WHERE Username = @Username";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", Username);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!");
                            FKhachHang_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên không thành công!");
                        }
                    }
                }
            }
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                FUpdateKhachHang fUpdateKhachHang = new FUpdateKhachHang();
                int selectedRowIndex = dgvKH.SelectedRows[0].Index;
                string UsernameUpdate = dgvKH.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
                fUpdateKhachHang.khUpdate = dskhachhang[selectedRowIndex];
                fUpdateKhachHang.FormClosed += (s, args) => {
                    if (fUpdateKhachHang.khUpdate != null)
                    {
                        string connectionString = DataProvider.Instance.connectionString;
                        string query = "UPDATE KhachHang SET Username = @Username, MaKH = @MaKH, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,MatKhau=@MatKHau,DiaChi=@DiaChi,Sdt=@Sdt WHERE Username = @UsernameUpdate";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Username", fUpdateKhachHang.khUpdate.Username);
                            command.Parameters.AddWithValue("@MaKH", fUpdateKhachHang.khUpdate.Makh);
                            command.Parameters.AddWithValue("@HoTen", fUpdateKhachHang.khUpdate.Hoten);
                            command.Parameters.AddWithValue("@GioiTinh", fUpdateKhachHang.khUpdate.Gioitinh);
                            command.Parameters.AddWithValue("@NgaySinh", fUpdateKhachHang.khUpdate.Ngaysinh);
                            command.Parameters.AddWithValue("@MatKhau", fUpdateKhachHang.khUpdate.Matkhau);
                            command.Parameters.AddWithValue("@DiaChi", fUpdateKhachHang.khUpdate.Diachi);
                            command.Parameters.AddWithValue("@Sdt", fUpdateKhachHang.khUpdate.Sdt);
                            command.Parameters.AddWithValue("@UsernameUpdate", UsernameUpdate);

                            int rowsAffected = command.ExecuteNonQuery(); // Execute the update command

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật nhân viên thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật nhân viên không thành công!");
                            }
                        }

                        FKhachHang_Load(sender, e);
                    }
                };

                OpenchildForm(fUpdateKhachHang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.");
            }
        }

    }

}
