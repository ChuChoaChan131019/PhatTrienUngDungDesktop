﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm_Baitap3
{
    internal class TinhToan
    {
        public static int TinhTong(int n)
        {
            int tong = 0;
            for(int i = 1; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
        public static int GiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i<=n;i++)
            {
                gt *= i;
            }    
            return gt;
        }
    }
}
