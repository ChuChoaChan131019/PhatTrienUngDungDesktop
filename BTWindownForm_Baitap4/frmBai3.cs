using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownForm_Baitap4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            bool gt = rdNam.Checked;
            XuLy.ChaoHoi(hoten, gt);
        }

        private void btnTimUCLN_Click(object sender, EventArgs e)
        {
            int m= int.Parse(txtM.Text);
            int n= int.Parse(txtN.Text);
            int u=XuLy.USCLN(m, n);
            lblKQ.Text = u.ToString();
        }
    }
}
