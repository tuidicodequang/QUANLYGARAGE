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
            this.Location = new Point(600, 200);
        }
    }
}
