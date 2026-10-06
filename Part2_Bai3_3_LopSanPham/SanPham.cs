using System;

namespace Part2_Bai3_3_LopSanPham
{
    public class SanPham
    {
        // Các trường (Fields) và Thuộc tính (Properties)
        public string Ma { get; set; }
        public string Ten { get; set; }
        public double Gia { get; set; }

        // Hàm tạo mặc định
        public SanPham()
        {
            Ma = "";
            Ten = "";
            Gia = 0;
        }

        // Hàm tạo 3 đối số
        public SanPham(string ma, string ten, double gia)
        {
            Ma = ma;
            Ten = ten;
            Gia = gia > 0 ? gia : 0;
        }

        // Phương thức tính thuế VAT (10% đơn giá)
        public double TinhThueVAT()
        {
            return Gia * 0.10;
        }

        // Phương thức tính tổng tiền (Giá + Thuế VAT)
        public double TongTien()
        {
            return Gia + TinhThueVAT();
        }

        // Phương thức nhập thông tin từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhập mã sản phẩm: ");
            Ma = (Console.ReadLine() ?? "").Trim();

            Console.Write("Nhập tên sản phẩm: ");
            Ten = (Console.ReadLine() ?? "").Trim();

            while (true)
            {
                Console.Write("Nhập đơn giá sản phẩm: ");
                if (double.TryParse(Console.ReadLine(), out double gia) && gia >= 0)
                {
                    Gia = gia;
                    break;
                }
                Console.WriteLine("Đơn giá không hợp lệ! Vui lòng nhập số thực >= 0.");
            }
        }

        // Phương thức xuất thông tin sản phẩm
        public void Xuat()
        {
            Console.WriteLine($"Mã SP: {Ma,-8} | Tên SP: {Ten,-22} | Giá: {Gia,12:N0} VNĐ | Thuế VAT (10%): {TinhThueVAT(),10:N0} VNĐ | Tổng: {TongTien(),12:N0} VNĐ");
        }
    }
}
