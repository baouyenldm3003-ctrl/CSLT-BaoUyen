using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Sesson_09
{
    internal class Exercise_07
    {
        static int DoDai(string s)
        {
            int dem = 0;
            foreach (char c in s)
            {
                dem++;
            }
            return dem;
        }
        static void Bai1()
        {
            Console.WriteLine("Bài 1: Nhập chuỗi và in ra ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine("Chuỗi vừa nhập là: " + s);
        }

    
        static void Bai2()
        {
            Console.WriteLine("Bài 2: Độ dài chuỗi ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            int dem = DoDai(s);
            Console.WriteLine("Độ dài của chuỗi là: " + dem);
        }

        static void Bai3()
        {
            Console.WriteLine("Bài 3: Tách từng ký tự");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            int i = 0;
            foreach (char c in s)
            {
                Console.WriteLine($"Ký tự thứ {i}: '{c}'");
                i++;
            }
        }

        static void Bai4()
        {
            Console.WriteLine("Bài 4: In ngược chuỗi ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            Console.Write("Chuỗi đảo ngược: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }

     
        static void Bai5()
        {
            Console.WriteLine("Bài 5: Đếm số từ ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            int soTu = 0;
            bool dangTrongTu = false; 

            foreach (char c in s)
            {
                if (c != ' ' && c != '\t')
                {
                    if (!dangTrongTu)
                    {
                        soTu++;          
                        dangTrongTu = true;
                    }
                }
                else
                {
                    dangTrongTu = false;  
                }
            }
            Console.WriteLine("Số từ trong chuỗi: " + soTu);
        }

       
        static void Bai6()
        {
            Console.WriteLine("Bài 6: So sánh hai chuỗi");
            Console.Write("Nhập chuỗi thứ nhất: ");
            string s1 = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi thứ hai: ");
            string s2 = Console.ReadLine() ?? "";

            bool giongNhau = true;

            if (DoDai(s1) != DoDai(s2))
            {
                giongNhau = false; 
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        giongNhau = false;
                        break;
                    }
                }
            }

            if (giongNhau)
                Console.WriteLine("Hai chuỗi giống nhau.");
            else
                Console.WriteLine("Hai chuỗi khác nhau.");
        }

        static void Bai7()
        {
            Console.WriteLine("Bài 7: Đếm chữ cái, chữ số, ký tự đặc biệt ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            int chuCai = 0, chuSo = 0, dacBiet = 0;

            foreach (char c in s)
            {
                if (char.IsLetter(c))
                    chuCai++;
                else if (char.IsDigit(c))
                    chuSo++;
                else
                    dacBiet++; 
            }

            Console.WriteLine("Số chữ cái: " + chuCai);
            Console.WriteLine("Số chữ số: " + chuSo);
            Console.WriteLine("Số ký tự đặc biệt: " + dacBiet);
        }

        static void Bai8()
        {
            Console.WriteLine("Bài 8: Đếm nguyên âm, phụ âm ");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            int nguyenAm = 0, phuAm = 0;

            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    char thuong = char.ToLower(c); 
                    if (thuong == 'a' || thuong == 'e' || thuong == 'i' ||
                        thuong == 'o' || thuong == 'u')
                    {
                        nguyenAm++;
                    }
                    else
                    {
                        phuAm++;
                    }
                }
            }

            Console.WriteLine("Số nguyên âm: " + nguyenAm);
            Console.WriteLine("Số phụ âm: " + phuAm);
        }


        static void Bai9()
        {
            Console.WriteLine("Bài 9: Kiểm tra chuỗi con ");
            Console.Write("Nhập chuỗi chính: ");
            string s = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi con cần kiểm tra: ");
            string sub = Console.ReadLine() ?? "";

            if (s.Contains(sub))
                Console.WriteLine($"Chuỗi con \"{sub}\" CÓ trong chuỗi chính.");
            else
                Console.WriteLine($"Chuỗi con \"{sub}\" KHÔNG có trong chuỗi chính.");
        }

      
        static void Bai10()
        {
            Console.WriteLine("Bài 10: Vị trí chuỗi con ");
            Console.Write("Nhập chuỗi chính: ");
            string s = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi con cần tìm: ");
            string sub = Console.ReadLine() ?? "";

            int viTri = s.IndexOf(sub);
            if (viTri == -1)
            {
                Console.WriteLine("Không tìm thấy chuỗi con.");
            }
            else
            {
                Console.WriteLine("Vị trí xuất hiện đầu tiên (tính từ 0): " + viTri);
            }
        }

     
        static void Bai11()
        {
            Console.WriteLine("Bài 11: Kiểm tra ký tự ");
            Console.Write("Nhập một ký tự: ");
            string nhap = Console.ReadLine() ?? "";

            if (nhap == "")
            {
                Console.WriteLine("Bạn chưa nhập ký tự nào!");
                return;
            }

            char c = nhap[0]; 

            if (char.IsLetter(c))
            {
                Console.WriteLine($"'{c}' là chữ cái.");
                if (char.IsUpper(c))
                    Console.WriteLine("Đây là chữ HOA.");
                else
                    Console.WriteLine("Đây là chữ thường.");
            }
            else
            {
                Console.WriteLine($"'{c}' KHÔNG phải là chữ cái.");
            }
        }

      
        static void Bai12()
        {
            Console.WriteLine("Bài 12: Đếm số lần xuất hiện ");
            Console.Write("Nhập chuỗi chính: ");
            string s = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi con cần đếm: ");
            string sub = Console.ReadLine() ?? "";

            if (sub == "")
            {
                Console.WriteLine("Chuỗi con không được rỗng!");
                return;
            }

            int dem = 0;
            int viTri = s.IndexOf(sub);
            while (viTri != -1)
            {
                dem++;
              
                viTri = s.IndexOf(sub, viTri + sub.Length);
            }

            Console.WriteLine($"Chuỗi con \"{sub}\" xuất hiện {dem} lần.");
        }

       
        static void Bai13()
        {
            Console.WriteLine("Bài 13: Chèn chuỗi con ");
            Console.Write("Nhập chuỗi chính: ");
            string s = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi làm mốc (chèn vào trước nó): ");
            string moc = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi cần chèn: ");
            string chen = Console.ReadLine() ?? "";

            int viTri = s.IndexOf(moc);
            if (viTri == -1)
            {
                Console.WriteLine("Không tìm thấy chuỗi mốc nên không chèn được.");
            }
            else
            {
                string ketQua = s.Insert(viTri, chen);
                Console.WriteLine("Chuỗi sau khi chèn: " + ketQua);
            }
        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;


            int chon;
            do
            {
                Console.WriteLine("\nMENU BÀI TẬP STRINGS");
                Console.WriteLine("1.  Nhập chuỗi và in ra");
                Console.WriteLine("2.  Tìm độ dài chuỗi (không dùng Length)");
                Console.WriteLine("3.  Tách từng ký tự của chuỗi");
                Console.WriteLine("4.  In các ký tự theo thứ tự ngược");
                Console.WriteLine("5.  Đếm số từ trong chuỗi");
                Console.WriteLine("6.  So sánh hai chuỗi (không dùng hàm thư viện)");
                Console.WriteLine("7.  Đếm chữ cái, chữ số, ký tự đặc biệt");
                Console.WriteLine("8.  Đếm nguyên âm, phụ âm");
                Console.WriteLine("9.  Kiểm tra chuỗi con có trong chuỗi không");
                Console.WriteLine("10. Tìm vị trí chuỗi con trong chuỗi");
                Console.WriteLine("11. Kiểm tra ký tự có phải chữ cái, hoa hay thường");
                Console.WriteLine("12. Đếm số lần chuỗi con xuất hiện");
                Console.WriteLine("13. Chèn chuỗi con trước lần xuất hiện đầu tiên");
                Console.WriteLine("0.  Thoát");
                Console.Write("Chọn bài (0-13): ");


                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    chon = -1;
                }

                Console.WriteLine();
                switch (chon)
                {
                    case 1: Bai1(); break;
                    case 2: Bai2(); break;
                    case 3: Bai3(); break;
                    case 4: Bai4(); break;
                    case 5: Bai5(); break;
                    case 6: Bai6(); break;
                    case 7: Bai7(); break;
                    case 8: Bai8(); break;
                    case 9: Bai9(); break;
                    case 10: Bai10(); break;
                    case 11: Bai11(); break;
                    case 12: Bai12(); break;
                    case 13: Bai13(); break;
                    case 0: Console.WriteLine("Tạm biệt!"); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            } while (chon != 0);
        }
    }
}

