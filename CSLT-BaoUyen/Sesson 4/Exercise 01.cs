using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Sesson_4
{
    internal class Exercise_01
    {
       
        static void Bai_1()
        {
            Console.WriteLine("\nBài 1 : Giải phương trình bậc 2 ");
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm .");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm .");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình có một nghiệm x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm .");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt :");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }

       
        static void Bai_2()
        {
            Console.WriteLine("\nBài 2 : Kiểm tra số chẵn lẻ ");
            Console.Write("Input an integer: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is an even integer.");
            }
            else
            {
                Console.WriteLine(n + " is an odd integer.");
            }
        }


        static void Bai_3()
        {
            Console.WriteLine("\nBài 3 : Tìm số lớn nhất ");
            Console.Write("Input 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three: " + num2);
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three: " + num3);
            }
        }

       
        static void Bai_4()
        {
            Console.WriteLine("\nBài 4 : Kiểm tra loại tam giác ");
            Console.Write("Input side 1 of triangle: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Input side 2 of triangle: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Input side 3 of triangle: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("This is an equilateral triangle.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("This is an isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a scalene triangle.");
                }
            }
            else
            {
                Console.WriteLine("These side lengths do not form a valid triangle.");
            }
        }

       
        static void Bai_5()
        {
            Console.WriteLine("\nBài 5 : Xác định góc phần tư ");
            Console.Write("Input the value for X coordinate: ");
            int xVal = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            int yVal = int.Parse(Console.ReadLine());

            if (xVal > 0 && yVal > 0)
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies in the First quadrant.");
            }
            else if (xVal < 0 && yVal > 0)
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies in the Second quadrant.");
            }
            else if (xVal < 0 && yVal < 0)
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies in the Third quadrant.");
            }
            else if (xVal > 0 && yVal < 0)
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies in the Fourth quadrant.");
            }
            else if (xVal == 0 && yVal == 0)
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies at the origin.");
            }
            else
            {
                Console.WriteLine("The coordinate point (" + xVal + "," + yVal + ") lies on an axis.");
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();

            Console.ReadKey();
        }
    }
}