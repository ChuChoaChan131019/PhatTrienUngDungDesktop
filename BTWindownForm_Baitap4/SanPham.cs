using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm_Baitap4
{
    internal class SanPham
    {
        public string MaSP {  get; set; }
        public string TenSP {  get; set; }
        public string LoaiSP { get; set; }
        public DateTime NgaySX { get; set; }
        public SanPham() { }
        public int NamHetHan(DateTime ngaySX)
        {
            int namhh=ngaySX.Year+3;
            return namhh;
        }
        public  string HienThi()
        {
            return string.Format($"Mã sản phẩm: {MaSP}\nTên sản phẩm: {TenSP}\nLoại sản phẩm:{LoaiSP}\nNgày sản xuất: {NgaySX}\nNgày hết hạn: {NamHetHan(NgaySX)}");
        }
    }
}
