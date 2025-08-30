using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownFormCau2
{
    internal class ThietBi
    {
        public string MaTB {  get; set; }
        public string TenTB { get; set; }
        public string NuocSX { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi(string maTB, string tenTB, string nuocSX, double donGia, int soLuong)
        {
            MaTB = maTB;
            TenTB = tenTB;
            NuocSX = nuocSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public double ThanhTien(double donGia, int soLuong)
        {
            double thanhTien = donGia * soLuong;
            return thanhTien;
        }
        public string HienThi()
        {
            return $"Mã Thiết bị: {MaTB}\nTên thiết bị: {TenTB}\nĐơn giá: {DonGia}\nNước sản xuất: {NuocSX}\nSố lượng: {SoLuong}\nThành tiền: {ThanhTien(DonGia,SoLuong)}";

        }
    }
}
