using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Boolean;

namespace lab3_4_2_Contructor_CoThamSo
{
    class ThemDTKeToan
    {
        private List<ThuocTinhDT> _lstKeToans;
        private ThuocTinhDT keToan = new ThuocTinhDT();

        public ThemDTKeToan()
        {
            _lstKeToans = new List<ThuocTinhDT>();

        }

        public void nhap1KeToan()
        {
            Console.Write("mời bạn nhập Tên kế toán: ");
            keToan.Ten = Console.ReadLine();
            Console.Write("mời bạn nhập ID kế toán: ");
            keToan.Id = Int32.Parse(Console.ReadLine());
            Console.Write("mời bạn nhập lương : ");
            keToan.Luong = double.Parse(Console.ReadLine());
            Console.Write("mời bạn nhập Trạng thái: ");
            keToan.TrangThai = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n");

        }

        public void nhapListKeToans()
        {
            

            int sizeList;
            Console.Write(" mời bạn số lượng kế toán: ");
            sizeList= Int32.Parse(Console.ReadLine());
            for (int i = 0; i < sizeList; i++)
            {
                ThuocTinhDT keToan = new ThuocTinhDT();

                Console.Write("mời bạn nhập Tên kế toán: ");
                keToan.Ten = Console.ReadLine();
                Console.Write("mời bạn nhập ID kế toán: ");
                keToan.Id = Int32.Parse(Console.ReadLine());
                Console.Write("mời bạn nhập lương : ");
                keToan.Luong = double.Parse(Console.ReadLine());
                Console.Write("mời bạn nhập Trạng thái: ");
                keToan.TrangThai = bool.Parse(Console.ReadLine());

                _lstKeToans.Add(keToan);
                Console.WriteLine("\n");

            }
        }

        public void inDanhSach()
        {
            keToan.inRa();

            foreach (var kt in _lstKeToans)
            {
                kt.inRa();
            }
        }
    }
}
