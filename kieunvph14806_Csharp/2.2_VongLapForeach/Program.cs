using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_3_Foreach
{
    class Program
    {/*
         * Vòng lặp foreach
         * Cách gõ: fore + tab
         *
         * Công thức:
         *  foreach (var VARIABLE in COLLECTION)
            {
                
            }
            var: Kiểu dữ liệu đã học ở bài khai báo biến
            VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
            COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
         */
        static void Main(string[] args)
        {
            //fore + tab
            string[] arrName = { "A", "B", "C", "D" };
            for (int i = 0; i < arrName.Length; i++)
            {
                Console.Write(arrName[i]);
            }

            Console.WriteLine();
            foreach (string x in arrName)
            {
                Console.Write(x);
            }
        }
    }
}