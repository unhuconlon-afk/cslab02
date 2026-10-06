using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_Bai2_QuanLyMatHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("       BÀI TẬP 2 (PHẦN 2): QUẢN LÝ MẶT HÀNG (OOP CLASS)       ");
            Console.WriteLine("==============================================================");

            List<MatHang> danhSach = new List<MatHang>();

            // 1. Nhập danh sách mặt hàng
            Console.WriteLine("\n>>> 1. NHẬP DANH SÁCH MẶT HÀNG <<<");
            while (true)
            {
                Console.WriteLine($"\n--- Mặt hàng thứ {danhSach.Count + 1} ---");
                int ma;
                while (true)
                {
                    Console.Write("Nhập mã mặt hàng: ");
                    if (int.TryParse(Console.ReadLine(), out ma))
                        break;
                    Console.WriteLine("Mã không hợp lệ!");
                }

                Console.Write("Nhập tên mặt hàng: ");
                string ten = Console.ReadLine() ?? "";

                int sl;
                while (true)
                {
                    Console.Write("Nhập số lượng: ");
                    if (int.TryParse(Console.ReadLine(), out sl) && sl >= 0)
                        break;
                    Console.WriteLine("Số lượng không hợp lệ!");
                }

                double donGia;
                while (true)
                {
                    Console.Write("Nhập đơn giá: ");
                    if (double.TryParse(Console.ReadLine(), out donGia) && donGia >= 0)
                        break;
                    Console.WriteLine("Đơn giá không hợp lệ!");
                }

                MatHang mh = new MatHang(ma, ten, sl, donGia);
                ThemMatHang(danhSach, mh);

                Console.Write("\nTiếp tục nhập? (y/n, mặc định y): ");
                string? ans = Console.ReadLine()?.Trim().ToLower();
                if (ans == "n" || ans == "no") break;
            }

            // 2. Xuất danh sách
            Console.WriteLine("\n>>> 2. XUẤT DANH SÁCH MẶT HÀNG <<<");
            XuatDanhSach(danhSach);

            // 3. Tìm và xóa
            Console.WriteLine("\n>>> 3. TÌM KIẾM VÀ XÓA MẶT HÀNG <<<");
            Console.Write("Nhập mã mặt hàng cần tìm và xóa: ");
            if (int.TryParse(Console.ReadLine(), out int maTim))
            {
                if (TimMatHang(danhSach, maTim))
                {
                    Console.WriteLine($"\n=> Tìm thấy mã {maTim}. Đang xóa khỏi danh sách...");
                    XoaMatHang(danhSach, maTim);
                    Console.WriteLine("\n--- DANH SÁCH SAU KHI XÓA ---");
                    XuatDanhSach(danhSach);
                }
                else
                {
                    Console.WriteLine($"\n=> Không tìm thấy mặt hàng mang mã {maTim}.");
                }
            }

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        public static void ThemMatHang(List<MatHang> ds, MatHang mh)
        {
            ds.Add(mh);
            Console.WriteLine("=> Đã thêm mặt hàng thành công!");
        }

        public static bool TimMatHang(List<MatHang> ds, int maMH)
        {
            return ds.Exists(m => m.MaMH == maMH);
        }

        public static void XuatDanhSach(List<MatHang> ds)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("(Danh sách hiện đang rỗng)");
                return;
            }

            Console.WriteLine(new string('-', 85));
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {ds[i]}");
            }
            Console.WriteLine(new string('-', 85));
        }

        public static bool XoaMatHang(List<MatHang> ds, int maMH)
        {
            int index = ds.FindIndex(m => m.MaMH == maMH);
            if (index >= 0)
            {
                ds.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}
