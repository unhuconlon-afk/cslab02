using System;

namespace Part2_Bai3_1_LopSinhVien
{
    public class SinhVien
    {
        // Các thành phần dữ liệu (Fields & Auto-Properties)
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        // Property chỉ đọc (read-only) tính tuổi của sinh viên
        public int LayTuoi
        {
            get
            {
                int tuoi = DateTime.Now.Year - NgaySinh.Year;
                if (DateTime.Now.DayOfYear < NgaySinh.DayOfYear)
                {
                    tuoi--;
                }
                return tuoi;
            }
        }

        // Constructor không tham số
        public SinhVien()
        {
            MaSV = 0;
            HoTen = "";
            NgaySinh = DateTime.Now;
            DiaChi = "";
            DienThoai = "";
        }

        // Constructor có tham số
        public SinhVien(int maSV, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public override string ToString()
        {
            return $"Mã SV: {MaSV,-4} | Họ tên: {HoTen,-20} | Tuổi: {LayTuoi,2} | Ngày sinh: {NgaySinh:dd/MM/yyyy} | ĐT: {DienThoai,-11} | Đ/C: {DiaChi}";
        }
    }
}
