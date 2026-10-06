using System;

namespace Part2_Bai3_2_LopHinhChuNhat
{
    public class HinhChuNhat
    {
        private double _chieuDai;
        private double _chieuRong;

        public double ChieuDai
        {
            get => _chieuDai;
            set => _chieuDai = value > 0 ? value : 0;
        }

        public double ChieuRong
        {
            get => _chieuRong;
            set => _chieuRong = value > 0 ? value : 0;
        }

        // Constructor không tham số
        public HinhChuNhat()
        {
            _chieuDai = 1;
            _chieuRong = 1;
        }

        // Constructor có tham số
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        // Tính chu vi: (Dài + Rộng) * 2
        public double TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        // Tính diện tích: Dài * Rộng
        public double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        // Kiểm tra có phải là hình vuông không
        public bool KiemTraHinhVuong()
        {
            return Math.Abs(ChieuDai - ChieuRong) < 0.000001;
        }

        // Phương thức xuất thông tin
        public void XuatThongTin()
        {
            Console.WriteLine($"Chiều dài: {ChieuDai,6:F2} | Chiều rộng: {ChieuRong,6:F2} | Chu vi: {TinhChuVi(),8:F2} | Diện tích: {TinhDienTich(),8:F2} | Là hình vuông: {(KiemTraHinhVuong() ? "CÓ" : "KHÔNG")}");
        }

        public override string ToString()
        {
            return $"[HCN] Dài: {ChieuDai:F2}, Rộng: {ChieuRong:F2}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}, Hình vuông: {(KiemTraHinhVuong() ? "Đúng" : "Sai")}";
        }
    }
}
