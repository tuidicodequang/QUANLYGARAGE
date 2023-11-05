using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYGARAGE
{
    public partial class FUpdateKhachHang : Form
    {
        public FUpdateKhachHang()
        {
            InitializeComponent();
        }

        public KhachHang khUpdate { get; set; }

        private void FUpdateKhachHang_Load(object sender, EventArgs e)
        {
            if (khUpdate != null)
            {
                textMAKH.Text = khUpdate.Makh.ToString();
                textHoTen.Text = khUpdate.Hoten.ToString();
                textPassword.Text = khUpdate.Matkhau.ToString();
                txtNgaySinh.Value = khUpdate.Ngaysinh;
                (TickNam.Checked, TichNu.Checked) = (khUpdate.Gioitinh == "Nam") ? (true, false) : (false, true);
                textUser.Text = khUpdate.Username.ToString();
                textSDT.Text = khUpdate.Sdt.ToString();
                txtDiaChiNV.Text = khUpdate.Diachi.ToString();

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin khách hàng này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                khUpdate.Makh = textMAKH.Text;
                khUpdate.Hoten = textHoTen.Text;
                khUpdate.Username = textUser.Text;
                khUpdate.Ngaysinh= txtNgaySinh.Value;
                khUpdate.Gioitinh= TickNam.Checked ? TickNam.Text : TichNu.Text;
                khUpdate.Ngaysinh = txtNgaySinh.Value;
                khUpdate.Matkhau = textPassword.Text;
                khUpdate.Diachi = txtDiaChiNV.Text;
                khUpdate.Sdt = textSDT.Text;
                this.Close();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
