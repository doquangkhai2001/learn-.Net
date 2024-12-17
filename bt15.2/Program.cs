
class Program
{
    static void Main(string[] args)
    {
        QuanLySanPham quanLySanPham = new QuanLySanPham();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 5) break;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chọn loại sản phẩm:");
                    Console.WriteLine("1. Điện tử");
                    Console.WriteLine("2. Thời trang");
                    Console.WriteLine("3. Thực phẩm");
                    Console.Write("Lựa chọn của bạn: ");
                    int loai = int.Parse(Console.ReadLine());

                    Console.Write("Nhập mã sản phẩm: ");
                    string maSanPham = Console.ReadLine();
                    Console.Write("Nhập tên sản phẩm: ");
                    string tenSanPham = Console.ReadLine();
                    Console.Write("Nhập giá gốc: ");
                    double giaGoc = double.Parse(Console.ReadLine());

                    switch (loai)
                    {
                        case 1:
                            Console.Write("Nhập thuế bảo hành: ");
                            double thueBaoHanh = double.Parse(Console.ReadLine());
                            var dienTu = new DienTu
                            {
                                MaSanPham = maSanPham,
                                TenSanPham = tenSanPham,
                                GiaGoc = giaGoc,
                                ThueBaoHanh = thueBaoHanh
                            };
                            quanLySanPham.ThemSanPham(dienTu);
                            break;

                        case 2:
                            Console.Write("Nhập giảm giá: ");
                            double giamGia = double.Parse(Console.ReadLine());
                            var thoiTrang = new ThoiTrang
                            {
                                MaSanPham = maSanPham,
                                TenSanPham = tenSanPham,
                                GiaGoc = giaGoc,
                                GiamGia = giamGia
                            };
                            quanLySanPham.ThemSanPham(thoiTrang);
                            break;

                        case 3:
                            Console.Write("Nhập phí vận chuyển: ");
                            double phiVanChuyen = double.Parse(Console.ReadLine());
                            var thucPham = new ThucPham
                            {
                                MaSanPham = maSanPham,
                                TenSanPham = tenSanPham,
                                GiaGoc = giaGoc,
                                PhiVanChuyen = phiVanChuyen
                            };
                            quanLySanPham.ThemSanPham(thucPham);
                            break;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                    break;

                case 2:
                    quanLySanPham.HienThiSanPham();
                    break;

                case 3:
                    quanLySanPham.TinhTongDoanhThu();
                    break;

                case 4:
                    Console.Write("Nhập mã sản phẩm cần xóa: ");
                    string maXoa = Console.ReadLine();
                    quanLySanPham.XoaSanPham(maXoa);
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        Console.WriteLine("Đã thoát chương trình.");
    }
}