using System;

namespace Part1_Bai3_QuanLyMatHang
{
    /// <summary>
    /// Cấu trúc lưu trữ thông tin Mặt hàng
    /// </summary>
    public struct MatHang
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        // Hàm tạo (Constructor)
        public MatHang(int maMH, string tenMH, int soLuong, double donGia)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        // Hàm tính thành tiền
        public double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return $"Mã: {MaMH,-6} | Tên: {TenMH,-20} | SL: {SoLuong,5} | Đơn giá: {DonGia,10:N0} VNĐ | Thành tiền: {TinhThanhTien(),12:N0} VNĐ";
        }
    }
}
