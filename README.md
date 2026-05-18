# Phần mềm Quản Lý Nhà Sách

Đây là ứng dụng desktop quản lý toàn diện các hoạt động của một nhà sách, được phát triển bằng **C# Windows Forms** và hệ quản trị cơ sở dữ liệu **SQL Server**.

## 🛠 Công nghệ sử dụng
* **Ngôn ngữ:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Cơ sở dữ liệu:** Microsoft SQL Server
* **Báo cáo (Report):** Crystal Reports (tích hợp xuất file `.rpt`)

## ✨ Các chức năng chính
* **Hệ thống & Tài khoản:** * Đăng nhập, đổi mật khẩu.
  * Phân quyền cơ bản giữa Quản lý và Nhân viên.
* **Quản lý danh mục:**
  * **Sách:** Thêm, sửa, xóa, tìm kiếm và theo dõi số lượng tồn.
  * **Khách hàng:** Quản lý thông tin và theo dõi công nợ khách hàng.
  * **Nhân viên:** Quản lý hồ sơ nhân viên làm việc tại nhà sách.
* **Nghiệp vụ cốt lõi:**
  * **Bán hàng:** Lập hóa đơn bán sách, tra cứu chi tiết hóa đơn.
  * **Nhập kho:** Lập phiếu nhập sách từ nhà cung cấp, chi tiết phiếu nhập.
* **Báo cáo & Thống kê:**
  * Lập báo cáo tồn kho.
  * Lập báo cáo công nợ.
* **Cấu hình quy định:** Thay đổi các quy định, tham số hoạt động của nhà sách (tồn kho tối thiểu, nợ tối đa,...).

## 🚀 Hướng dẫn cài đặt và chạy thử nghiệm

1. **Tải mã nguồn:**
   * Clone repository này về máy hoặc tải file ZIP và giải nén.
   
2. **Khởi tạo Cơ sở dữ liệu:**
   * Mở **SQL Server Management Studio (SSMS)**.
   * Truy cập vào thư mục `Database NhaSach` trong project.
   * Chạy script `script_qunlyNhasach.sql` để tạo cấu trúc database.
   * Chạy tiếp file `data_quanlynhasach_.sql` để nạp dữ liệu mẫu (mock data).
   * *(Tùy chọn)* Nếu cần dữ liệu tỉnh/thành, chạy thêm file `dlhcvn.sql` trong thư mục `db DiaChi`.

3. **Cấu hình chuỗi kết nối (Connection String):**
   * Mở file `QuanLyNhaSach.sln` bằng **Visual Studio**.
   * Mở file `App.config` hoặc class `Connect_DB.cs` (trong thư mục `CSDL/`).
   * Sửa lại chuỗi kết nối `ConnectionString` sao cho khớp với tên Server và xác thực (Authentication) trên máy của bạn.

4. **Biên dịch và Chạy:**
   * Nhấn `Ctrl + Shift + B` để build project và khôi phục các package (nếu có).
   * Nhấn `F5` hoặc nút **Start** để khởi chạy ứng dụng.

## 📂 Cấu trúc thư mục chính
* **`CSDL/`**: Các class đảm nhiệm việc kết nối và tương tác trực tiếp với cơ sở dữ liệu.
* **`Model/`**: Chứa các đối tượng (Entities) như `Sach`, `HoaDon`, `KhachHang`,... ánh xạ với các bảng trong SQL.
* **`GiaoDien/`**: Chứa toàn bộ các Form xử lý giao diện người dùng (UI).
* **`Database NhaSach/`**: Lưu trữ các file script SQL để backup và cài đặt CSDL.
* **`Image/`**: Các tài nguyên hình ảnh, icon, hình nền dùng cho giao diện.
