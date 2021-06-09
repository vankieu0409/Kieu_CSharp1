using System;

namespace bafiMauCRUD_oop_v2
{
    public class Students : Person
    {
        private string ma;
        private double diemC;

        public Students()
        {
            
        }
        public Students(string ma, double diemC)
        {
            this.ma = ma;
            this.diemC = diemC;
        }

        public Students(string ten, string sdt, string email, string ma, double diemC) : base(ten, sdt, email)
        {
            this.ma = ma;
            this.diemC = diemC;
        }

        public string Ma
        {
            get => ma;
            set => ma = value;
        }

        public double DiemC
        {
            get => diemC;
            set => diemC = value;
        }

        public override void inRaMaHinh()
        {
            Console.WriteLine(" Tên: {0}\n" +
                              " SĐT: {1}\n" +
                              " Email: {2}\n" +
                              " MSV: {3}\n" +
                              " Điểm C#:{4}", Ten, Sdt, Email,ma,diemC);
        }
    }
}