using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_OOP_LapTrinhHuongDoiTuong
{
    class SinhVien //Đặt tên đối tượng phải  viết hoa chữ cái đầu của từ
    {
        //Phần 1: Khai báo tất cả các thuộc tính (Thông tin) mà đối tượng này phải có
        //Lưu ý: Không được khai báo trên cùng 1 dòng
        private string name;
        private string msv;
        private string queQuan;
        private int namSinh;
        private string truongHoc = "FPTPOLY";

        //Phần 2: Contructor - Hàm tạo luôn được chạy vào đầu tiên khi khởi tạo đối tượng
        //Phần 2.1 Contructor không tham số = ctor + tab
        public SinhVien()
        {
            Console.WriteLine("Đây là text in ra từ contructor không tham số");
        }
        //Phần 2.2 Contructor có tham số 
        public SinhVien(string name, string msv, string queQuan, int namSinh)
        {
            this.name = name;
            this.msv = msv;
            this.queQuan = queQuan;
            this.namSinh = namSinh;
        }
        //Phần 3: Property khi private thuộc tính thì sử dụng Property để lấy và gán giá trị cho thuộc tính. (Getter và Setter)
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string TruongHoc
        {
            get => truongHoc;
            set => truongHoc = value;
        }


        //Phần 4: Các phương thức của đối tượng
        public void inThongTinSV()
        {
            Console.WriteLine("{0} | {1} | {2} | {3}", name, msv, queQuan, namSinh);
        }
    }
}
