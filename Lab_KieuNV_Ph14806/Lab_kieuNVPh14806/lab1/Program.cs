using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            void HCN()
            {
                Console.WriteLine(" ");
                //Bài 2(2 điểm)
                //Viết chương trình nhập từ bàn phím 2 cạnh của hình chữ nhật.Tính và xuất
                //chu vi, diện tích và cạnh nhỏ của hình chữ nhật.

                float a, b, chuVi, dienTich, canhMin;
                Console.Write("mời bạn nhập chiều dài: ");
                a = float.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhâp chiều rộng: ");
                b = float.Parse(Console.ReadLine());
                chuVi = (a + b) * 2;
                dienTich = (a * b);
                canhMin = Math.Min(a, b);
                Console.WriteLine("Chu vi hính chữ nhật là: " + chuVi);
                Console.WriteLine(" Diện tích Hinh chữ nhật là: " + dienTich);
                Console.WriteLine(" Cạnh nhỏ nhất là: " + canhMin);

            }

            void HLP()
            {
                Console.WriteLine(" ");
                //    Bài 3(2 điểm)
                //    Viết chương trình nhập từ bàn phím cạnh của một khối lập phương.Tính và xuất
                //        thể tích của khối chữ nhật.
                double e, theTich;
                Console.Write("mời bạn nhâp chiều dài của 1 cạnh:  ");
                e = double.Parse(Console.ReadLine());
                theTich = /* x*x*x*/ Math.Pow(e, 3);
                Console.WriteLine(" thể tích khối lập phương là: " + theTich);

            }

            void PTBac2()
            {
                Console.WriteLine(" ");
                //Bài 4(2 điểm)
                //Viết chương trình nhập các hệ số của phương trình bậc 2.Tính delta và xuất căn
                //delta ra màn hình*/

                double c, d, f, delta, x1, x2, x;
                Console.WriteLine(" Đấy là chương trình giải Phương trinh bậc 2 có dạng: \t ax^2 + bx + c = 0");
                Console.Write(" Mời bạn Nhâp hệ số a: ");
                c = double.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập hệ số b: ");
                d = double.Parse(Console.ReadLine());
                Console.Write(" Mời bạn Nhập hệ số c: ");
                f = double.Parse(Console.ReadLine());

                if (c == 0)
                {
                    Console.WriteLine(" phương trình có 1 nghiệm: x= " + (-f / d));
                }
                else
                {


                    delta = Math.Pow(d, 2) - (4 * c * f);
                    if (delta > 0)
                    {
                        x1 = (-d + Math.Sqrt((delta)) / (2 * c));
                        x2 = (-d - Math.Sqrt(delta)) / (2 * c);
                        Console.WriteLine("Phương trình có 2 nghiệm phân biệt: \n X1= " + x1 + "\n X2= " + x2);
                    }
                    else
                    {
                        if (delta == 0)
                        {
                            x = -d / (2 * c);
                            Console.WriteLine("Phương trình có 1 nghiệm X= " + x);
                        }
                        else
                        {
                            Console.WriteLine(" Phương Trình trên Vô nghiệm ");
                        }
                    }
                }

            }

            int lenh;
            do
            {
                Console.WriteLine(" Danh sách chương trình: \n" +
                                  " 1. tìm Chu vi, diện tích và độ dài nhỏ nhất trong các cạnh của Hình Chữ Nhật\n" +
                                  " 2. tìm thể tích của Hình lập phương \n" +
                                  " 3. Giải PT bậc 2 \n");
                Console.Write( " Mời bạn Chọn CHương trình: ");
                lenh = Int32.Parse(Console.ReadLine());

                switch (lenh)
                {
                    case 1:
                        HCN();
                        break;
                    case 2:
                        HLP();
                        break;
                    case 3:
                        PTBac2();
                        break;
                    default:
                        Console.WriteLine(" Chức năng chưa có.\n" +
                                          " Mời bạn chọn lại chương trình khác.\n \n");
                        break;
                }
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine(" ");

            } while (true);
        }
    }
}
