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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
           
          
            if (rdTach.Checked)
            {
                string hoTen = txtHoTen.Text;
                string ho = "";
                string ten = "";
                XuLy.TachChuoi(hoTen, ref ho, ref ten);
                lblKetQua.Text = $"Họ:{ho}, Tên: {ten}";
            }    
            else
            {
                int s1 = int.Parse(txtSo1.Text);
                int s2 = int.Parse(txtSo2.Text);
                bool kt;
                kt = XuLy.ThuTu(s1, s2);
                lblKetQua.Text = kt ? "Hai số liền kề " : "Hai số không liền kề";
            }    
        }
    }
}
