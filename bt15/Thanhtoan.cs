using Newtonsoft.Json;

interface IThanhtoan
{
    bool Thanhtoan(double soTien);
}

// Thanh toan bang tien mat
public class ThanhToantienmat : IThanhtoan
{
    public bool Thanhtoan(double soTien)
    {
        Console.WriteLine($"Thanh toán bằng tiền mặt {soTien:C} thành công.");
        return true;
    }
}

// Thanh toan bang the
public class Thanhtoanbangthe : IThanhtoan
{
    private const string Mapin = "9999";

    public bool Thanhtoan(double soTien)
    {
        Console.WriteLine($"Nhập mã PIN để xác nhận giao dịch: ");
        string PIN = Console.ReadLine();
        if (PIN == Mapin)
        {
            Console.WriteLine($"Thanh toán bằng thẻ {soTien:C} thành công.");
            return true;
        }
        else
        {
            Console.WriteLine($"Mã PIN không đúng. Giao dịch thất bại.");
            return false;
        }
    }
}



public class ThanhtoanOnline : IThanhtoan
{
    private const string OTP = "1234";

    public bool Thanhtoan(double soTien)
    {
        Console.WriteLine($"Nhập mã PIN để xác nhận giao dịch: ");
        string PIN = Console.ReadLine();
        if (PIN == OTP)
        {
            Console.WriteLine($"Thanh toán online {soTien:C} thành công.");
            return true;
        }
        else
        {
            Console.WriteLine($"Mã PIN không đúng. Giao dịch thất bại.");
            return false;
        }
    }
}
 
// Lich su giao dich
public class Lichsugiaodich
{
    private readonly string filePath = "Lichsigiaodich.json";
    public List<string> Giaodich { get; set; } = new List<string>();

    public Lichsugiaodich()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            Giaodich = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
        }
    }

    public void Themgiaodich(string giaodich)
    {
        Giaodich.Add(giaodich);
        File.WriteAllText(filePath, JsonConvert.SerializeObject(Giaodich));
    }

    public void Hienthilichsu()
    {
        Console.WriteLine("Lịch sử giao dịch:");
        if (Giaodich.Count == 0)
        {
            Console.WriteLine("Chưa có giao dịch nào.");
        }
        else
        {
            foreach (var giaodich in Giaodich)
            {
                Console.WriteLine($"{giaodich}");
            }
        }
    }
}
