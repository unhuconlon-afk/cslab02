using System;
using System.Text;

namespace Part1_Bai1_BieuThucException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("  BÀI TẬP 1: TÍNH BIỂU THỨC TOÁN HỌC & XỬ LÝ NGOẠI LỆ        ");
            Console.WriteLine("             H = sqrt(3x + 2y) / (2x - y)                     ");
            Console.WriteLine("==============================================================");

            try
            {
                Console.Write("Nhập số nguyên x: ");
                int x = int.Parse(Console.ReadLine() ?? "");

                Console.Write("Nhập số nguyên y: ");
                int y = int.Parse(Console.ReadLine() ?? "");

                double ketQua = TinhBieuThuc(x, y);
                Console.WriteLine($"\n=> Kết quả biểu thức H = {ketQua}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"\n[FormatException]: Dữ liệu nhập vào không đúng định dạng số nguyên! Chi tiết: {ex.Message}");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine($"\n[NotNegativeException]: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\n[DivideByZeroException]: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Lỗi không xác định]: {ex.Message}");
            }

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// Hàm tính giá trị H = sqrt(3x + 2y) / (2x - y) kèm kiểm tra và ném ngoại lệ
        /// </summary>
        public static double TinhBieuThuc(int x, int y)
        {
            long canThuc = 3L * x + 2L * y;
            if (canThuc < 0)
            {
                throw new NotNegativeException($"Biểu thức dưới dấu căn bị âm: 3({x}) + 2({y}) = {canThuc} < 0!");
            }

            long mauSo = 2L * x - y;
            if (mauSo == 0)
            {
                throw new DivideByZeroException($"Mẫu số bằng 0: 2({x}) - ({y}) = 0 (Không thể chia cho 0)!");
            }

            double tuSo = Math.Sqrt(canThuc);
            return tuSo / mauSo;
        }
    }
}
