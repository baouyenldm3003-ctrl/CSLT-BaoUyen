using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Session02;
{
    internal class Exercises_01
    {
        public static void Main(string[] args)
        {

            int number1 = 10, number2 = 30;
        //1.to Add / Sum Two Numbers.
            int sum = number1 + number2;
        Console.WriteLine($"1.{number1}+{number2}={sum}");
        //2.to Swap Values of Two Variables.
            int temp = number1;
            number1 = number2;
            number2 = temp;
        Console.WriteLine($"After swap number1={number1}, number2={number2}");
        //3. to Multiply two Floating Point Numbers

        //4. to convert feet to meter

        //5. to convert Celsius to Fahrenheit and vice versa

        //6. to find the Size of data types

        //7. to Print ASCII Value (tip: read character, print number of this char)

        //8. to Calculate Area of Circle

        //9. to Calculate Area of Square

        //10. to convert days to years, weeks and days

        Console.ReadKey();

        }
    }
}

        