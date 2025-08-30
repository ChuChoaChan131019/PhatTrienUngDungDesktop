using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownFormCau2
{
    internal class PhepTinh
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s= ho +" "+ ten;
        }
        public static long GiaiThua( int n)
        {
            long gt = 1;
            for (int i =1 ; i <= n; i++)
            {
                gt *= i;    
            }
            return gt;
        }
    }
}
