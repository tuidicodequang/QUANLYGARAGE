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
    public partial class FUpdateNhanVien : Form
    {
        public FUpdateNhanVien()
        {
            InitializeComponent();
        }

        public NhanVien nvUpdate { get; set; }
        private void FUpdateNhanVien_Load(object sender, EventArgs e)
        {
            if (nvUpdate != null)
            {
                textMANV.Text = nvUpdate.Manv.ToString();
                textHoTen.Text = nvUpdate.Hoten.ToString();
                textPassword.Text = nvUpdate.Matkhau.ToString();
                txtNgaySinh.Value = nvUpdate.Ngaysinh;
                textUser.Text = nvUpdate.Username.ToString();
                textSDT.Text = nvUpdate.Sdt.ToString();
                txtDiaChiNV.Text = nvUpdate.Diachi.ToString();

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin nhân viên này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                nvUpdate.Manv = textMANV.Text;
                nvUpdate.Hoten = textHoTen.Text;
                nvUpdate.Username = textUser.Text;
                nvUpdate.Ngaysinh = txtNgaySinh.Value;
                nvUpdate.Matkhau = textPassword.Text;
                nvUpdate.Diachi = txtDiaChiNV.Text;
                nvUpdate.Sdt = textSDT.Text;
                this.Close();
            }
            
        }
    }
}
