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
    public partial class FCarList : Form
    {
        List<SanPham> dsSanpham = new List<SanPham>();
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

            string connectionString = DataProvider.Instance.connectionString; // Thay thế bằng chuỗi kết nối của bạn

                string query = "SELECT * FROM SanPham"; // Truy vấn để lấy dữ liệu nhân viên

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                dgvListCar.DataSource = dataTable; // Gán dữ liệu vào DataGridView
                dsSanpham = ConvertDataTableToList(dataTable);
                }
        }



        private List<SanPham> ConvertDataTableToList(DataTable dataTable)
        {
            List<SanPham> dsSanpham = new List<SanPham>();

            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanpham = new SanPham();
                sanpham.MaSP = row["MaSP"].ToString();
                sanpham.Tensp = row["TenSP"].ToString();
                sanpham.Hang = row["Hang"].ToString();
                sanpham.Mau = row["Mau"].ToString();
                sanpham.Gia = long.Parse(row["Gia"].ToString());
                dsSanpham.Add(sanpham);
            }

            return dsSanpham;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString; // Thay thế bằng chuỗi kết nối của bạn
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

        private void dgvListCar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvListCar.HitTest(e.X, e.Y);
                dgvListCar.Rows[hti.RowIndex].Selected = true;
                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selectedRowIndex = dgvListCar.SelectedRows[0].Index;
                string MaSP = dgvListCar.Rows[selectedRowIndex].Cells["MaSP"].Value.ToString();

                string connectionString = DataProvider.Instance.connectionString;
                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", MaSP);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        FCarList_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công!");
                    }
                }
            }
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FUpdateSanPham fUpdateNhanVien = new FUpdateSanPham();
            fUpdateNhanVien.spUpdate = dsSanpham[dgvListCar.CurrentCell.RowIndex];
            OpenchildForm(fUpdateNhanVien);
            dgvListCar.DataSource = null;
            dgvListCar.DataSource = dsSanpham;
        }
    }
}
