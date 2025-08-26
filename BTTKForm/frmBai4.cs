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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random r= new Random();
            int so;
            for(int i = 1; i <= 10; i++)
            {
                so =r.Next(1,100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCT= int.Parse(txtSo.Text);
            lblKetQua.Text = "Không tìm thấy";

            foreach (int i in listBox1.Items)
            {
                if (i == soCT)
                {
                    lblKetQua.Text = "Tìm thấy";
                }
            }
        }
    }
}
