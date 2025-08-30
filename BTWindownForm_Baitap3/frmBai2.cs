using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownForm_Baitap3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int kq = 0;
            if(rdTinhTong.Checked)
                kq= TinhToan.TinhTong(n);
            else
                kq=TinhToan.GiaiThua(n);
            lblKetQua.Text=kq.ToString();
        }
    }
}
