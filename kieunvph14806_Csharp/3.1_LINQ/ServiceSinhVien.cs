using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._1_LINQ_CoBan
{
    class ServiceSinhVien
    {
        private List<SinhVien> lsSinhViens = new List<SinhVien>();
        public ServiceSinhVien()
        {
            fakeData();
        }
        void fakeData()
        {
            SinhVien sv1 = new SinhVien("Tiến", "PH00555", 2000, 1);
            SinhVien sv2 = new SinhVien("Long", "PH00556", 2000, 2);
            SinhVien sv3 = new SinhVien("Hoàng", "PH00557", 2000, 3);
            SinhVien sv4 = new SinhVien("Anh", "PH00558", 2000, 4);
            SinhVien sv5 = new SinhVien("Dũng", "PH00559", 2000, 5);
            SinhVien sv6 = new SinhVien("Lương", "PH005510", 2000, 6);
            SinhVien sv7 = new SinhVien("Huyền", "PH005511", 2000, 7);
            lsSinhViens.Add(sv1);
            lsSinhViens.Add(sv2);
            lsSinhViens.Add(sv3);
            lsSinhViens.Add(sv4);
            lsSinhViens.Add(sv5);
            lsSinhViens.Add(sv6);
            lsSinhViens.Add(sv7);
        }

        public void timKiemSinhVien()
        {
            Console.WriteLine("Mời bạn nhập mã: ");
            string input = Console.ReadLine();
            //Cách 1 : Sử dụng vòng lặp
            foreach (var x in lsSinhViens)
            {
                if (x.Msv == input)
                {
                    x.inRaManHinh();
                }
            }
            //Cách 2: Sử dụng LINQ
            lsSinhViens.Where(c => c.Msv == input).FirstOrDefault().inRaManHinh();

        }

        public void xoaSinhVien()
        {
            foreach (var x in lsSinhViens)
            {
                x.inRaManHinh();
            }
            Console.WriteLine("Mời bạn nhập mã để xóa: ");
            string input = Console.ReadLine();
            //Cách 1 : Sử dụng vòng lặp xóa 
            // for (int i = 0; i < lsSinhViens.Count; i++)
            // {
            //     if (lsSinhViens[i].Msv == input)
            //     {
            //         lsSinhViens.RemoveAt(i);//Xóa theo index trong List
            //     }
            // }
            //Cách 2: Sử dụng Linq để tìm index của đối tượng
            lsSinhViens.RemoveAt(lsSinhViens.FindIndex(c => c.Msv == input));
            foreach (var x in lsSinhViens)
            {
                x.inRaManHinh();
            }
        }

        public void sortSV()
        {
            //Sử dụng LINQ Orderby để sắp xếp theo thuộc tính chỉ định
            foreach (var x in lsSinhViens.OrderBy(c => c.Msv))
            {
                x.inRaManHinh();
            }
        }
    }
}