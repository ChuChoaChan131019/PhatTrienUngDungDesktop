using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
            if (rdDo.Checked)
                pictureBox1.Image = Properties.Resources.xedo;
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
            if (rdXanh.Checked)
                pictureBox1.Image = Properties.Resources.xexanh;
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
            if (rdTrang.Checked)
                pictureBox1.Image = Properties.Resources.xetrang;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien= int.Parse(txtDonGia.Text)*int.Parse(txtSoLuong.Text);
            lblSoTien.Text=soTien.ToString() + " $";
        }
    }
}
