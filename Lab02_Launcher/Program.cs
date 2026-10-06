using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lab02_Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                if (!Console.IsInputRedirected)
                    Console.Clear();

                Console.WriteLine("============================================================================");
                Console.WriteLine("     TRƯỜNG ĐH SƯ PHẠM TP.HCM - KHOA CÔNG NGHỆ THÔNG TIN                   ");
                Console.WriteLine("          MÔN HỌC: LẬP TRÌNH WINDOWS VỚI C# (WINDOWS PROGRAMMING)          ");
                Console.WriteLine("        BÁO CÁO LAB 02: COLLECTION, EXCEPTION & MẢNG ĐỘNG, LỚP (OOP)        ");
                Console.WriteLine("          Giảng viên hướng dẫn: ThS. Lương Trần Hy Hiến                     ");
                Console.WriteLine("============================================================================");
                Console.WriteLine("  [PHẦN 1: LAB 02 - COLLECTION, EXCEPTION]");
                Console.WriteLine("    1. Bài 1: Tính biểu thức toán học & Ngoại lệ (NotNegativeException, 0)");
                Console.WriteLine("    2. Bài 2: Phát sinh ngẫu nhiên và sắp xếp mảng động với List<int>");
                Console.WriteLine("    3. Bài 3: Quản lý danh sách mặt hàng (Struct MatHang, Thêm, Tìm, Xóa)");
                Console.WriteLine();
                Console.WriteLine("  [PHẦN 2: LAB DAY - MẢNG ĐỘNG & LỚP (OOP)]");
                Console.WriteLine("    4. Bài 1: Mảng động List<string> tên hàng hóa (STOP, Index, Sort)");
                Console.WriteLine("    5. Bài 2: Quản lý mặt hàng theo mô hình OOP (Class MatHang)");
                Console.WriteLine("    6. Bài 3.1: Lớp SinhVien (Constructors, Properties, LayTuoi)");
                Console.WriteLine("    7. Bài 3.2: Lớp HinhChuNhat (Chu vi, Diện tích, Kiểm tra Hình vuông)");
                Console.WriteLine("    8. Bài 3.3: Lớp SanPham (Nhập, Xuất, Thuế VAT 10%)");
                Console.WriteLine();
                Console.WriteLine("    0. Thoát chương trình");
                Console.WriteLine("============================================================================");
                Console.Write("Mời bạn chọn bài tập cần thực thi (0 - 8): ");

                string? choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice) || choice == "0")
                {
                    Console.WriteLine("\nCảm ơn thầy cô và các bạn đã sử dụng chương trình!");
                    break;
                }

                string folder = "";
                switch (choice)
                {
                    case "1": folder = "Part1_Bai1_BieuThucException"; break;
                    case "2": folder = "Part1_Bai2_ListSoNguyen"; break;
                    case "3": folder = "Part1_Bai3_QuanLyMatHang"; break;
                    case "4": folder = "Part2_Bai1_MangDongHangHoa"; break;
                    case "5": folder = "Part2_Bai2_QuanLyMatHang"; break;
                    case "6": folder = "Part2_Bai3_1_LopSinhVien"; break;
                    case "7": folder = "Part2_Bai3_2_LopHinhChuNhat"; break;
                    case "8": folder = "Part2_Bai3_3_LopSanPham"; break;
                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ!");
                        DungManHinh();
                        continue;
                }

                ChayDuAn(folder);
                DungManHinh();

                if (Console.IsInputRedirected) break;
            }
        }

        static void DungManHinh()
        {
            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để tiếp tục...");
                Console.ReadKey(true);
            }
        }

        static void ChayDuAn(string folderName)
        {
            Console.WriteLine($"\n>>> ĐANG KHỞI CHẠY {folderName}... <<<\n");

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string solutionDir = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", ".."));
            string projectPath = Path.Combine(solutionDir, folderName, $"{folderName}.csproj");

            if (!File.Exists(projectPath))
            {
                projectPath = Path.Combine(Directory.GetCurrentDirectory(), folderName, $"{folderName}.csproj");
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"run --project \"{projectPath}\"",
                UseShellExecute = false,
                CreateNoWindow = false
            };

            try
            {
                using (Process? process = Process.Start(psi))
                {
                    process?.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi chạy dự án: {ex.Message}");
            }
        }
    }
}
