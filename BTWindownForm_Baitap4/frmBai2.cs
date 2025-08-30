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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double tb = (double.Parse(txtLyThuyet.Text) + double.Parse(txtThucHanh.Text)) / 2;
            if (double.Parse(txtLyThuyet.Text) < 5 || double.Parse(txtThucHanh.Text) < 5)
                lblKQXepLoai.Text = "Yếu";
            else if(tb<7)
                lblKQXepLoai.Text = "Trung bình";
            else if(7<=tb&& tb<8)
                lblKQXepLoai.Text = "Khá";
            else if (7 <= tb && tb < 8)
                lblKQXepLoai.Text = "Giỏi";
            else if(tb>=9)
                lblKQXepLoai.Text = "Xuất sắc";

        }
    }
}
