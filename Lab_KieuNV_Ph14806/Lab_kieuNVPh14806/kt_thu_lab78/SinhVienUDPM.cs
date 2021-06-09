using System;

namespace kt_thu_lab78
{
    public class SinhVienUDPM:SinhVien
    {
        private double java;
        private double cSharp;

        public SinhVienUDPM()
        {
            
        }

        public SinhVienUDPM(double java, double cSharp)
        {
            this.java = java;
            this.cSharp = cSharp;
        }

        public SinhVienUDPM(int msv, string ten, int namSinh, double java, double cSharp) : base(msv, ten, namSinh)
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

        public override void inThongTin()
        {
            Console.WriteLine(" 1. Mã SV: PH{0}\n" +
                              " 2. Tên: {1}\n" +
                              " 3. Năm Sinh : {2}\n" +
                              " 4. ĐIểm JAV: {3}\n" +
                              " 5. Điểm C#: ",  Msv,Ten,NamSinh,java,cSharp);
        }
    }
}