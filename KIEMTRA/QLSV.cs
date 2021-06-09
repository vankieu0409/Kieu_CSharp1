using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIEMTRA
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens;
        private List<SinhVienUDPM> _lstSinhVienUDPM;
        private SinhVienUDPM svUdpm1, svUdpm2, svUdpm3, svUdpm4, svUdpm5;
        private SinhVien _sinhVien;
        private string _input;
        private string a;

        public QLSV()
        {
            _lstSinhViens = new List<SinhVien>();
        

            _lstSinhVienUDPM = new List<SinhVienUDPM>();
            svUdpm1 = new SinhVienUDPM(1, "BÌnh", 2002, 1, 1);
            svUdpm2 = new SinhVienUDPM(1, "d", 1994, 1, 2);
            svUdpm3 = new SinhVienUDPM(1, "1", 1995, 1, 3);
            svUdpm4 = new SinhVienUDPM(1, "3", 1997, 1, 4);
            svUdpm5 = new SinhVienUDPM(1, "g", 1991, 1, 5);
            _lstSinhVienUDPM.Add(svUdpm1);
            _lstSinhVienUDPM.Add(svUdpm2);
            _lstSinhVienUDPM.Add(svUdpm3);
            _lstSinhVienUDPM.Add(svUdpm4);
            _lstSinhVienUDPM.Add(svUdpm5);
        }
        public void NhapDS()
        {
            do
            {
                Console.WriteLine("Moi Ban Nhap So Luong Sinh Vien ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    SinhVien sv = new SinhVien();
                    Console.WriteLine("Moi Ban Nhap Ma SV ");
                    sv.MaSv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Moi Ban Nhap Ten SV ");
                    sv.Ten = Console.ReadLine();
                    Console.WriteLine("Moi Ban Nhap Nam Sinh SV ");
                    sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                    _lstSinhViens.Add(sv);
                }
                Console.WriteLine("Ban Co Muon Nhap Tiep Hay Khong c or k ");
                a = Console.ReadLine();
            } while (!(a == "k"));

        }

        public void XuatTheoTuoi()
        {
            Console.WriteLine("Nhung Sinh Vien Co Tuoi Tren 21 La:");
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].NamSinh < 2000)
                {
                    _lstSinhViens[i].InRaManHInh();
                }
                else
                {
                    Console.WriteLine("Ma Sinh Vien Khong Ton Tai");
                }
            }
        }

        public void TimKiemTheoMa()
        {
            Console.WriteLine("Moi Ban Nhap Ma Sinh Vien Can Tim");
            _input = Console.ReadLine();
            int temp = GetINDex(_input);
            if (temp == -1)
            {
                Console.WriteLine("Ma Sinh Vien Khong Ton Tai");
            }

            foreach (var x in _lstSinhViens)
            {
                x.InRaManHInh();
            }
        }

        private int GetINDex(string msv)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].MaSv == Convert.ToInt32(msv))
                {
                    return i;
                }
            }

            return -1;
        }
        public void XuatDS()
        {
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHInh();
            }
        }

        public void KeThua()
        {
            foreach (var x in _lstSinhVienUDPM)
            {
                x.InRaManHInh();
            }
        }
    }
}
