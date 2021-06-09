using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace On_bai_mau
{
    class KhaiBaoDoiTuongCuThe
    {
        public void khaiBaoDoiTuongCuThe()
        {

        }

        // vào bài tập tạo thông tin cho đối tượng
        // bài 1: Khai báo  đối tượng cụ thể -- Dùng Contructor có tham số và không có tham số truyền vào
        public void bai1DungCOntructorCoVaKhongCoThamSoTruyenVao()
        {
            taoDoiTuong s1 = new taoDoiTuong("kieu", 22, 1998);
            // tạo đối tượng không có tham số truyền vào
            taoDoiTuong s2 = new taoDoiTuong();
            s2.ten = "Bau";
            s2.tuoi = 18;
            s2.namSinh = 1998;


            s1.inRaManHinh();
            s2.inRaManHinh();
        }

        //bài 2: khai báo đối tượng do Người dùng Nhập vào
        public void taoDoiTuongDoUserNhapVao()
        {
            Console.WriteLine("mời bạn nhập thông tin:");
            taoDoiTuong s3 = new taoDoiTuong();
            Console.Write(" mời bạn nhập tên:");
            s3.ten = Console.ReadLine();
            Console.Write(" mời bạn nhập tuổi: ");
            s3.tuoi=Int32.Parse(Console.ReadLine());
            Console.Write(" mời bạn Nhập năm Sinh: ");
            s3.namSinh=Int32.Parse(Console.ReadLine());

            Console.WriteLine("----------\n" +
                              "thông tin bạn vừa nhập: \n");
            s3.inRaManHinh();

        }
        // bài 3: khai báo  nhiều đối tượng do người dùng nhập vào-- array Đối Tượng

        public void taoNhieuDoiTuongDOUserNhapVao()
        {
            taoDoiTuong[] arrDoiTuongs ;// Khai báo mảng đối tượng
            int size; //khai báo số lượng phần tử trong Array
            Console.WriteLine(" mời bạn nhập số lượng sinh viên: ");
            size=Int32.Parse(Console.ReadLine());
            arrDoiTuongs= new taoDoiTuong[size]



        }
    }
}
