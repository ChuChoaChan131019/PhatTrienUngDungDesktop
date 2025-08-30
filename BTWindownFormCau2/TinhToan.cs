using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownFormCau2
{
    internal class TinhToan
    {
        public static void Cong(int a, int b, ref int c)
        {
            c = a + b;
        }
        public static void Tru(int a, int b, ref int c)
        {
            c = a - b;
        }
        public static void Nhan(int a, int b, ref int c)
        {
            c = a * b;
        }
        public static void Chia(int a, int b, ref int c)
        {
            c = a / b;
        }
    }
}
