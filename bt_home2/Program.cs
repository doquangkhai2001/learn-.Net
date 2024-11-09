// // #region Tính Ngày Chẵn lẻ 
// // //input User nhập ngày 
// // Console.WriteLine("Mời bạn nhập vào ngày cần tính ");
// // string Date = Console.ReadLine();
// // int date = Convert.ToInt32(Date);
// // //convert string => int
// // //process
// // //lấy ngày của user nhập chia cho 7 và lẻ là dư ngày
// // //even là chẵn ,odd là lẻ 
// // int even = date / 7 ;
// // int odd  = date % 7 ;
// // //output
// // // in ra ngày chẵn là lẻ 
// // Console.WriteLine($"Đáp án là {even} tuần + {odd} ngày");
// // #endregion


// // #region Tính tổng giá trị đợn hàng sau khi áp dụng giảm giá
// // // //input 
// // // nhập vào giá trị đơn hàng là cost và % giảm giá ,percent là %
// // Console.WriteLine("Mời bạn nhập giá trị đơn hàng");
// // string Cost = Console.ReadLine();
// // //convert string => long
// // long cost = Convert.ToInt32(Cost);
// // Console.WriteLine("Mời bạn % giảm giá");
// // string Percent = Console.ReadLine();
// // //convert string => int
// // int percent = Convert.ToInt32(Percent);
// // //process
// // long total = cost - (cost * percent / 100);
// // //output
// // Console.WriteLine($"Tổng Đơn Hàng Của bạn là : {cost}");
// // Console.WriteLine($"Khuyến mãi {cost * percent / 100} ");
// // Console.WriteLine("-----------------------");
// // Console.WriteLine($"Tổng cộng còn lại là {total}");
// // #endregion


// // #region Chuyển đổi thời gian phút sang giờ và phút 
// //     //input 
// //     //User nhập thởi gian
// //     Consosle.WriteLine("Mời bạn nhập số phút ");
// //     string Number = Console.ReadLine();
// //     //convert string => int
// //     int number = Convert.ToInt32(Number);
// //     //Process 
// //     // Thời gian người dùng nhập /60 và lấy giờ và phút
// //      int hour = number / 60;
// //      int minute = number % 60;
// //     //Output
// //     // in ra giờ và phút
// //    Console.WriteLine($"Kết quả của bạn là {hour} giờ và {minute} phút");
// // #endregion


// // #region Tính Tổng số tiền sau khi đã cộng thêm thuế VAT
// //    //Input
// //    // User nhập VAT và Số tiền
// //    Console.WriteLine("Mời bạn nhập số tiền ");
// //    string Cost = Console.ReadLine();
// //    //convert string => long 
// //    long cost = Convert.ToInt32(Cost);
// //    Console.WriteLine("Mời bạn nhập VAT ");
// //    string VAT = Console.ReadLine();
// //    //convert string => long 
// //    int vat = Convert.ToInt32(VAT);
// //    //Process 
// //    // số tiền + (số tiền * VAT * 100 )
// //    long total = cost + (cost * vat / 100);
// //    //Output
// //    //in ra Tổng tiền cuối cùng 
// // Console.WriteLine($"Tổng Tiền Của bạn là : {cost}");
// // Console.WriteLine($"Tiền VAT {cost * vat / 100} ");
// // Console.WriteLine("-----------------------");
// // Console.WriteLine($"Tổng cộng còn lại là {total}");
// // #endregion

// // #region Chuyển đổi USD => VND
// // //input
// // //User nhập USD 
// // Console.WriteLine("Mời bạn nhập USD");
// // string USD = Console.ReadLine();
// // //convert string => USD 
// // decimal usd = Convert.ToDecimal(USD);
// // //Process
// // //lấy số usd của người dùng nhân cho 25.305 đ
// // decimal vnd = usd * 25.305m;
// // //output
// // Console.WriteLine($"Tỷ giá chuyển đổi là {usd} $ = {vnd} VND");
// // #endregion

// // #region Tính số dư sau khi rút tiền tài khoản 
// //     //input 
// //     //User nhập Số dư hiện tại và số tiền muốn rút
// //     Console.WriteLine("Số Dư Hiện tại của bạn là ");
// //     string AvailableBalance = Console.ReadLine();
// //     //convert string => long
// //     long availableBalance = Convert.ToInt64(AvailableBalance);
// //      Console.WriteLine("Số tiền bạn muốn rút là : ");
// //     string AmountWithdrawn = Console.ReadLine();
// //     // string => long
// //     long amountWithdrawn = Convert.ToInt64(AmountWithdrawn);
// //     if (availableBalance <= 0 || amountWithdrawn <= 0)
// //     {
// //         Console.WriteLine("Số dư của bạn không đủ để giao dịch");
// //     }
// //     else{
        
// //         //output
// //         // Số tiên còn lại
// //         long remainingBalance = availableBalance - amountWithdrawn;
// //           Console.WriteLine($"Số dư tồn đầu : {availableBalance}");
// //           Console.WriteLine($"số Tiền rút {amountWithdrawn} ");
// //           Console.WriteLine("-----------------------");
// //           Console.WriteLine($"Tổng cộng còn lại là {remainingBalance}");
// //     }
// // #endregion


// // #region Tính tỷ lệ phần trăm 
// // //input USer nhập tử số và mẫu số tính tỷ lệ %
// // Console.WriteLine("Mời bạn nhập tử số ");
// //    string Number1 = Console.ReadLine();
// //     //convert string => int 
// //    decimal number1 = Convert.ToInt32(Number1);
// //    Console.WriteLine("Mời bạn nhập mẫu số ");
// //    string Number2 = Console.ReadLine();
// //     //convert string => int 
// //    decimal number2 = Convert.ToInt32(Number2);
// //    //process lấy tử / mẫu *100
// //    if (number1 > number2 || number1 <=0 || number2 <=0)
// //    {
// //     Console.WriteLine($"Vui lòng kiểm tra lại giá trị nhập {number1} <= {number2} và {number1} > 0 và {number2} > 0");
// //    }
// //    else
// //    {
// //    decimal percent = (number1 / number2) *100;
// //    //output
// //    Console.WriteLine($"tỷ lệ % là {percent} %");
// //    }
// // #endregion


// // #region Chuyển Đổi từ km/m
// // //input User nhập vận tốc 
// // Console.WriteLine("Mời bạn vận tốc  ");
// //    string Vspeed = Console.ReadLine();
// //     //convert string => decimal 
// //    decimal vspeed = Convert.ToInt32(Vspeed);
// //     //process
// //     if (vspeed < 0)
// //     {
// //         Console.WriteLine("Vận tốc không thể âm hoặc = 0");
// //     }
// //     else{
// //        decimal numbervspeed = vspeed / 3.6m;
// //        //output
// //        //in ra vận tóc chuyển đổi
// //        Console.WriteLine($" Vận Tốc {vspeed} km/h=  {numbervspeed} m/s ");
// //     }
   
// // #endregion

// // #region Tính lương calo tiêu thụ 
//     Console.WriteLine("Mời bạn Số phút luyện tập  ");
//    string Minutes_of_practice = Console.ReadLine();
//     //convert string => int 
//    int minutes_of_practice = Convert.ToInt32(Minutes_of_practice);
//     Console.WriteLine("Mời bạn chọn hình thức luyện tập  ");
//     Console.WriteLine("Số 1 Bơi ");
//     Console.WriteLine("Số 2 Đạp xe ");
//     Console.WriteLine("Số 3 Chạy ");
//    string Numberactive = Console.ReadLine();
//     //convert string => int 
//    int numberactive = Convert.ToInt32(Numberactive);
//    //process giả định bợi tiêu hao 500 calo/1h ,đạp xê là 200 calo /1h ,chạy 250 calo/1h
//    switch (numberactive){
//     case 1:
//       int number_calo1 = 500*minutes_of_practice*60;
//       Console.WriteLine($"Bạn bơi tiêu thụ số calo là {number_calo1}");
//       break;
//     case 2:
//       int number_calo2 = 200*minutes_of_practice*60;
//       Console.WriteLine($"Bạn Đạp xe tiêu thụ số calo là {number_calo2}");
//       break ;
//     case 3:
//       int number_calo3 = 250*minutes_of_practice*60;
//       Console.WriteLine($"Bạn chạy tiêu thụ số calo là {number_calo3}");
//       break;
//     default:
//      Console.WriteLine("vui lòng chọn số 1,2,3");
//     break;
// }  
   
// #endregion

// #region if else satament
// Boolean flag = true;
//  console.WriteLine("mời bạn nhập vào số nguyên");
//   string? number =console.ReadLine();
//   try{
//     int test = convert.ToInt32(number);

//   }
// #endregion

// #region tính tổng 3 số nguyên 
// //input
// Console.WriteLine("Mời bạn nhập 3 chữ số ngẫu nhiên");
// string Number3 = Console.ReadLine();
// //couver string => int 
// int number3 = Convert.ToInt32(Number3);
// int sumnumber =0;
// //process
// if (number3 < 100 || number3 > 999)
// {
//   Console.WriteLine("Số không đủ 3 chữ số ");
// }
// else
// {
//     int tram = number3 / 100;
//     int chuc = (number3 / 10) % 10;
//     int donvi = number3 % 10;
//     sumnumber = tram + chuc + donvi;
    
// }
// //output
// Console.WriteLine($"Tổng của 3 số là {sumnumber}");

// #endregion