using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_bai_mau
{
    class taoDoiTuong  //đặt tên đối tượng.
    {
        //Phần 1: khai báo thuoojc tính của đối tượng
        public string ten;//khai báo thưộc tính của đối tượng
        public int tuoi;
        public int namSinh;


        //Bước 2: Contructor- tạo hàm luôn được chạy vào đầu tiên khi tạo đối tượng
        // bước 2.1: Contructor không tham số
        public taoDoiTuong()
        {

        }
        // bước 2.2: Contructor có tham số
        public taoDoiTuong(string ten, int tuoi, int namSinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.namSinh = namSinh;
        }
        // bước 3: Property khi private thuộc tính thì sử dụng Property để lấy và gán giá trị cho thuộc tính. (Getter và Setter)

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }


        // Bước 4: các phương thức của đối tượng ( in ra màn hình)
        public void inRaManHinh()
        {
            Console.WriteLine("{0} | {1} | {2} ",ten,tuoi,namSinh);
        }
    }
}
