using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_arrgy
{
   
    
        class Program
        {
            /*
            * Phần 1: Mảng 1 chiều
            *
            *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
            *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
            *
            *  2. Khai báo 1 mảng trong Csharp:
            *          - Cách 1:
            *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
            *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
            *          - Cách 2: 
            *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
            *
            *          - Cách 3:
            *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
            *
            *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
            *
            *  3. Truy xuất các phần tử trong mảng
            *      - Gán giá trị cho mảng:
            *           <tên mảng>[index] = Giá trị cần gán;
            *   
            *     - Lấy giá trị trong mảng:
            *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
            *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
            *
            *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
            *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
            */
            static void Main(string[] args)
            {
                //Phần 1: Khai báo
                int[] arrNumber1;//Khai báo 1 mảng
                arrNumber1 = new int[5];//Khởi tạo 1 mảng có kích thước là 5

                string[] arrNames = new string[5];
                int[] arryears1 = { 2001, 2002, 2003, 2004 };
                int[] arrYears2 = new int[] { 2001, 2002, 2003, 2004 };

                var arrNames2 = new int[5];
                var arrDiem = new double[5];

                //Phần 2: Gán gia trị
                //arrNumber1 = 5; KHông xác định được giá trị sẽ được gán vào index nào
                arrNumber1[0] = 5;//Gán giá trị cho index 0
                arrNumber1[1] = 8;
                arrNumber1[0] = 8;//Ghi đè

                //Phần 3:Lấy giá trị trong mảng
                Console.WriteLine(arrNumber1[0]);
                Console.WriteLine(arrNumber1[1]);
                Console.WriteLine(arrNumber1[2]);
                Console.WriteLine(arrNumber1[3]);
                Console.WriteLine(arrNumber1[4]);

                Console.WriteLine("Kich thuoc mang: " + arrNumber1.Length);
                for (int i = 0; i < arrNumber1.Length; i++)
                {
                    Console.Write(arrNumber1[i] + " ");
                }

                Console.WriteLine();
                foreach (var x in arrNumber1)
                {
                    Console.Write(x + " ");
                }

            }
        }
    }

