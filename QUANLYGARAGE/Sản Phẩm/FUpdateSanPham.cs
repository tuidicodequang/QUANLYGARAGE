using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QUANLYGARAGE
{
    public partial class FUpdateSanPham : Form
    {
        public SanPham spUpdate { get; set; }
        public FUpdateSanPham()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin sản phẩm  này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                spUpdate.MaSP = textMASP.Text;
                spUpdate.Tensp = textTenSP.Text;
                spUpdate.Hang = textHang.Text;
                spUpdate.Mau = textMau.Text;
                spUpdate.Gia = long.Parse(textGia.Text.ToString());
                this.Close();
            }

        }

        private void FUpdateSanPham_Load(object sender, EventArgs e)
        {
            if(spUpdate != null)
            {
                textMASP.Text = spUpdate.MaSP.ToString();
                textTenSP.Text = spUpdate.Tensp.ToString();
                textHang.Text = spUpdate.Hang.ToString();
                textMau.Text = spUpdate.Mau.ToString();
                textGia.Text = spUpdate.Gia.ToString();


            }
        }
    }

}
