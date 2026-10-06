using System;

namespace Part2_Bai2_QuanLyMatHang
{
    /// <summary>
    /// Lớp Mặt Hàng theo mô hình Hướng đối tượng OOP
    /// </summary>
    public class MatHang
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public MatHang()
        {
            TenMH = "";
        }

        public MatHang(int maMH, string tenMH, int soLuong, double donGia)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return $"Mã: {MaMH,-5} | Tên: {TenMH,-20} | SL: {SoLuong,4} | Đơn giá: {DonGia,10:N0} VNĐ | Thành tiền: {TinhThanhTien(),12:N0} VNĐ";
        }
    }
}
