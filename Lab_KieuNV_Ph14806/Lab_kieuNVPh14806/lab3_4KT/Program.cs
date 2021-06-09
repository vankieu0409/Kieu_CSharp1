using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4KT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            
            int lenh;
            do
            {
                NhapThuocTinh pt = new NhapThuocTinh();
                Console.WriteLine("------ Danh Sách CT-----\n" +
                                  " 1. Nhập 1 Sv \n" +
                                  " 2. Nhạp DSSV dùng List\n" +
                                  " 3. Xuất DSSV ra màn hình\n" +
                                  " 4. thoát");
                Console.Write(" MỜi Bạn Chọn CT: ");
                lenh=Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        pt.Nhap1SV();
                        break;
                    case 2:
                        pt.NhapSVList();
                        break;
                    case 3:
                        pt.xuatRaManHinh();
                        break;
                    case 4:
                        Environment.Exit(4);break;
                    default:
                        Console.WriteLine(" CT bạn CHọn Không đúng\n" +
                                          " MỜi bạn Nhập lại: "); break;

                }

                Console.WriteLine("--\n");
            } while (true);
        }
    }
}
