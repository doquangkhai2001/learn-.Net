internal class Program
{
    private static void Main(string[] args)
    {
        #region kiểm tra số nguyên tố
          Console.WriteLine("Mời bạn nhập số");   
          string? number = Console.ReadLine();
        int Number = Convert.ToInt32(number);
             bool isprime = mehop.checkedPrime(Number);
             if (isprime == true)
             {
                Console.WriteLine($"số {number} là số nguyên tố" );
             }
             else {
                 Console.WriteLine($"số {number} không là số nguyên tố" );
             }
        #endregion
    }
   
   
}