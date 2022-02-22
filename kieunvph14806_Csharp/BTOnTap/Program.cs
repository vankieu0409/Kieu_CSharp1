using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTOnTap
{

    /*
 * Bài tập ôn tập tổng hợp:
 * Viết 1 chương trình có menu sử dụng switch case và vòng lặp:
 *         ------Chương trình 1-------
 *       1. In bảng cửu chương đơn
 *       2. In bảng cửu theo khoảng
 *       3. Kiểm tra học lực Sinh Viên Poly
 *       4. Nhập thông tin người yêu cũ
 *       5. Thoát.

 * Giải thích:
 *1. In bảng cửu chương đơn: Mời người dùng nhập vào tên 1 bảng cửu chương mà họ muốn sau đó in ra màn hình.

 *2. In bảng cửu theo khoảng: Mời người dùng nhập vào tên bảng cửu chương theo khoảng. Ví dụ: từ bảng nhân 5 đến nhân 8.

 

 *  4. Nhập thông tin nhiều người yêu cũ: Nhập các thông tin của NY Cũ thông tin sau: Tên, Năm Sinh, Giới tính, Chiều cao (Sử dụng mảng)
 * - Tên người yêu:
 * - Năm sinh:
 * - Tuổi người yêu:         
 * - Giới tính:            
 * - Chiều cao:          

THANG ĐIỂM LẤY ĐIỂM LAB:
- Làm đủ và đúng các mục đề bài đưa ra là: 8 điểm
- Clean Code + || - 1 ĐIỂM
- Áp dụng được kiến thức của đầu bài đưa ra + || - 1 Điểm
- Copy bài có sẵn hoặc copy code ở bài cũ vào mặc định 0 điểm.
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding=Encoding.UTF8;


            int lenh;
            do
            {
                Console.WriteLine(" Danh sách chương trình:\n" +
                                  "1. in bảng cửu chương đơn\n" +
                                  "2' in bảng cửu chương theo khoảng\n" +
                                  "3. kiểm tra học lực\n" +
                                  "4. nhập thông tin người yêu cũ\n" +
                                  "5. thoát");
                Console.WriteLine("");
                Console.Write(" mời bạn chọn chương trình: ");
                lenh = Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        BangCCDon(); break;
                    case 2:
                        BangCCKhoang(); break;
                    case 3:
                        kTHocLuc(); break;
                    case 4:
                        danhSachNYC();
                        break;
                    case 5:
                        Environment.Exit(5);
                        break;

                    default:
                        Console.WriteLine(" CHương trình bạn chọn chưa phát triển.\n" +
                                          " Mời bạn chọn lại: "); break;

                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");
            } while (true);
        }
        static void BangCCDon()
        {
            int a, tich;
            Console.Write(" mời bạn chọn bảng cửu chương của: ");
            a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                tich = a * i;
                Console.WriteLine("{0}*{1}={2}", a, i, tich);
            }
        }
        //bảng cửu chương Khoảng
        static void BangCCKhoang()
        {
            int a, tich, b;
            Console.Write(" mời bạn chọn khoảng bảng CC: \n" +
                              " từ: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("đến");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Các bảng cửu chương bạn cần là: " + a + " đến " + b);
            for (int i = a; i < b; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    tich = i * j;

                    Console.WriteLine("{0}*{1}={2}", i, j, tich);

                }
                Console.WriteLine(" bảng cửu chương của: " + i);
            }


        }
        /**3. Kiểm tra học lực Sinh Viên Poly: Cho sinh viên POLY nhập vào điểm tổng kết môn C# và thông báo xếp loại học lực:
 *  diem<=5 --> Yếu
 *  diem<=7 --> Khá 
 *  diem<=8 --> Tiên Tiến
 *  diem<=9 --> Giỏi
 *  diem<=10 --> Xuất sắc*/

        static void kTHocLuc()
        {
            float diem;
            Console.Write(" Mời bạn Nhập điểm: ");
            diem = float.Parse(Console.ReadLine());

            if (diem <= 5)
            {

                Console.WriteLine(" Em có học lực:  Yếu");
            }
            else if (diem <= 7 && diem > 5)
            {
                Console.WriteLine(" Em có học lực:   Khá");

            }
            else if (diem > 7 && diem <= 8)
            {
                Console.WriteLine(" em có học lực: Tiên tiến");

            }
            else if (diem > 8 && diem <= 9)
            {
                Console.WriteLine(" Em có học lực: Giỏi");
            }
            else if (diem > 9 && diem <= 10)
            {
                Console.WriteLine(" Ơ- mây- zing! Gút- Chóp Em\n" + " Em rất Xuất Sắc.");
            }

        }
        /*4.Nhập thông tin nhiều người yêu cũ: Nhập các thông tin của NY Cũ thông tin sau: Tên, Năm Sinh, Giới tính, Chiều cao(Sử dụng mảng)
*-Tên người yêu:
*-Năm sinh:
*-Tuổi người yêu:         
*-Giới tính:
*-Chiều cao:*/
        static void danhSachNYC()
        {
            int soNYC;
            Console.Write(" Mời nhập số Người Yêu Cũ: ");
            soNYC = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            string[] ten, gioiTinh, namSinh, tuoi, chieuCao;
            ten = new string[soNYC];
            gioiTinh = new string[soNYC];
            namSinh = new string[soNYC];
            tuoi = new string[soNYC];
            chieuCao = new string[soNYC];

            // nhạp thông tin NGười yêu cũ
            for (int i = 0; i < soNYC; i++)
            {
                Console.WriteLine(" Mời bạn Nhập thông tin của Người Yêu Cũ thứ " + (i + 1));
                Console.Write(" - Họ Tên: ");
                ten[i] = Console.ReadLine();
                Console.Write(" - Năm sinh: ");
                namSinh[i] = Console.ReadLine();
                Console.Write(" - Tuổi: ");
                tuoi[i] = Console.ReadLine();
                Console.Write(" - Giới TÍnh: ");
                gioiTinh[i] = Console.ReadLine();
                Console.Write(" - Chiều cao: ");
                chieuCao[i] = Console.ReadLine();
                Console.WriteLine(" \n" +
                                  "-----------------------------------" +
                                  "\n");
            }

            // in Danh Sách người yêu cũ
            Console.WriteLine(" Danh sach Người yêu Cũ của bạn: ");
            for (int i = 0; i < soNYC; i++)
            {
                Console.WriteLine(" Thông tin Người Yêu Cũ thứ: " + (i + 1));
                Console.WriteLine();
                Console.WriteLine(" - Họ Tên: {0} \n" +
                                  " - Năm Sinh: {1} \n" +
                                  " - Tuổi: {2} \n" +
                                  " - Giới tính: {3}\n" +
                                  " - Chiều cao: {4}\n", ten[i], namSinh[i], tuoi[i], gioiTinh[i], chieuCao[i]);
                Console.WriteLine("__________________ \n" +
                                  "\n");

            }

        }
    }

}
