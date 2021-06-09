using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_vonglap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            /*
             for(int i=0;i<=10;i++)
             {
                 a = 8 * i;
                 Console.WriteLine("8*"+i+" = "+a);
             }*/
            int i=0 ;
           /* while (i <= 10)
                {
                
                a =8* i;
                i++;

                Console.WriteLine("8*" + i + " = " + a);
            }*/
            do
            {
                
                a = 8 * i;
                i++;
                Console.WriteLine("8*" + i + " = " + a);

            } while (i<=10);
        }
    }
}
