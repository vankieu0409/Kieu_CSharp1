using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assigment
{
    class Program
    {
        //Viết 1 chương trình quản lý danh bạ điện thoại FPOLY dựa theo các yêu cầu sau
        //    Cấu trúc Project bao gồm:
        //Main.Class(Bao gồm hàm main, menu)
        //Nguoi.Class(Lớp cha - Bao gồm các thuộc tính: Ho, Ten, TenDem, NamSinh, GioITinh - inRaManHinh())
        //DanhBa.Class(Lớp con - Kế thừa các thuộc tính của lớp cha Bao gồm các thuộc tính riêng của đối tượng như: Sdt1, Sdt2, Email, GhiChu, - Hàm ToString() và kế thừa hàm inRaManHinh() từ lớp cha)
        //ServiceDanhBa.Class(Bao gồm các chức năng của bài toán)
        //Các chức năng chương trình cần có:
        //THÊM - SỬA - XÓA NGƯỜI TRONG DANH BẠ
        //    THÊM 15 NGƯỜI TẠO SẴN VÀO TRONG DANH BẠ
        //    TÌM KIẾM NGƯỜI THEO TÊN HOẶC SỐ ĐIỆN THOẠI
        //LOAD TẤT TT CẢ NGƯỜI TRONG DANH BẠ - (Lưu ý: Khi hiển thị những người nào lớn tuổi hơn mình dựa theo năm sinh thì hiện thị là ANH - CHỊ - EM trước Tên)
        //TÌM KIẾM THEO SỐ ĐIỆN THOẠI GẦN ĐÚNG
        //TÌM KIẾM THEO TÊN GẦN ĐÚNG
        //SẮP XẾP DANH BẠ THEO NGƯỢC VÀ XUÔI DO NGƯỜI DÙNG CHỌN
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FunctionsDanhBa pt = new FunctionsDanhBa();//new FunctionsDanhBa() là contructor kiểm tra thì bấm Ctrl+ click vào vị trí
            string ct;
            Console.WriteLine("------ Chương trình thao tác với Danh bạ -------\n" +
                                  " 1. Thêm Liên hệ mới vào Danh bạ\n" +
                                  " 2. Sửa những Liên hệ\n" +
                                  " 3. Xóa Liên hệ không cần thiết\n" +
                                  " 4. Hiển thị danh Danh bạn\n" +
                                  " 5. Tìm kiếm bằng tên hoặc số điện thoại\n" +
                                  " 6. Tìm kiếm tên gần đúng\n" +
                                  " 7. Tìm kiếm Số điện thoại gần đúng\n" +
                                  " 8. Sắp xếp Danh bạ \n" +
                                  " 9. thoát\n");
            Console.Write(" Vui lòng chọn CT: ");
            do
            {

                ct = Console.ReadLine();
                if (checkSo(ct) == false)
                {
                    Console.Write(" cái bạn vừa nhập vào ô không phải số\n" +
                                  " mời Bạn nhập lại dưới dạng số để chọn lại Chương trình: ");
                }
            } while (!checkSo(ct));

            Console.WriteLine("\n");


            do
            {


                switch (ct)
                {
                    case "1": pt.ThemLienHe(); break;
                    case "2": pt.SuaSv(); break;
                    case "3": pt.XoaLienHe(); break;
                    case "4": pt.Inra(); break;
                    case "5": pt.TimKiemDb(); break;
                    case "6": pt.TimkiemgandungTen(); break;
                    case "7": pt.TimKiemDanDungSdt(); break;
                    case "8": pt.SapxepnguoichonDb(); break;
                    case "9":
                        Console.WriteLine(" bye bye ");
                        Environment.Exit(9); break;
                    default:
                        Console.WriteLine("CT Không có mời chọn lại"); break;
                }

                Console.WriteLine("------------------");

            } while (true);


        }

        public static bool checkSo(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
            //^đầu chuỗi

            //    \ d một chữ số

            //    +một hoặc nhiều lần xuất hiện trước đó

            //    \ D ký tự không phải chữ số

            //    + một hoặc nhiều lần xuất hiện

            //    $ cuối của chuỗi
        }
    }
}
