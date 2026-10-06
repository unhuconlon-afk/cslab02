using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_Bai3_1_LopSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("       BÀI TẬP 3.1: XÂY DỰNG VÀ THỬ NGHIỆM LỚP SINH VIÊN      ");
            Console.WriteLine("==============================================================");

            // Khởi tạo danh sách sinh viên theo mẫu giáo trình
            List<SinhVien> dssv = new List<SinhVien>();

            dssv.Add(new SinhVien
            {
                MaSV = 1,
                HoTen = "Trần Văn Tèo",
                DienThoai = "0909789567",
                DiaChi = "123 Trương Định",
                NgaySinh = new DateTime(2000, 11, 28)
            });

            dssv.Add(new SinhVien
            {
                MaSV = 2,
                HoTen = "Trần Văn Quang",
                DienThoai = "0909567789",
                DiaChi = "123 Trương Công Định",
                NgaySinh = new DateTime(1999, 11, 28)
            });

            dssv.Add(new SinhVien(3, "Nguyễn Thị Mai", new DateTime(2002, 5, 15), "45 Lê Lợi, Q.1", "0912345678"));

            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN (List<SinhVien>) ---");
            foreach (SinhVien sv in dssv)
            {
                Console.WriteLine(sv);
            }

            Console.WriteLine("\n--- KIỂM TRA PROPERTY CHỈ ĐỌC (LayTuoi) ---");
            foreach (SinhVien sv in dssv)
            {
                Console.WriteLine($"Sinh viên: {sv.HoTen} -> Năm sinh: {sv.NgaySinh.Year} -> Tuổi hiện tại: {sv.LayTuoi}");
            }

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
