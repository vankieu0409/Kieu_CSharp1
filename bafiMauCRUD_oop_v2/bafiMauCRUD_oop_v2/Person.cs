using System;

namespace bafiMauCRUD_oop_v2
{
    public class Person
    {
        private string ten;
        private string sdt;
        private string email;

        public Person()
        {
            
        }

        public Person(string ten, string sdt, string email)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public virtual void inRaMaHinh()
        {
            Console.WriteLine(" Tên: {0}\n" +
                              " SĐT: {1}\n" +
                              " Email: {2}",ten,sdt,email);
        }    
    }
}