using System;
using System.Collections.Generic;
using System.Text;

namespace Part1_Bai3_QuanLyMatHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("       BÀI TẬP 3: QUẢN LÝ DANH SÁCH MẶT HÀNG (C# STRUCT)      ");
            Console.WriteLine("==============================================================");

            List<MatHang> danhSach = new List<MatHang>();

            // 1. Nhập danh sách mặt hàng
            Console.WriteLine("\n>>> 1. NHẬP DANH SÁCH MẶT HÀNG <<<");
            while (true)
            {
                Console.WriteLine($"\n--- Nhập mặt hàng thứ {danhSach.Count + 1} ---");
                int ma;
                while (true)
                {
                    Console.Write("Nhập mã mặt hàng (số nguyên): ");
                    if (int.TryParse(Console.ReadLine(), out ma))
                        break;
                    Console.WriteLine("Mã mặt hàng không hợp lệ!");
                }

                Console.Write("Nhập tên mặt hàng: ");
                string ten = Console.ReadLine() ?? "";

                int sl;
                while (true)
                {
                    Console.Write("Nhập số lượng (số nguyên): ");
                    if (int.TryParse(Console.ReadLine(), out sl) && sl >= 0)
                        break;
                    Console.WriteLine("Số lượng không hợp lệ!");
                }

                double donGia;
                while (true)
                {
                    Console.Write("Nhập đơn giá (số thực): ");
                    if (double.TryParse(Console.ReadLine(), out donGia) && donGia >= 0)
                        break;
                    Console.WriteLine("Đơn giá không hợp lệ!");
                }

                MatHang mh = new MatHang(ma, ten, sl, donGia);
                ThemMatHang(danhSach, mh);

                Console.Write("\nBạn có muốn tiếp tục nhập mặt hàng khác? (y/n, mặc định y): ");
                string? tiepTuc = Console.ReadLine()?.Trim().ToLower();
                if (tiepTuc == "n" || tiepTuc == "no")
                {
                    break;
                }
            }

            // 2. Xuất danh sách mặt hàng
            Console.WriteLine("\n>>> 2. DANH SÁCH CÁC MẶT HÀNG ĐÃ NHẬP <<<");
            XuatDanhSach(danhSach);

            // 3. Tìm kiếm và xóa mặt hàng theo mã
            Console.WriteLine("\n>>> 3. TÌM KIẾM VÀ XÓA MẶT HÀNG <<<");
            Console.Write("Nhập mã mặt hàng cần tìm và xóa: ");
            if (int.TryParse(Console.ReadLine(), out int maTim))
            {
                bool timThay = TimMatHang(danhSach, maTim);
                if (timThay)
                {
                    Console.WriteLine($"\n=> Đã tìm thấy mặt hàng có mã {maTim}. Tiến hành xóa...");
                    XoaMatHang(danhSach, maTim);
                    Console.WriteLine("\n--- DANH SÁCH MẶT HÀNG SAU KHI XÓA ---");
                    XuatDanhSach(danhSach);
                }
                else
                {
                    Console.WriteLine($"\n=> Không tìm thấy mặt hàng nào có mã {maTim} trong danh sách!");
                }
            }
            else
            {
                Console.WriteLine("Mã mặt hàng nhập không hợp lệ.");
            }

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// Hàm thêm một mặt hàng vào danh sách
        /// </summary>
        public static void ThemMatHang(List<MatHang> ds, MatHang mh)
        {
            ds.Add(mh);
            Console.WriteLine("=> Đã thêm mặt hàng thành công!");
        }

        /// <summary>
        /// Hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về kiểu bool
        /// </summary>
        public static bool TimMatHang(List<MatHang> ds, int maMH)
        {
            foreach (var item in ds)
            {
                if (item.MaMH == maMH)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Hàm xuất danh sách các mặt hàng
        /// </summary>
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

        /// <summary>
        /// Hàm xóa mặt hàng dựa vào mã mặt hàng
        /// </summary>
        public static bool XoaMatHang(List<MatHang> ds, int maMH)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaMH == maMH)
                {
                    ds.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
