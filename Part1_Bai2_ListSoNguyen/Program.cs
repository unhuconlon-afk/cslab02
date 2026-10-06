using System;
using System.Collections.Generic;
using System.Text;

namespace Part1_Bai2_ListSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("  BÀI TẬP 2: PHÁT SINH NGẪU NHIÊN DÃY SỐ VỚI List<int>        ");
            Console.WriteLine("==============================================================");

            int n = 0;
            while (true)
            {
                Console.Write("Nhập số lượng phần tử n (n > 0): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Số lượng phần tử không hợp lệ! Vui lòng nhập số nguyên dương lớn hơn 0.");
            }

            // Khởi tạo đối tượng List để chứa các số nguyên
            List<int> ml = new List<int>();
            Random rand = new Random();

            // Phát sinh ngẫu nhiên n số nguyên (giá trị từ 1 đến 100)
            Console.WriteLine($"\nĐang phát sinh ngẫu nhiên {n} số nguyên...");
            for (int i = 0; i < n; i++)
            {
                int giaTri = rand.Next(1, 101); // Phát sinh số trong khoảng [1, 100]
                ml.Add(giaTri);
            }

            // Xuất danh sách ban đầu
            Console.WriteLine("\n--- Danh sách vừa phát sinh ban đầu ---");
            XuatList(ml);
            Console.WriteLine($"Số lượng phần tử hiện tại (ml.Count): {ml.Count}");

            // Sắp xếp tăng dần
            ml.Sort();

            // Xuất danh sách sau khi sắp xếp
            Console.WriteLine("\n--- Danh sách sau khi sắp xếp tăng dần ---");
            XuatList(ml);

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        static void XuatList(List<int> list)
        {
            Console.WriteLine("[ " + string.Join(", ", list) + " ]");
        }
    }
}
