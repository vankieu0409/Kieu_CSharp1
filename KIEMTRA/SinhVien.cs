using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIEMTRA
{
    class SinhVien
    {
        private int maSV;
        private string ten;
        private int namSinh;

        public SinhVien()
        {

        }

        public SinhVien(int maSv, string ten, int namSinh)
        {
            maSV = maSv;
            this.ten = ten;
            this.namSinh = namSinh;
        }

        public int MaSv
        {
            get => maSV;
            set => maSV = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public virtual void InRaManHInh()
        {
            Console.WriteLine("Ma sv: {0} , Ten Sv: {1} , Nam Sinh: {2}", maSV, Ten, NamSinh);
        }
    }
}
