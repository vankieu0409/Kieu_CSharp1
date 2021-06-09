using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            NhapThuocTinh pt = new NhapThuocTinh();
            int lenh;
            do
            {
                Console.WriteLine(" ------- Danh Sách CT---------- \n" +
                                  " 1. Nhập 1 sinh viên\n" +
                                  " 2. Nhập DS SV dùng list\n" +
                                  " 3. Xuất thông tin ra màn hình\n" +
                                  " 4. Thoát Ct" +
                                  "\n");
                Console.Write(" mời nạn chon chương trình: ");
                lenh= Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        pt.Nhap1SV();
                        break;
                    case 2:
                        pt.NhapDTDungList();
                        break;
                    case 3:
                        pt.InDoiTuong();
                        break;
                    case 4:
                        Environment.Exit(4);
                        break;
                    default:
                        Console.WriteLine(" chức năng không có. Mời bạn Nhập lại: ");
                        break;
                        
                }
                Console.WriteLine("\n");
            } while (true);
        }
    }
}
