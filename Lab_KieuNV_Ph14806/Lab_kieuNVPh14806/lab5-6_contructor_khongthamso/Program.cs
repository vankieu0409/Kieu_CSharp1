using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_6_contructor_khongthamso
{
    class Program
    {
        //Đề 1: Viết 1 chương trình các chức năng sau: (SwitchCase - While)

        //1.      Thêm 5 sinh viên bằng contructor không tham số(Tên,
        //    Mã, Điểm Java - double, Điểm Csharp - double) – (5 Điểm)

        //2.      Tìm kiếm sinh viên theo mã(3- Điểm) – Sử dụng List

        //3.      Sắp xếp tăng dần(1 - Điểm)

        //4.      Thoát

        //    Triển khai bài: Có lớp đối tượng riêng, lớp chức năng riêng,
        //    và main riêng. 1 Điểm còn lại các thành phần nhỏ trong bài.
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            ServiceSinhVien pt = new ServiceSinhVien();

            string lenh;
            do
            {
                Console.WriteLine("         Danh sách Ct\n" +
                                  " 1. Thêm 5 sinh viên nhập từ bàn phím\n" +
                                  " 2. tìm kiếm sinh viên theo mã\n" +
                                  " 3. Sắp xếp thứ tự, không in ra\n" +
                                  " 4. in ra\n" +
                                  " 5. thoát\n" +
                                  "_______________");
                Console.Write(" mời bạn nhập chọn CT: ");
                lenh = Console.ReadLine();
                switch (lenh)
                {
                    case "1": pt.Nhap_5_SV();break;
                    case "2": pt.timKiemMaSV();break;
                    case "3":pt.SapXepTangdantheoDiemCSharp();break;
                    case "4": pt.Xuat();break;
                    case "5": Console.WriteLine(" chào bạn!\n" +
                                                " Mình Té đây.");break;
                    default: Console.WriteLine(" Chức năng Không có mời nhập lại:");break;
                }
            } while ((lenh=="5")?false:true);
        }
    }
}
