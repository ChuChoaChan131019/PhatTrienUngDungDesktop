using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownForm_Baitap4
{
    internal class XuLy
    {
        public static void ChaoHoi(string hoTen, bool gioiTinh)
        {
            string ktgioiTinh = gioiTinh ? "ông" : "bà";
            MessageBox.Show($"Chào {ktgioiTinh} {hoTen}");
        }
        public static int USCLN(int m, int n)
        {
            if (n == 0)
                return m;
            else if(m==0)
                return n;
            while(n!=0)
            {
                int u = m % n;
                m = n;
                n=u;
            } 
            return m;
                
        }
    }
}
