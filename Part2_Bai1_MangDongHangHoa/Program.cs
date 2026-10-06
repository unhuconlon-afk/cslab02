using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_Bai1_MangDongHangHoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("  BÀI TẬP 1 (PHẦN 2): MẢNG ĐỘNG VỚI List<string> HÀNG HÓA     ");
            Console.WriteLine("==============================================================");

            List<string> mang = new List<string>();

            // 1. Nhập chuỗi đưa vào mảng cho tới khi gặp STOP
            Console.WriteLine("\n>>> 1. NHẬP HÀNG HÓA (Nhập 'STOP' để dừng) <<<");
            while (true)
            {
                Console.Write("Tên hàng hóa: ");
                string tmp = (Console.ReadLine() ?? "").Trim();
                if (tmp.ToUpper() == "STOP")
                {
                    break;
                }
                if (!string.IsNullOrEmpty(tmp))
                {
                    mang.Add(tmp);
                    Console.WriteLine($"  -> Đã thêm '{tmp}' | Count = {mang.Count}, Capacity = {mang.Capacity}");
                }
            }

            // 2. Xuất mảng ban đầu
            Console.WriteLine("\n>>> 2. XUẤT CÁC HÀNG HÓA RA MÀN HÌNH <<<");
            XuatMang(mang);

            // 3. Tìm kiếm và xóa hàng hóa
            Console.WriteLine("\n>>> 3. TÌM KIẾM VÀ XÓA HÀNG HÓA <<<");
            Console.Write("Nhập tên hàng hóa cần tìm: ");
            string tim = (Console.ReadLine() ?? "").Trim();

            if (mang.Contains(tim))
            {
                int viTri = mang.IndexOf(tim);
                Console.WriteLine($"\n=> TÌM THẤY '{tim}' tại vị trí index = {viTri}");
                Console.Write("Bạn có muốn xóa hàng hóa này không? (y/n, mặc định y): ");
                string? ans = Console.ReadLine()?.Trim().ToLower();
                if (ans != "n")
                {
                    mang.Remove(tim);
                    Console.WriteLine("=> Đã xóa thành công!");
                    Console.WriteLine("Danh sách sau khi xóa:");
                    XuatMang(mang);
                }
            }
            else
            {
                Console.WriteLine($"\n=> KHÔNG TÌM THẤY '{tim}' trong danh sách (Kết quả: false).");
            }

            // 4. Thêm 1 hàng hóa vào vị trí index bất kỳ
            Console.WriteLine("\n>>> 4. THÊM HÀNG HÓA VÀO VỊ TRÍ INDEX BẤT KỲ <<<");
            Console.Write("Nhập tên hàng hóa mới cần chèn: ");
            string hangMoi = (Console.ReadLine() ?? "").Trim();
            if (!string.IsNullOrEmpty(hangMoi))
            {
                Console.Write($"Nhập vị trí index muốn chèn (0 đến {mang.Count}): ");
                if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 0 && idx <= mang.Count)
                {
                    mang.Insert(idx, hangMoi);
                    Console.WriteLine($"=> Đã chèn '{hangMoi}' vào vị trí {idx} thành công!");
                    XuatMang(mang);
                }
                else
                {
                    Console.WriteLine("Vị trí index không hợp lệ!");
                }
            }

            // 5. Sắp xếp danh sách tăng dần
            Console.WriteLine("\n>>> 5. SẮP XẾP DANH SÁCH TĂNG DẦN <<<");
            mang.Sort();
            Console.WriteLine("Sau khi sắp xếp:");
            XuatMang(mang);

            // 6. Xóa toàn bộ
            Console.WriteLine("\n>>> 6. XÓA TOÀN BỘ DANH SÁCH (CLEAR) <<<");
            mang.Clear();
            Console.WriteLine($"Sau khi xóa toàn bộ, danh sách còn: {mang.Count} phần tử.");

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        static void XuatMang(List<string> ds)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("(Danh sách rỗng)");
                return;
            }
            Console.WriteLine("[ " + string.Join(", ", ds) + " ]");
        }
    }
}
