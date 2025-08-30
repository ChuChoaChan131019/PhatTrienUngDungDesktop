using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownFormCau2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int a=int.Parse(txtSo1.Text);
            int b=int.Parse(txtSo2.Text);
            int kq = 0;
            if (rdCong.Checked)
                TinhToan.Cong(a,b,ref kq);
            else if (rdTru.Checked)
                TinhToan.Tru(a, b, ref kq);
            else if (rdTru.Checked)
                TinhToan.Nhan(a, b, ref kq);
            else
                TinhToan.Chia(a, b, ref kq);
            lblKetQua.Text=kq.ToString();

        }
    }
}
