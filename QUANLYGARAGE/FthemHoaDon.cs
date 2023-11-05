using QUANLYGARAGE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public partial class FthemHoaDon : Form
    {
       
        public FthemHoaDon()
        {
            InitializeComponent();
            LoadTenKH();
            LoadcbTenSP();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            NewOrder.Enabled = false;
            buttonThemXe.Enabled = true;
            cbTenKH.Enabled = true;
            cbTenSP.Enabled = true;
            nmCountSP.Enabled = true;
            cbColor.Enabled = true;
            buttonHuy.Enabled = true;
            buttonDongY.Enabled = true;
            textMaHD.Enabled = true;
            loadMaHoaDon();
        }

        void loadMaHoaDon()
        {
            RanDom ranDom = new RanDom();
            textMaHD.Text = ranDom.TaoMaNgauNhien().ToString();
        }
        List<ItemHoadon> listhoadon = new List<ItemHoadon>();
        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            // kiem tra san pham da co chua
            ItemHoadon itemcheck = listhoadon.FirstOrDefault(x => x.TenSP == cbTenSP.Text && x.Mau == cbColor.Text);
            if (itemcheck != null)
            {
                itemcheck.Count += int.Parse(nmCountSP.Text);
                itemcheck.TongGia = itemcheck.Count * itemcheck.Gia;
            }
            else
            {

                ItemHoadon item = new ItemHoadon();
                {
                    string query = "SELECT * FROM SanPham where TenSP ='" + cbTenSP.Text + "' and Mau ='" + cbColor.Text + "'";
                    DataTable data = DataProvider.Instance.ExcuteQuery(query);

                    if (data.Rows.Count > 0)
                    {
                        item.MaSP = data.Rows[0]["MaSP"].ToString();
                        item.Gia = long.Parse(data.Rows[0]["Gia"].ToString());
                    }

                    item.TenSP = cbTenSP.Text;
                    item.Count = int.Parse(nmCountSP.Text);
                    item.Mau = cbColor.Text;
                    item.TongGia = item.Gia * item.Count;

                }

                listhoadon.Add(item);
            }
            dgvSP.DataSource = null;
            dgvSP.DataSource = listhoadon;
            dgvSP.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgvSP.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgvSP.Columns["Mau"].HeaderText = "Màu Sản Phẩm";
            dgvSP.Columns["Count"].HeaderText = "Số lượng";
            dgvSP.Columns["Gia"].HeaderText = "Giá";
            dgvSP.Columns["TongGia"].HeaderText = "Tổng tiền";

            cbTenSP.SelectedIndex = -1;
            cbColor.SelectedIndex = -1;
            long TongGia = listhoadon.Sum(x => x.TongGia);
            textTongTien.Text = TongGia.ToString();
        }

        void LoadcbTenSP()
        {

            string query = "SELECT distinct TenSP FROM SanPham";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cbTenSP.DataSource = data;
            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.SelectedIndexChanged += cbTenSP_SelectedIndexChanged;
        }
        void LoadcbColorSP()
        {
            string query = "SELECT distinct Mau FROM SanPham where TenSP ='" + cbTenSP.Text + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cbColor.DataSource = data;
            cbColor.DisplayMember = "Mau";
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcbColorSP();
            cbColor.SelectedIndex = -1;
            nmCountSP.Value = 0;
        }
        void LoadTenKH()
        {
            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cbTenKH.DataSource = data;
            cbTenKH.DisplayMember = "HoTen";

        }
        void loadMaSP()
        {
            string query = "SELECT MaSP FROM SanPham where TenSP ='" + cbTenSP.Text + "' and Mau ='"+cbColor.Text+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                string maSP = data.Rows[0]["MaSP"].ToString();
                textMaSP.Text = maSP;
            }
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            NewOrder.Enabled = true;
            buttonThemXe.Enabled = false;
            cbTenKH.Enabled = false;
            cbTenSP.Enabled = false;
            nmCountSP.Enabled = false;
            cbColor.Enabled = false;
            buttonHuy.Enabled = false;
            buttonDongY.Enabled = false;
            dgvSP.DataSource = null;
            textMaHD.Clear();
            textMaHD.Enabled = false;
            textTongTien.Clear();
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            string connectionString = DataProvider.Instance.connectionString;
            string query = "INSERT INTO HoaDon (MaHD,NgayGD,TongTien) VALUES (@MaHD,@NgayGD,@TongTien)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", textMaHD.Text);
                command.Parameters.AddWithValue("@NgayGD", dateTimePickerNgayGD.Value);
                command.Parameters.AddWithValue("@TongTien", long.Parse(textTongTien.Text));
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lưu hóa đơn thành công!");
                    capnhatvaoBangSPmuonmua();
                    // Thực hiện các công việc khác sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn thất bại!");
                }
                
            }

        }
        private void capnhatvaoBangSPmuonmua()
        {
            string connectionString = DataProvider.Instance.connectionString;
            string query = "INSERT INTO SanPhamDuocMua (id,MaHD,MaSP,ThanhTien,SoLuong) VALUES (@id,@MaHD,@MaSP,@ThanhTien,@SoLuong)";
            int lastid = idcuoibangsql();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    int id = lastid + 1;
                    string maHD = textMaHD.Text;
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    string thanhTien = row.Cells["TongGia"].Value.ToString();
                    string soLuong = row.Cells["Count"].Value.ToString();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@MaHD", maHD);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        private int idcuoibangsql()
        {
            string query = "SELECT * FROM SanPhamDuocMua ORDER BY id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            int id = Convert.ToInt32(data.Rows[0]["id"]);
            return id;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvSP.CurrentCell.RowIndex;
            listhoadon.RemoveAt(index);
            dgvSP.DataSource = null;
            dgvSP.DataSource = listhoadon;
            long TongGia = listhoadon.Sum(x => x.TongGia);
            textTongTien.Text = TongGia.ToString();
        }

        private void dgvSP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvSP.HitTest(e.X, e.Y);
                dgvSP.Rows[hti.RowIndex].Selected = true;

                contextMenuStrip1.Show(dgvSP, e.X, e.Y);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMaSP();
        }
    }

}
