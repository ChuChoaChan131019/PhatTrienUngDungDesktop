using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm_Baitap3
{
    internal class XuLy
    {
        public static void TachChuoi(string hoten,ref string s1, ref string s2)
        {
            int vt = hoten.LastIndexOf(' ');

            if (vt == -1)
            {
                s1 = "";
                s2 = hoten;
            }
            else
            {
                s1 = hoten.Substring(0, vt);      
                s2 = hoten.Substring(vt + 1);   
            }
        }
        public static bool ThuTu(int n1, int n2)
        {
            if (n1 == n2 + 1 || n2 == n1 + 1)
                return true;
            return false;
        }
    }
}
