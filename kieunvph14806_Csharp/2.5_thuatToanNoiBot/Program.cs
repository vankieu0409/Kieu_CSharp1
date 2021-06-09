using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_thuatToanNoiBot
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                int[] arrNumber = { 9, 8, 6, 0 };
                // for (int i = 0; i < arrNumber.Length; i++)
                // {
                //     for (int j = i + 1; j < arrNumber.Length; j++)
                //     {
                //         if (arrNumber[i] > arrNumber[j])
                //         {
                //             int temp = arrNumber[i];
                //             arrNumber[i] = arrNumber[j];
                //             arrNumber[j] = temp;
                //         }
                //     }
                // }
                for (int i = 0; i < arrNumber.Length - 1; i++)
                {
                    Console.WriteLine("Lần chay thứ: " + i);
                    foreach (var x in arrNumber)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine("");
                    for (int j = i + 1; j < arrNumber.Length; j++)
                    {
                        Console.Write("Điều kiện {0} > {1} \n", arrNumber[i], arrNumber[j]);
                        if (arrNumber[i] > arrNumber[j])
                        {
                            int temp = arrNumber[i];
                            arrNumber[i] = arrNumber[j];
                            arrNumber[j] = temp;
                            Console.Write("Hoán vị của:{0} & {1} \n", arrNumber[i], arrNumber[j]);
                            foreach (int x in arrNumber)
                            {
                                Console.Write(x + " ");
                            }
                            Console.WriteLine("");
                        }
                    }
                }

                foreach (var x in arrNumber)
                {
                    Console.Write(x + " ");
                }
            }
        
    }
}
