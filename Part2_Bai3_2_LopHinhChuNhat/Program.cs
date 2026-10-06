using System;
using System.Text;

namespace Part2_Bai3_2_LopHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("     BÀI TẬP 3.2: XÂY DỰNG VÀ THỬ NGHIỆM LỚP HÌNH CHỮ NHẬT    ");
            Console.WriteLine("==============================================================");

            // 1. Thử nghiệm với đối tượng khởi tạo mặc định
            Console.WriteLine("\n--- Đối tượng 1 (Constructor mặc định) ---");
            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.XuatThongTin();

            // 2. Thử nghiệm với đối tượng có tham số
            Console.WriteLine("\n--- Đối tượng 2 (Dài 12.5, Rộng 6.2) ---");
            HinhChuNhat hcn2 = new HinhChuNhat(12.5, 6.2);
            hcn2.XuatThongTin();

            // 3. Thử nghiệm với hình vuông (Dài = Rộng = 8.0)
            Console.WriteLine("\n--- Đối tượng 3 (Dài 8.0, Rộng 8.0 - Hình vuông) ---");
            HinhChuNhat hcn3 = new HinhChuNhat(8.0, 8.0);
            hcn3.XuatThongTin();

            // 4. Cho người dùng nhập thử từ bàn phím
            Console.WriteLine("\n--- Đối tượng 4 (Nhập từ bàn phím) ---");
            Console.Write("Nhập chiều dài: ");
            double.TryParse(Console.ReadLine(), out double d);
            Console.Write("Nhập chiều rộng: ");
            double.TryParse(Console.ReadLine(), out double r);

            HinhChuNhat hcnUser = new HinhChuNhat(d, r);
            Console.WriteLine("\n=> Kết quả tính toán cho hình vừa nhập:");
            hcnUser.XuatThongTin();

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
