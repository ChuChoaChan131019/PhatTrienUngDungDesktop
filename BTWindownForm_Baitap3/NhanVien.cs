using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownForm_Baitap3
{
    internal class NhanVien
    {
        public string MaNV {  get; set; }
        public string Hoten { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HSPhuCap { get; set; }
        public NhanVien(string maNV, string hoten,DateTime ngaySinh, double heSoLuong, double hSPhuCap)
        {
            MaNV = maNV;
            Hoten = hoten;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HSPhuCap = hSPhuCap;
        }
        public double TongLuong(double hsLuong, double hsPhucap)
        {
            double tongLuong = (hsLuong + hsPhucap) * 1150000;
            return tongLuong;
        }
        public string HienThi()
        {
            return $"Mã Nhân viên: {MaNV}\nHọ Tên: {Hoten}\nNgày sinh: {NgaySinh}\nHệ số lương: {HeSoLuong}\nHệ số phụ cấp: {HSPhuCap}\nTổng lương: {TongLuong(HeSoLuong,HSPhuCap)}";
        }
    }
}
