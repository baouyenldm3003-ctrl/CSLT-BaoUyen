using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Session_03
{
    internal class Exercise_01
    {using System;

namespace DoiNhietDo
    {
        class Program
        {
            static void Main2(string[] args)
            {
                
                Console.Write("Enter Celsius degree: ");
                int celsius = Convert.ToInt32(Console.ReadLine());
                int kelvin = celsius + 273;
                int fahrenheit = celsius * 18 / 10 + 32;
                Console.WriteLine($"kelvin= {kelvin}");
                Console.WriteLine($"fahrenheit= {fahrenheit}");
                Console.ReadKey();
            }
        }
    }
