using System;

namespace KIEMTRA
{
    public class SinhVienUDPM:SinhVien
    {
        private double java;
        private double cSharp;

        public SinhVienUDPM()
        {
            
        }

        public SinhVienUDPM(int maSv, string ten, int namSinh, double java, double cSharp) : base(maSv, ten, namSinh)
        {
            this.java = java;
            this.cSharp = cSharp;
        }

        public double Java
        {
            get => java;
            set => java = value;
        }

        public double CSharp
        {
            get => cSharp;
            set => cSharp = value;
        }

        public override void InRaManHInh()
        {
            Console.WriteLine($"Ma sv: {0} , Ten Sv: {1} , Nam Sinh: {2}, Điểm java: {3} , Điểm C#: {4}", MaSv, Ten, NamSinh,java,cSharp);
        }

        
    }
}