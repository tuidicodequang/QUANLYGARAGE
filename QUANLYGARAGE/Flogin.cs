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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void buttLogin_Click(object sender, EventArgs e)
        {
            //  string user = "admin1";
            //  string password = "123456";
            // if (user == txbUser.Text && password == txbPassWord.Text)
            //  {
            fTabManager f = new fTabManager();
            this.Hide();
            f.ShowDialog();
            // this.Show();
            //  }
            //  else
            //  {
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác vui lòng nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //  }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttLogin_MouseEnter(object sender, EventArgs e)
        {
            buttLogin.ForeColor = Color.Black;
        }

        private void buttLogin_MouseLeave(object sender, EventArgs e)
        {
            buttLogin.ForeColor = Color.White;
        }

        private void buttExit_MouseEnter(object sender, EventArgs e)
        {
            buttExit.ForeColor = Color.Black;
        }

        private void buttExit_MouseLeave(object sender, EventArgs e)
        {
            buttExit.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
    }
}
