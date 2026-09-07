using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Session_05
{
    internal class Exercise_01
    {
        public static void Main(string[] argr)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"Bảng nhân {i}");
                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i}*{j}={i * j}");
                }
            }
        }


    }
}
