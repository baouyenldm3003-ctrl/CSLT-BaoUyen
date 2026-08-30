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
            Console.Write("Nhập một số nguyên : ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " Là số chẵn .");
            }
            else
            {
                Console.WriteLine(n + " Là số lẽ .");
            }
        }


        static void Bai_3()
        {
            Console.WriteLine("\nBài 3 : Tìm số lớn nhất ");
            Console.Write("Nhập số thứ nhất : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba : ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Số một là số lớn nhất trong 3 số : " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Số hai là số lớn nhất trong 3 số: " + num2);
            }
            else
            {
                Console.WriteLine("Số ba là số lớn nhất trong 3 số: " + num3);
            }
        }

       
        static void Bai_4()
        {
            Console.WriteLine("\nBài 4 : Kiểm tra loại tam giác ");
            Console.Write("Nhập cạnh đầu tiên: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ hai: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ ba: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Đây là tam giác đều .");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Đây là tam giác cân .");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường  .");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh này không tạo thành tam giác.");
            }
        }

       
        static void Bai_5()
        {
            Console.WriteLine("\nBài 5 : Xác định góc phần tư ");
            Console.Write("Nhập tọa độ x : ");
            int xVal = int.Parse(Console.ReadLine());
            Console.Write("Nhập tọa độ y : ");
            int yVal = int.Parse(Console.ReadLine());

            if (xVal > 0 && yVal > 0)
            {
                Console.WriteLine("Tọa độ (" + xVal + "," + yVal + ") nằm ở góc phần tư thứ nhất .");
            }
            else if (xVal < 0 && yVal > 0)
            {
                Console.WriteLine("Toạ độ  (" + xVal + "," + yVal + ") nằm ở góc phần tư thứ hai .");
            }
            else if (xVal < 0 && yVal < 0)
            {
                Console.WriteLine("Tọa độ  (" + xVal + "," + yVal + ")nằm ở góc phần tư thứ ba .");
            }
            else if (xVal > 0 && yVal < 0)
            {
                Console.WriteLine("Tọa độ (" + xVal + "," + yVal + ") nằm ở góc phần tư thứ tư .");
            }
            else if (xVal == 0 && yVal == 0)
            {
                Console.WriteLine("Tọa độ  (" + xVal + "," + yVal + ") nằm trên góc tọa độ .");
            }
            else
            {
                Console.WriteLine("Tọa độ  (" + xVal + "," + yVal + ") nằm trên trục tọa độ .");
            }
        }

        public static void Main3(string[] args)
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