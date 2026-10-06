# Windows Programming with C# - LAB 02

Kho lưu trữ bài tập thực hành môn **Lập trình trên môi trường Windows với C# (Windows Programming with C#)** - **LAB 02**:
- **Chủ đề 1**: Collection & Exception Handling (Xử lý ngoại lệ, Custom Exception, List<T>, Struct).
- **Chủ đề 2**: Mảng động & Lập trình Hướng đối tượng OOP (List<string>, Class, Constructor, Properties, Methods).

Giảng viên hướng dẫn: **ThS. Lương Trần Hy Hiến** - Khoa CNTT, ĐH Sư Phạm TP.HCM.

---

## Danh mục các bài tập trong Solution

### 📁 Phần 1: LAB 02 – COLLECTION, EXCEPTION
1. **`Part1_Bai1_BieuThucException`**:
   - Tính giá trị biểu thức: $H = \frac{\sqrt{3x + 2y}}{2x - y}$
   - Xử lý các ngoại lệ:
     - `DivideByZeroException`: khi mẫu số $2x - y = 0$.
     - `FormatException`: khi nhập sai định dạng số nguyên.
     - `NotNegativeException`: lớp ngoại lệ tùy biến tự xây dựng khi biểu thức dưới dấu căn bị âm ($3x + 2y < 0$).
2. **`Part1_Bai2_ListSoNguyen`**:
   - Phát sinh ngẫu nhiên dãy $n$ ($n > 0$) số nguyên bằng `Random.Next()`.
   - Lưu trữ và thao tác bằng `List<int>`.
   - Sắp xếp tăng dần bằng `Sort()` và xuất kết quả.
3. **`Part1_Bai3_QuanLyMatHang`**:
   - Cấu trúc `MatHang` (`MaMH`, `TenMH`, `SoLuong`, `DonGia`).
   - Hàm tạo (Constructor) và hàm tính thành tiền (`ThanhTien = SoLuong * DonGia`).
   - Các thao tác: Thêm mặt hàng, tìm kiếm theo mã (trả về bool), xuất danh sách, xóa mặt hàng theo mã.

---

### 📁 Phần 2: LAB DAY – MẢNG ĐỘNG & LỚP (OOP)
4. **`Part2_Bai1_MangDongHangHoa`**:
   - Thao tác trên mảng động `List<string>` hàng hóa.
   - Nhập liên tục cho đến khi người dùng nhập chuỗi `"STOP"`.
   - Theo dõi `Count`, `Capacity`.
   - Tìm kiếm phần tử (trả về bool và vị trí index), xóa phần tử tìm thấy, chèn phần tử vào vị trí index bất kỳ, sắp xếp danh sách và xóa toàn bộ (`Clear()`).
5. **`Part2_Bai2_QuanLyMatHang`**:
   - Quản lý danh sách mặt hàng thiết kế theo lớp đối tượng `class MatHang` (mô hình OOP).
6. **`Part2_Bai3_1_LopSinhVien`**:
   - Xây dựng lớp `SinhVien` gồm: `MaSV`, `HoTen`, `NgaySinh`, `DiaChi`, `DienThoai`.
   - Constructor có tham số và không tham số.
   - Các properties `get`, `set` và property chỉ đọc `LayTuoi`.
   - Quản lý danh sách sinh viên với `List<SinhVien>`.
7. **`Part2_Bai3_2_LopHinhChuNhat`**:
   - Xây dựng lớp `HinhChuNhat` gồm `ChieuDai`, `ChieuRong`.
   - Các phương thức: `TinhChuVi()`, `TinhDienTich()`, kiểm tra hình vuông `KiemTraHinhVuong()`, xuất thông tin.
8. **`Part2_Bai3_3_LopSanPham`**:
   - Xây dựng lớp `SanPham` gồm `Ma`, `Ten`, `Gia`.
   - Phương thức tính thuế VAT (10%), phương thức `Nhap()` và `Xuat()` thông tin.
   - Thử nghiệm nhập và xuất 2 sản phẩm.

---

### 🚀 Menu Khởi Chạy Nhanh (Launcher)
- **`Lab02_Launcher`**: Giao diện Console tương tác cho phép chọn và chạy ngay lập tức bất kỳ bài tập nào từ 1 đến 8.

---

## Hướng dẫn thực thi

### Chạy bằng Visual Studio
Mở file `cslab02.sln`, chuột phải vào project cần chạy (hoặc `Lab02_Launcher`) và chọn **Set as Startup Project**, sau đó bấm **F5** hoặc **Ctrl + F5**.

### Chạy bằng .NET CLI
```bash
# Khởi chạy menu tương tác tổng hợp:
dotnet run --project Lab02_Launcher/Lab02_Launcher.csproj

# Hoặc khởi chạy trực tiếp từng bài:
dotnet run --project Part1_Bai1_BieuThucException/Part1_Bai1_BieuThucException.csproj
dotnet run --project Part1_Bai2_ListSoNguyen/Part1_Bai2_ListSoNguyen.csproj
dotnet run --project Part1_Bai3_QuanLyMatHang/Part1_Bai3_QuanLyMatHang.csproj
dotnet run --project Part2_Bai1_MangDongHangHoa/Part2_Bai1_MangDongHangHoa.csproj
dotnet run --project Part2_Bai2_QuanLyMatHang/Part2_Bai2_QuanLyMatHang.csproj
dotnet run --project Part2_Bai3_1_LopSinhVien/Part2_Bai3_1_LopSinhVien.csproj
dotnet run --project Part2_Bai3_2_LopHinhChuNhat/Part2_Bai3_2_LopHinhChuNhat.csproj
dotnet run --project Part2_Bai3_3_LopSanPham/Part2_Bai3_3_LopSanPham.csproj
```
