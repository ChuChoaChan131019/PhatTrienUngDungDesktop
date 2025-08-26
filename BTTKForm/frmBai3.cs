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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>(); 
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tuMoi = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1.Items.Add(tuMoi);
            list.Add(nghia);
            //cải tiến thêm: con trỏ quay về ô nhập từ mới và xóa vb trong 2 ô
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghia.Text = "";
            // cải tiến thêm: từ mới đc nhập vào sẽ từ xuất hiện nghĩa
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtHienThiNghia.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtHienThiNghia.Text = list[stt];
        }
    }
}
