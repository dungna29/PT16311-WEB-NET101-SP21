﻿using System;
using System.Collections;
using System.Net.Http.Headers;

namespace Bai_2._7_ArrayList
{
    class Program
    {
        /*
         *  ArrayList
         *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections

            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */
        /*
           * A. CÁC PHƯƠNG THỨC TRONG ArrayList
           * 1. Add(object Value): Thêm đối tượng vào cuối.
           * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
           * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
           * 4. Clear(): Xóa tất cả các phần tử.
           * 5. Clone(): Tạo 1 bản sao của danh sách đó.
           * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
           * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
           * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
           */
           
        static void Main(string[] args)
        {
            //1. Khai báo 
            ArrayList arrLstTemp = new ArrayList();
            ArrayList arrLstTemp1;
            arrLstTemp1 = new ArrayList();

            //2. Thêm phần tử ArrayList
            // Sử dụng phương thức Add(value)
            arrLstTemp.Add(1);//Thêm kiểu số nguyên
            arrLstTemp.Add("FPT");//Thêm kiểu String
            arrLstTemp.Add(true);
            arrLstTemp.Add(8.9);

            arrLstTemp1.Add("FPT");
            arrLstTemp1.Add("BK");
            arrLstTemp1.Add("KTQD");
            arrLstTemp1.Add("POLY");
            //3. Lấy giá trị <tên mảng>[index]
            Console.WriteLine(arrLstTemp[0]);
            Console.WriteLine(arrLstTemp[1]);

            //Sử dụng vòng lặp để in nhiều phần tử
            //arrLstTemp.Count = Số lượng phần tử trong mảng
            for (int i = 0; i < arrLstTemp.Count; i++)
            {
                Console.WriteLine(arrLstTemp[i]);
            }

          
            arrLstTemp.Clear();//Danh sách temp sẽ bị xóa trắng
            Console.WriteLine(arrLstTemp.Count);

            Console.ReadKey();
        }
    }
}