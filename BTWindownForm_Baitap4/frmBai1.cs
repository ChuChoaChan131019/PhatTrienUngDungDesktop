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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = "SP009";
            sp.TenSP = "Mì hảo hảo";
            sp.LoaiSP = "Mì gói";
            sp.NgaySX = new DateTime(2024,09,09);
            lblThongbao.Text = sp.HienThi();

        }
    }
}
