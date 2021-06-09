using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.GetEncoding("UTF-8");
            ThongTinSV pt = new ThongTinSV();
            int lenh;
            do
            {
                Console.WriteLine(" danh sách chương trình:\n" +
                                  "1. thêm 1 sinh viên bằng contructor 0 tham số \n" +
                                  "2. thêm nhiều sinh viên dunfng list\n" +
                                  "3. xuaant ra màn hình\n" +
                                  "4 thoát.");
                Console.Write(" mời bạn trọn chương trình: ");
                lenh=Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        pt.bai2TaodoiTuongDoNguoiDungNhapVao();break;
                    case 2:
                        pt.themSinhVienList();
                        break;
                    case 3:
                        pt.inramanhinh();
                        break;
                    case 4:
                        Environment.Exit(4);break;
                    default:
                        Console.WriteLine(" bạn chọ sai. mời chọ lại: " );break;

                }
            } while (true);
        }
    }
}
