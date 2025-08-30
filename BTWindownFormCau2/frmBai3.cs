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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten= txtTen.Text;
            string kq = "";
            PhepTinh.NoiChuoi(ho, ten, ref kq);
            lblKetQua.Text = kq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n= int.Parse(txtSoN.Text);
            long kq = 0;
            kq = PhepTinh.GiaiThua(n);
            lblKetQua.Text=kq.ToString();
        }
    }
}
