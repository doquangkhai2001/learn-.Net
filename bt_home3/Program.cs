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

// #region Nhập Tháng ngày tìm ra thứ mấy
// //input
// // tạo thông báo nhập
// Console.WriteLine("Mời Nhập ngày");
// string q= Console.ReadLine();
// Console.WriteLine("Mời Nhập Tháng ");
// string m= Console.ReadLine();
// Console.WriteLine("Mời Nhập Năm ");1
// string yyyy= Console.ReadLine();
// // tạo phần nhập

// //couvert string => int
// int Q = Convert.ToInt32(q);
// int M = Convert.ToInt32(m);
// int Y = Convert.ToInt32(yyyy);
// int k = Y % 100 ;//năm 2 số cuối
// int j =Y / 100;//thế kỷ 
// //process 

// int h = (Q + (13 * (M + 1)) / 5 + k + (k / 4) + (j / 4) - 2 * j) % 7;
// Console.WriteLine($"{h}");
//      switch (h)
//         {
//             case 0: Console.WriteLine($"Thứ 7");  break;
//             case 1: Console.WriteLine($"Chủ Nhật");  break;
//             case 2: Console.WriteLine($"Thứ 2");  break;
//             case 3: Console.WriteLine($"Thứ 3");  break;
//             case 4: Console.WriteLine($"Thứ 4"); break;
//             case 5: Console.WriteLine($"Thứ 5"); break;
//             case 6: Console.WriteLine($"Thứ 6");  break;
//         }
//         Console.WriteLine($"Hôm này là thứ {h}");
// #endregion

// #region test try catch nhập đúng thì thôi khong thì chạy tiếp
//     Boolean flag = true;
//     while(flag)
//     {
//         Console.WriteLine("Mời bạn nhập số nguyên");
//         string?  number = Console.ReadLine();
//         try
//         {
//             int test = Convert.ToInt32(number);
//             // flag = true;
//              flag = false;
//         }
//         catch{
//             // flag = false;
//              flag = true;
//         }
//     }

// #endregion

#region if else statement
    //input 
    Console.WriteLine("Mời bạn nhập vào số  ");
    string? number = Console.ReadLine();
    int formatnumber = Convert.ToInt32(number);
    if (formatnumber %2 == 0){
           Console.WriteLine($"Số {number}là số chẵn ");
    }
    else{
        Console.WriteLine($"Số {number} là số lẻ ");
    }
    

    //process
    //output




#endregion