//Bài 1:
// IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
// Bài Toán: Tính tổng các số trong mảng
// Mô Tả: Bạn được cung cấp 1 mảng số nguyên IstNumber, nhiệm vụ của bạn là tính tổng các số ở trong mảng này
// Input: IstNumber: Một danh sách(Mảng) các số nguyên, đây là mảng bạn cần tính tổng
// Output: Trả về tổng của tất cả các số trong mảng IstNumber

// Bài 2:
// Ist_number = [2, 7, 11, 15]
// Mô Tả: Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
// Ví dụ:
// Input: Nums = [2, 7, 11, 15], target = 9
// Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9) ngược lại nếu không có
 class Program
{
    private static void Main(string[] args)
    {
       #region bai 1
          //input
         List<int> ISnumber= new List<int>(){20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        process myprocess = new process();
        int ketqua = myprocess.tinhtongcacso(ISnumber);
        //output 
        Console.WriteLine($"Tổng của tất cả các số trong mảng IstNumber là {ketqua}");
       #endregion
       #region bai 2 
       //input
       int target = 9;
       Console.WriteLine("Tìm tổng 1 số bằng taget");
        List<int> lst= new List<int>(){2, 7, 11, 15};
        if (process.timhaisonguyen(lst,target) == null){
                Console.WriteLine("không có số nào phù hợp");
        }else {
              List<int> index = process.timhaisonguyen(lst,target);
              Console.WriteLine($"Tổng 2 số nguyên bằng taget là {string.Join(',',index)}");
        }

       #endregion
       
}
}
