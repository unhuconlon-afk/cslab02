using System;
using System.Text;

namespace Part2_Bai3_3_LopSanPham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("        BÀI TẬP 3.3: XÂY DỰNG VÀ THỬ NGHIỆM LỚP SẢN PHẨM      ");
            Console.WriteLine("==============================================================");

            Console.WriteLine("\n--- TIẾN HÀNH NHẬP 2 SẢN PHẨM TỪ BÀN PHÍM ---");

            Console.WriteLine("\n[1] Nhập sản phẩm thứ nhất:");
            SanPham sp1 = new SanPham();
            sp1.Nhap();

            Console.WriteLine("\n[2] Nhập sản phẩm thứ hai:");
            SanPham sp2 = new SanPham();
            sp2.Nhap();

            Console.WriteLine("\n==============================================================");
            Console.WriteLine("               THÔNG TIN CÁC SẢN PHẨM ĐÃ NHẬP                 ");
            Console.WriteLine("==============================================================");
            Console.Write("[1] ");
            sp1.Xuat();
            Console.Write("[2] ");
            sp2.Xuat();
            Console.WriteLine("==============================================================");

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
