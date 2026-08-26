using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Session_03
{
    internal class Excercise_03
    {


        static void Bai_1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập vào chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine());
            float csd_moi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới (kWh):");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ.");
            } while (true);
            float tieuThu = csd_moi - csd_cu;
            const decimal b1 = 1806m;
            const decimal b2 = 1866m;
            const decimal b3 = 2167m;
            const decimal b4 = 2729m;
            const decimal b5 = 3050m;
            decimal tienDien;
            if (tieuThu <= 50 && tieuThu > 0)
            {
                tienDien = (decimal)tieuThu * b1;
            }
            else if (tieuThu <= 100)
            {
                tienDien = 50 * b1 + (decimal)(tieuThu - 50) * b2;
            }
            else if (tieuThu <= 200)
            {
                tienDien = 50 * b1 + 50 * b2 + (decimal)(tieuThu - 100) * b3;
            }
            else if (tieuThu <= 300)
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + (decimal)(tieuThu - 200) * b4;
            }
            else
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + 100 * b4 + (decimal)(tieuThu - 300) * b5;
            }

            float vat = 0.08f;
            decimal tienVat = tienDien * (decimal)vat;
            Console.WriteLine($"Số kWh tiêu thụ:{tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:C} VNĐ");
            Console.WriteLine($"Tiền thuế VAT: {tienVat:C} VNĐ");
            Console.WriteLine($"Tổng tiền phải thanh toán: {(tienDien + tienVat):C} VNĐ");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();

            Console.ReadKey();


        }
    }
}

