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
    public partial class FNhanVien : Form
    {
        List<NhanVien> dsNhanVien= new List<NhanVien>();
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FthemNhanVien f=new FthemNhanVien();
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
        
        private void FNhanVien_Load(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString;

            string query = "SELECT * FROM NhanVien"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvNV.DataSource = dataTable;
                dsNhanVien =ConvertDataTableToList(dataTable);
                // Gán dữ liệu vào DataGridView
            }
        }
        private List<NhanVien> ConvertDataTableToList(DataTable dataTable)
        {
            List<NhanVien> dsnhanVien = new List<NhanVien>();

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.Username = row["Username"].ToString();
                nhanVien.Manv = row["MaNV"].ToString();
                nhanVien.Hoten = row["HoTen"].ToString();
                nhanVien.Gioitinh = row["GioiTinh"].ToString();
                nhanVien.Ngaysinh = Convert.ToDateTime(row["NgaySinh"]);
                nhanVien.Matkhau = row["MatKhau"].ToString();
                nhanVien.Diachi = row["DiaChi"].ToString();
                nhanVien.Sdt = row["Sdt"].ToString();


                dsnhanVien.Add(nhanVien);
            }

            return dsnhanVien;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            string connectionString = DataProvider.Instance.connectionString; // Thay thế bằng chuỗi kết nối của bạn
            string tenNhanVien = textTimNV.Text;
            string query = "SELECT * FROM NhanVien WHERE HoTen = @TenNhanVien"; // Truy vấn để lấy dữ liệu nhân viên

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvNV.DataSource = dataTable; // Gán dữ liệu vào DataGridView
            }
        }

        private void dgvNV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvNV.HitTest(e.X, e.Y);
                dgvNV.Rows[hti.RowIndex].Selected = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvNV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvNV.SelectedRows[0].Index;
                    string Username = dgvNV.Rows[selectedRowIndex].Cells["Username"].Value.ToString(); 

                    string connectionString = DataProvider.Instance.connectionString; 
                    string query = "DELETE FROM NhanVien WHERE Username = @Username";

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
                            FNhanVien_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên không thành công!");
                        }
                    }
                }
            }
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                FUpdateNhanVien fUpdateNhanVien = new FUpdateNhanVien();
                int selectedRowIndex = dgvNV.SelectedRows[0].Index;
                string UsernameUpdate = dgvNV.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
                fUpdateNhanVien.nvUpdate = dsNhanVien[selectedRowIndex];
                fUpdateNhanVien.FormClosed += (s, args) => {
                   if (fUpdateNhanVien.nvUpdate != null)
                   {
                        string connectionString = DataProvider.Instance.connectionString;
                        string query = "UPDATE NhanVien SET Username = @Username, MaNV = @MaNV, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,MatKhau=@MatKHau,DiaChi=@DiaChi,Sdt=@Sdt WHERE Username = @UsernameUpdate";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Username", fUpdateNhanVien.nvUpdate.Username);
                            command.Parameters.AddWithValue("@MaNV", fUpdateNhanVien.nvUpdate.Manv);
                            command.Parameters.AddWithValue("@HoTen", fUpdateNhanVien.nvUpdate.Hoten);
                            command.Parameters.AddWithValue("@GioiTinh", fUpdateNhanVien.nvUpdate.Gioitinh);
                            command.Parameters.AddWithValue("@NgaySinh", fUpdateNhanVien.nvUpdate.Ngaysinh);
                            command.Parameters.AddWithValue("@MatKhau", fUpdateNhanVien.nvUpdate.Matkhau);
                            command.Parameters.AddWithValue("@DiaChi", fUpdateNhanVien.nvUpdate.Diachi);
                            command.Parameters.AddWithValue("@Sdt", fUpdateNhanVien.nvUpdate.Sdt);
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

                        FNhanVien_Load(sender, e);
                    }
                };

                OpenchildForm(fUpdateNhanVien);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
            }
        }

   
    }
}

