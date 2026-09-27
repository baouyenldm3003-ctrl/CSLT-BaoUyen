using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSLT_BaoUyen.Sesson_07
{
    internal class Excercise_03
    {
       
        // BÀI 1: CÁC HÀM XỬ LÝ MẢNG MỘT CHIỀU
       

        static int[] TaoMangNgauNhien(int n, int min, int max)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max + 1);
            return a;
        }

        static void InMang(int[] a)
        {
            foreach (int x in a)
                Console.Write(x + "\t");
            Console.WriteLine();
        }

        // 1. Tính giá trị trung bình
        static double TinhTrungBinh(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            return sum / a.Length;
        }

        // 2. Kiểm tra mảng có chứa giá trị cụ thể
        static bool KiemTraChua(int[] a, int giaTri)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == giaTri) return true;
            return false;
        }

        // 3. Tìm chỉ số của phần tử
        static int TimChiSo(int[] a, int giaTri)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == giaTri) return i;
            return -1;
        }

        // 4. Xóa một phần tử cụ thể khỏi mảng
        static int[] XoaPhanTu(int[] a, int giaTri)
        {
            List<int> list = new List<int>(a);
            list.Remove(giaTri); // xóa lần xuất hiện đầu tiên của giá trị
            return list.ToArray();
        }

        // 5. Tìm giá trị lớn nhất / nhỏ nhất
        static int TimMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > max) max = a[i];
            return max;
        }

        static int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < min) min = a[i];
            return min;
        }

        // 6. Đảo ngược mảng
        static void DaoNguocMang(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;
            }
        }

        // 7. Tìm các giá trị trùng lặp
        static List<int> TimGiaTriTrung(int[] a)
        {
            List<int> trung = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j] && !trung.Contains(a[i]))
                        trung.Add(a[i]);
                }
            }
            return trung;
        }

        // 8. Xóa các phần tử trùng lặp
        static int[] XoaPhanTuTrung(int[] a)
        {
            List<int> ketQua = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!ketQua.Contains(a[i]))
                    ketQua.Add(a[i]);
            }
            return ketQua.ToArray();
        }

        static void BaiTapMang()
        {
            Console.WriteLine("===== BÀI 1: MẢNG MỘT CHIỀU =====");
            int[] a = TaoMangNgauNhien(10, 1, 20);
            Console.Write("Mảng vừa tạo: ");
            InMang(a);

            Console.WriteLine("1. Trung bình cộng = " + TinhTrungBinh(a));

            Console.Write("2. Nhập giá trị cần kiểm tra: ");
            int gt1 = int.Parse(Console.ReadLine());
            Console.WriteLine(KiemTraChua(a, gt1)
                ? "   -> Mảng có chứa giá trị này."
                : "   -> Mảng không chứa giá trị này.");

            Console.Write("3. Nhập giá trị cần tìm chỉ số: ");
            int gt2 = int.Parse(Console.ReadLine());
            int viTri = TimChiSo(a, gt2);
            Console.WriteLine(viTri >= 0
                ? $"   -> Chỉ số của {gt2} là {viTri}"
                : "   -> Không tìm thấy giá trị này.");

            Console.Write("4. Nhập giá trị cần xóa khỏi mảng: ");
            int gt3 = int.Parse(Console.ReadLine());
            int[] aSauXoa = XoaPhanTu(a, gt3);
            Console.Write("   -> Mảng sau khi xóa: ");
            InMang(aSauXoa);

            Console.WriteLine("5. Giá trị lớn nhất = " + TimMax(a) + " , nhỏ nhất = " + TimMin(a));

            int[] aDao = (int[])a.Clone();
            DaoNguocMang(aDao);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            InMang(aDao);

            List<int> trung = TimGiaTriTrung(a);
            Console.WriteLine("7. Giá trị trùng lặp: " + (trung.Count > 0 ? string.Join(", ", trung) : "Không có"));

            int[] khongTrung = XoaPhanTuTrung(a);
            Console.Write("8. Mảng sau khi xóa trùng lặp: ");
            InMang(khongTrung);

            Console.WriteLine();
        }
        // BÀI 2: SẮP XẾP NỔI BỌT (BUBBLE SORT) & TÌM KIẾM TUYẾN TÍNH
       
        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static bool TimKiemTuyenTinh(string[] cacTu, string tuCanTim)
        {
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (cacTu[i].Equals(tuCanTim, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        static void BaiTapSapXepTimKiem()
        {
            Console.WriteLine("===== BÀI 2: SẮP XẾP NỔI BỌT & TÌM KIẾM TUYẾN TÍNH =====");
            int[] soNguyen = new int[10];
            Console.WriteLine("Nhập 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"  Số thứ {i + 1}: ");
                soNguyen[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(soNguyen);
            Console.Write("Mảng sau khi sắp xếp (bubble sort): ");
            InMang(soNguyen);

            Console.Write("\nNhập một câu: ");
            string cau = Console.ReadLine();
            Console.Write("Nhập từ cần tìm: ");
            string tu = Console.ReadLine();

            string[] cacTu = cau.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool coChua = TimKiemTuyenTinh(cacTu, tu);
            Console.WriteLine(coChua
                ? $"-> Từ \"{tu}\" CÓ xuất hiện trong câu."
                : $"-> Từ \"{tu}\" KHÔNG xuất hiện trong câu.");

            Console.WriteLine();
        }

        
        // BÀI 3: MA TRẬN (MẢNG HAI CHIỀU)
  

        static void KhoiTaoMangRandom(int[,] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rnd.Next(1, 10);
        }

        static void InMaTran(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($"{a[i, j]}\t");
                Console.WriteLine();
            }
        }

        static void InHang(int[,] a, int hang)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write($"{a[hang, j]}\t");
            Console.WriteLine();
        }

        static void InCot(int[,] a, int cot)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write($"{a[i, cot]}\t");
            Console.WriteLine();
        }

        static int MaxMaTran(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max) max = a[i, j];
            return max;
        }

        static int MinCuaHang(int[,] a, int hang)
        {
            int min = a[hang, 0];
            for (int j = 1; j < a.GetLength(1); j++)
                if (a[hang, j] < min) min = a[hang, j];
            return min;
        }

        static int MinCuaCot(int[,] a, int cot)
        {
            int min = a[0, cot];
            for (int i = 1; i < a.GetLength(0); i++)
                if (a[i, cot] < min) min = a[i, cot];
            return min;
        }

        static int[,] ChuyenVi(int[,] a)
        {
            int soHang = a.GetLength(0);
            int soCot = a.GetLength(1);
            int[,] kq = new int[soCot, soHang];
            for (int i = 0; i < soHang; i++)
                for (int j = 0; j < soCot; j++)
                    kq[j, i] = a[i, j];
            return kq;
        }

        static void InDuongCheo(int[,] a)
        {
            int n = a.GetLength(0);
            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i, i] + " ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ:   ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i, n - 1 - i] + " ");
            Console.WriteLine();
        }

        static void BaiTapMaTran()
        {
            Console.WriteLine("===== BÀI 3: MA TRẬN =====");
            Console.Write("Nhập số hàng N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mang = new int[n, m];
            KhoiTaoMangRandom(mang);
            Console.WriteLine("Ma trận vừa tạo:");
            InMaTran(mang);

            Console.Write($"\nNhập chỉ số hàng i (0 - {n - 1}) muốn in: ");
            int i1 = int.Parse(Console.ReadLine());
            Console.Write("-> Hàng đã chọn: ");
            InHang(mang, i1);

            Console.Write($"Nhập chỉ số cột j (0 - {m - 1}) muốn in: ");
            int j1 = int.Parse(Console.ReadLine());
            Console.Write("-> Cột đã chọn: ");
            InCot(mang, j1);

            Console.WriteLine("\nGiá trị lớn nhất của cả ma trận: " + MaxMaTran(mang));

            Console.Write($"Nhập chỉ số hàng i muốn tìm giá trị nhỏ nhất: ");
            int i2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"-> Giá trị nhỏ nhất của hàng {i2}: " + MinCuaHang(mang, i2));

            Console.Write($"Nhập chỉ số cột j muốn tìm giá trị nhỏ nhất: ");
            int j2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"-> Giá trị nhỏ nhất của cột {j2}: " + MinCuaCot(mang, j2));

            int[,] matranChuyenVi = ChuyenVi(mang);
            Console.WriteLine("\nMa trận sau khi chuyển vị:");
            InMaTran(matranChuyenVi);

            if (n == m)
            {
                Console.WriteLine();
                InDuongCheo(mang);
            }
            else
            {
                Console.WriteLine("\n(Ma trận không vuông nên không có đường chéo chính/phụ)");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BaiTapMang();
            BaiTapSapXepTimKiem();
            BaiTapMaTran();

            Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }


    }
}
