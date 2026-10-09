using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Sesson_09
{
    internal class Exercise_08
    {
        static string NhapDuongDan(string loiNhac)
        {
            Console.Write(loiNhac);
            string s = Console.ReadLine() ?? "";
            return s.Trim().Trim('"');
        }

       
        static int NhapSoNguyen(string loiNhac)
        {
            int so;
            Console.Write(loiNhac);
            while (!int.TryParse(Console.ReadLine(), out so) || so <= 0)
            {
                Console.Write("Giá trị không hợp lệ, nhập lại (số nguyên dương): ");
            }
            return so;
        }

        static void TaoFileNhieuDong(string path)
        {
            int n = NhapSoNguyen("Nhập số dòng muốn ghi vào file: ");
            string[] cacDong = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dòng {i + 1}: ");
                cacDong[i] = Console.ReadLine() ?? "";
            }
            File.WriteAllLines(path, cacDong);
        }

        static void InCauTruc(string thuMuc, string thut)
        {
           
            foreach (string thuMucCon in Directory.GetDirectories(thuMuc))
            {
                Console.WriteLine(thut + "[+] " + Path.GetFileName(thuMucCon));
                try
                {
                    InCauTruc(thuMucCon, thut + "    ");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine(thut + "    (Không có quyền truy cập)");
                }
            }

        
            foreach (string file in Directory.GetFiles(thuMuc))
            {
                Console.WriteLine(thut + "- " + Path.GetFileName(file));
            }
        }

    
        static void Bai1()
        {
            Console.WriteLine("Bài 1: Tạo file trống");
            string path = NhapDuongDan("Nhập đường dẫn file cần tạo (vd: D:\\test.txt): ");

            if (File.Exists(path))
            {
   
                Console.WriteLine("File đã tồn tại, không tạo lại để tránh mất dữ liệu.");
            }
            else
            {
                File.Create(path).Close(); 
                Console.WriteLine("Đã tạo file trống: " + path);
            }
        }

        static void Bai2()
        {
            Console.WriteLine(" Bài 2: Xóa file ");
            string path = NhapDuongDan("Nhập đường dẫn file cần xóa: ");

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Đã xóa file: " + path);
            }
            else
            {
                Console.WriteLine("File không tồn tại!");
            }
        }

      
        static void Bai3()
        {
            Console.WriteLine(" Bài 3: Tạo file và ghi văn bản ");
            string path = NhapDuongDan("Nhập đường dẫn file: ");
            Console.Write("Nhập nội dung cần ghi: ");
            string noiDung = Console.ReadLine() ?? "";

            File.WriteAllText(path, noiDung);
            Console.WriteLine("Đã ghi nội dung vào file.");
        }

  
        static void Bai4()
        {
            Console.WriteLine("Bài 4: Tạo file và đọc lại ");
            string path = NhapDuongDan("Nhập đường dẫn file: ");
            Console.Write("Nhập nội dung cần ghi: ");
            string noiDung = Console.ReadLine() ?? "";

            File.WriteAllText(path, noiDung);

         
            using (StreamReader sr = new StreamReader(path))
            {
                string docDuoc = sr.ReadToEnd();
                Console.WriteLine("Nội dung đọc từ file: " + docDuoc);
            }
        }

        static void Bai5()
        {
            Console.WriteLine(" Bài 5: Ghi mảng chuỗi vào file ");
            string path = NhapDuongDan("Nhập đường dẫn file: ");
            int n = NhapSoNguyen("Nhập số phần tử của mảng: ");

            string[] mang = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập chuỗi thứ {i + 1}: ");
                mang[i] = Console.ReadLine() ?? "";
            }

      
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string s in mang)
                {
                    sw.WriteLine(s);
                }
            }
            Console.WriteLine("Đã ghi mảng chuỗi vào file.");
        }
        static void Bai6()
        {
            Console.WriteLine("Bài 6: Ghi nối thêm vào file ");
            string path = NhapDuongDan("Nhập đường dẫn file đã có: ");
            Console.Write("Nhập nội dung cần ghi thêm: ");
            string them = Console.ReadLine() ?? "";

       
            File.AppendAllText(path, them + Environment.NewLine);
            Console.WriteLine("Đã ghi thêm. Nội dung file hiện tại:");
            Console.WriteLine(File.ReadAllText(path));
        }

        static void Bai7()
        {
            Console.WriteLine("Bài 7: Sao chép file ");
            string nguon = NhapDuongDan("Nhập đường dẫn file gốc (sẽ được tạo): ");
            Console.Write("Nhập nội dung cho file gốc: ");
            string noiDung = Console.ReadLine() ?? "";
            string dich = NhapDuongDan("Nhập đường dẫn file đích: ");

            File.WriteAllText(nguon, noiDung);

        
            File.Copy(nguon, dich, true);
            Console.WriteLine("Đã sao chép. Nội dung file đích:");
            Console.WriteLine(File.ReadAllText(dich));
        }

  
        static void Bai8()
        {
            Console.WriteLine("Bài 8: Di chuyển/đổi tên file ");
            string path = NhapDuongDan("Nhập đường dẫn file cần tạo: ");
            File.WriteAllText(path, "File dùng để thử Move.");

            Console.Write("Nhập tên mới (vd: moi.txt): ");
            string tenMoi = Console.ReadLine() ?? "";

            string thuMuc = Path.GetDirectoryName(path) ?? "";
            string duongDanMoi = Path.Combine(thuMuc, tenMoi);

            if (File.Exists(duongDanMoi))
            {
                Console.WriteLine("Đã có file trùng tên, không thể di chuyển!");
            }
            else
            {
                File.Move(path, duongDanMoi);
                Console.WriteLine("Đã đổi thành: " + duongDanMoi);
            }
        }


        static void Bai9()
        {
            Console.WriteLine(" Bài 9: Đọc dòng đầu tiên ");
            string path = NhapDuongDan("Nhập đường dẫn file cần đọc: ");

            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại!");
                return;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string? dong = sr.ReadLine();
                if (dong == null)
                    Console.WriteLine("File rỗng.");
                else
                    Console.WriteLine("Dòng đầu tiên: " + dong);
            }
        }

     
        static void Bai10()
        {
            Console.WriteLine("Bài 10: Đọc dòng cuối cùng ");
            string path = NhapDuongDan("Nhập đường dẫn file: ");
            TaoFileNhieuDong(path);

            string[] cacDong = File.ReadAllLines(path);
            Console.WriteLine("Dòng cuối cùng: " + cacDong[cacDong.Length - 1]);
        }

        static void Bai11()
        {
            Console.WriteLine("Bài 11: Đọc n dòng cuối ");
            string path = NhapDuongDan("Nhập đường dẫn file: ");
            TaoFileNhieuDong(path);

            string[] cacDong = File.ReadAllLines(path);
            int n = NhapSoNguyen("Nhập n (số dòng cuối cần đọc): ");

            int batDau = cacDong.Length - n;
            if (batDau < 0)
            {
                batDau = 0;
            }

            Console.WriteLine($"{cacDong.Length - batDau} dòng cuối:");
            for (int i = batDau; i < cacDong.Length; i++)
            {
                Console.WriteLine(cacDong[i]);
            }
        }

   
        static void Bai12()
        {
            Console.WriteLine("Bài 12: Đọc dòng cụ thể ");
            string path = NhapDuongDan("Nhập đường dẫn file cần đọc: ");

            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại!");
                return;
            }

            string[] cacDong = File.ReadAllLines(path);
            int soDong = NhapSoNguyen("Nhập số thứ tự dòng cần đọc (bắt đầu từ 1): ");

            if (soDong > cacDong.Length)
            {
                Console.WriteLine($"File chỉ có {cacDong.Length} dòng!");
            }
            else
            {
                Console.WriteLine($"Dòng {soDong}: {cacDong[soDong - 1]}");
            }
        }


        static void Bai13()
        {
            Console.WriteLine("Bài 13: Đếm số dòng ");
            string path = NhapDuongDan("Nhập đường dẫn file cần đếm: ");

            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại!");
                return;
            }

            int dem = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null) 
                {
                    dem++;
                }
            }
            Console.WriteLine("Số dòng trong file: " + dem);
        }

       
        static void Bai14()
        {
            Console.WriteLine(" Bài 14: In cấu trúc thư mục ");
            string thuMuc = NhapDuongDan("Nhập đường dẫn thư mục: ");

            if (!Directory.Exists(thuMuc))
            {
                Console.WriteLine("Thư mục không tồn tại!");
                return;
            }

            Console.WriteLine("[+] " + thuMuc);
            InCauTruc(thuMuc, "    ");
        }

        static void Bai15()
        {
            Console.WriteLine(" Bài 15: Thống kê ký tự trong file ");
            string path = NhapDuongDan("Nhập đường dẫn file cần thống kê: ");

            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại!");
                return;
            }

            string[] cacDong = File.ReadAllLines(path);

            int[,] thongKe = new int[2, 26];

            foreach (string dong in cacDong)
            {
                foreach (char c in dong)
                {
                    if (c >= 'a' && c <= 'z')
                        thongKe[0, c - 'a']++;
                    else if (c >= 'A' && c <= 'Z')
                        thongKe[0, c - 'A']++;
                    else if (c >= '0' && c <= '9')
                        thongKe[1, c - '0']++;
                }
            }

            Console.WriteLine("\nThống kê chữ cái:");
            for (int j = 0; j < 26; j++)
            {
                if (thongKe[0, j] > 0)
                {
                    Console.WriteLine($"  '{(char)('a' + j)}': {thongKe[0, j]} lần");
                }
            }

            Console.WriteLine("Thống kê chữ số:");
            for (int j = 0; j < 10; j++)
            {
                if (thongKe[1, j] > 0)
                {
                    Console.WriteLine($"  '{j}': {thongKe[1, j]} lần");
                }
            }

    
            Console.Write("\nNhập ký tự muốn xem vị trí xuất hiện (bỏ trống để bỏ qua): ");
            string nhap = Console.ReadLine() ?? "";
            if (nhap == "")
            {
                return;
            }
            char can = char.ToLower(nhap[0]);

       
            int[][] viTri = new int[cacDong.Length][];
            for (int i = 0; i < cacDong.Length; i++)
            {
              
                int dem = 0;
                for (int j = 0; j < cacDong[i].Length; j++)
                {
                    if (char.ToLower(cacDong[i][j]) == can)
                        dem++;
                }

                viTri[i] = new int[dem];

                int k = 0;
                for (int j = 0; j < cacDong[i].Length; j++)
                {
                    if (char.ToLower(cacDong[i][j]) == can)
                    {
                        viTri[i][k] = j + 1;
                        k++;
                    }
                }
            }

            bool coXuatHien = false;
            for (int i = 0; i < viTri.Length; i++)
            {
                if (viTri[i].Length > 0)
                {
                    coXuatHien = true;
                    Console.Write($"Dòng {i + 1}: cột ");
                    for (int k = 0; k < viTri[i].Length; k++)
                    {
                        Console.Write(viTri[i][k] + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (!coXuatHien)
            {
                Console.WriteLine($"Ký tự '{nhap[0]}' không xuất hiện trong file.");
            }
        }

       

        static void Main(string[] args)
        {
          
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int chon;
            do
            {
                Console.WriteLine("\nMENU BÀI TẬP FILE ");
                Console.WriteLine("1.  Tạo file trống");
                Console.WriteLine("2.  Xóa file");
                Console.WriteLine("3.  Tạo file và ghi văn bản");
                Console.WriteLine("4.  Tạo file văn bản và đọc lại");
                Console.WriteLine("5.  Ghi mảng chuỗi vào file");
                Console.WriteLine("6.  Ghi nối thêm vào file");
                Console.WriteLine("7.  Sao chép file và hiển thị nội dung");
                Console.WriteLine("8.  Tạo file và đổi tên (Move cùng thư mục)");
                Console.WriteLine("9.  Đọc dòng đầu tiên");
                Console.WriteLine("10. Tạo file và đọc dòng cuối cùng");
                Console.WriteLine("11. Tạo file và đọc n dòng cuối");
                Console.WriteLine("12. Đọc một dòng cụ thể");
                Console.WriteLine("13. Đếm số dòng của file");
                Console.WriteLine("14. In cấu trúc thư mục");
                Console.WriteLine("15. Thống kê chữ cái, chữ số trong file");
                Console.WriteLine("0.  Thoát");
                Console.Write("Chọn bài (0-15): ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    chon = -1;
                }

                Console.WriteLine();

                // try-catch bắt các lỗi như sai đường dẫn, không đủ quyền truy cập...
                try
                {
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
                        case 14: Bai14(); break;
                        case 15: Bai15(); break;
                        case 0: Console.WriteLine("Tạm biệt!"); break;
                        default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                }
            } while (chon != 0);
        }
    }
}
