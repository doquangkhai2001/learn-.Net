class Program
{
    public static void Main(string[] args)
    {
        Lichsugiaodich lichSuGiaoDich = new Lichsugiaodich();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Thanh toán tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 5) break;

            double soTien = 0;
            if (choice >= 1 && choice <= 3)
            {
                Console.Write("Nhập số tiền cần thanh toán: ");
                soTien = double.Parse(Console.ReadLine());
            }

            bool thanhCong = false;
            string moTa = string.Empty;

            switch (choice)
            {
                case 1:
                    var thanhToanTienMat = new ThanhToantienmat();
                    thanhCong = thanhToanTienMat.Thanhtoan(soTien);
                    moTa = $"Thanh toán {soTien} bằng tiền mặt";
                    break;

                case 2:
                    var thanhToanBangThe = new Thanhtoanbangthe();
                    thanhCong = thanhToanBangThe.Thanhtoan(soTien);
                    moTa = $"Thanh toán {soTien} bằng thẻ";
                    break;

                case 3:
                    var thanhToanOnline = new ThanhtoanOnline();
                    thanhCong = thanhToanOnline.Thanhtoan(soTien);
                    moTa = $"Thanh toán {soTien} online";
                    break;

                case 4:
                    lichSuGiaoDich.Hienthilichsu();
                    continue;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    continue;
            }

            if (thanhCong)
            {
                Console.WriteLine("Giao dịch thành công.");
                lichSuGiaoDich.Themgiaodich(moTa);
            }
            else
            {
                Console.WriteLine("Giao dịch thất bại.");
            }
        }

        Console.WriteLine("Đã thoát chương trình.");
    }
}
