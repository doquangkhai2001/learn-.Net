// internal class Program
// {
//     private static void Main(string[] args)
//     {
        
// }
// }


// //Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");








// Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// _  _*
// _  * *
// __*   *
// _*     *
//  *******

// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");
// #region Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n
// // Input
// Console.WriteLine("Mời bạn nhập số nguyên");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int count = 2; count <= number; count++) {
//     bool isprime = true;
//     for (int j = 2; j <= Math.Sqrt(count); j++) {
//         if (count % j == 0) {
//             isprime = false;
//             break;
//         }
//     }
//     if (isprime) {
//         Console.Write($"{count} ");
//     }
// }
// // Output
// #endregion

// #region Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng
// //input 
// Console.WriteLine("Mời bạn nhập chiều cao ");
// int height = Convert.ToInt32(Console.ReadLine());
// int vex = 0;
// //process
// // cho 1 vòng lặp for lấy giá trị i < chiều cao để xác định số lượng hàng tam giác

// for  ( int i = 0; i< height ; i++)
// { // lọc khoảng trắng giữa tam giác
//   for (int j = 0;j < height ;j++)
//   {
//     Console.WriteLine(" ");
//   }
//   for (int k = 0; k < 2 * i + 1; k++)
//             {
//                 //k = 0 vi tri dau hang , k == 2*i la vi tri cuoi hang ,toan bo hang cuoi la *
//                 if (k == 0 || k == 2 * i || i == height - 1)
//                 {
//                     Console.Write("*");
//                 }
//                 else
//                 {
//                     Console.Write(" ");
//                 }
//             }
//      Console.WriteLine();
// }




//output

// #region Name
// //input 
// //process
// //output
// #endregion


// Console.WriteLine("Mời bạn nhập chu vi");
// float Chuvi = Convert.ToSingle(Console.ReadLine());

// Console.WriteLine("Chiều rộng kém chiều dài là");
// float rongtrudai = Convert.ToSingle(Console.ReadLine());

// // Process
// float x = ((Chuvi / 2) + rongtrudai) / 2;
// float y = (Chuvi / 2) - x;
// float s = x * y;

// Console.WriteLine($"Chiều dài: {x}, Chiều rộng: {y}, Diện tích: {s}");

