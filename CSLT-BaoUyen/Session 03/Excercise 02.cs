using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_BaoUyen.Session_03
{ 
  
    public enum VehicleType { Motorbike, Car, Truck }
    public enum CustomerType { Child, Student, Adult, Senior }
    internal class Excercise_02

    {


        static void Bai_1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập vào chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine()!);
            float csd_moi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới (kWh):");
                csd_moi = float.Parse(Console.ReadLine()!);
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

        static void Bai_2()
        {
            Console.WriteLine(" Bài 2 : Tính chỉ số  BMI ");
            Console.Write(" Nhập chiều  cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine()!);
            Console.Write(" Nhập cân nặng  (kg): ");
            double canNang = double.Parse(Console.ReadLine()!);

            double bmi = canNang / (chieuCao * chieuCao);
            string phanLoai = "";

            if (bmi < 18.5) phanLoai = "Gầy (Thiếu cân)";
            else if ( bmi < 23.0) phanLoai = "Bình thường (Lý tưởng)";
            else if ( bmi < 25.0) phanLoai = "Thừa cân (Tiền béo phì)";
            else phanLoai = "Béo phì";

            double minWeight = 18.5 * chieuCao * chieuCao;
            double maxWeight = 22.9 * chieuCao * chieuCao;

            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng nên từ {minWeight:F2} kg đến {maxWeight:F2} kg.");
        }

        static void Bai_3()
        {
            Console.WriteLine(" Bài  3: Quy đổi ngoại tệ ");
            Console.Write("Nhập số tiền VND: ");
            decimal vnd = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("Chọn loại ngoại tệ: 1-USD, 2-EUR, 3-JPY, 4-GBP");
            Console.Write("Lựa chọn của bạn: ");
            int chon = int.Parse(Console.ReadLine()!);

            decimal phiDichVu = vnd * 0.005m; 
            decimal vndConLai = vnd - phiDichVu;
            decimal tyGia = 0m;
            string tenTien = "";

            switch (chon)
            {
                case 1: tyGia = 25400m; tenTien = "USD"; break;
                case 2: tyGia = 27200m; tenTien = "EUR"; break;
                case 3: tyGia = 165m; tenTien = "JPY"; break;
                case 4: tyGia = 32100m; tenTien = "GBP"; break;
            }

            decimal ngoaiTe = vndConLai / tyGia;

            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VND");
            Console.WriteLine($"Số tiền VND tính đổi: {vndConLai:N0} VND");
            Console.WriteLine($"Số tiền {tenTien} nhận được: {ngoaiTe:F2} {tenTien}");
        } 

        static void Bai_4()
        {
            Console.WriteLine("Bài 4 : Tính tuổi và đếm ngày sinh nhật");
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string strNgaySinh = Console.ReadLine()!;

            DateTime ngaySinh = DateTime.ParseExact(strNgaySinh, "dd/MM/yyyy", null);
            DateTime ngayHienTai = DateTime.Now.Date;

            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngayHienTai < ngaySinh.AddYears(tuoi)) tuoi--;

            TimeSpan daSong = ngayHienTai - ngaySinh;

            DateTime sinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatTiepTheo < ngayHienTai) sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);

            TimeSpan conLai = sinhNhatTiepTheo - ngayHienTai;

            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {daSong.TotalDays:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {conLai.TotalDays} ngày nữa");
        }


        static void Bai_5()
        {
            Console.WriteLine(" Bài 5 : Tính điểm GPA ");
            Console.Write("Điểm C# (4 Tín chỉ): "); double d1 = double.Parse(Console.ReadLine()!);
            Console.Write("Điểm Toán rời rạc (3 Tín chỉ): "); double d2 = double.Parse(Console.ReadLine()!);
            Console.Write("Điểm Tiếng Anh (2 Tín chỉ): "); double d3 = double.Parse(Console.ReadLine()!);

            double scoreAvg = (d1 * 4 + d2 * 3 + d3 * 2) / (4 + 3 + 2);
            char diemChu; double gpa; string xepLoai;

            if (scoreAvg >= 8.5) { diemChu = 'A'; gpa = 4.0; xepLoai = "Xuất sắc / Giỏi"; }
            else if (scoreAvg >= 7.0) { diemChu = 'B'; gpa = 3.0; xepLoai = "Khá"; }
            else if (scoreAvg >= 5.5) { diemChu = 'C'; gpa = 2.0; xepLoai = "Trung bình"; }
            else if (scoreAvg >= 4.0) { diemChu = 'D'; gpa = 1.0; xepLoai = "Yếu"; }
            else { diemChu = 'F'; gpa = 0.0; xepLoai = "Kém (Trượt)"; }

            Console.WriteLine($"Điểm TB Thang 10: {scoreAvg:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }


        static void Bai_6()
        {
            Console.WriteLine(" Bài 6 : Chuẩn hóa họ tên ");
            Console.Write("Nhập họ tên thô: ");
            string hoTenTho = Console.ReadLine()!;

            string[] cacTu = hoTenTho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cacTu.Length; i++)
            {
                cacTu[i] = cacTu[i].Substring(0, 1).ToUpper() + cacTu[i].Substring(1).ToLower();
            }

            string hoTenChuan = string.Join(" ", cacTu);
            string ho = cacTu[0];
            string ten = cacTu[cacTu.Length - 1];

            string tenDem = "";
            for (int i = 1; i < cacTu.Length - 1; i++) tenDem += cacTu[i] + " ";

            string username = ten.ToLower() + "." + ho.ToLower();
            for (int i = 1; i < cacTu.Length - 1; i++) username += cacTu[i].ToLower();

            string email = username + "@company.edu.vn";

            Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuan}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem.Trim()} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");
        }

        static void Bai_7()
        {
            Console.WriteLine("Bài 7 : Chi phí nhiên liệu và chia sẻ chuyến đi ");
            Console.Write("Quãng đường (km): "); double quangDuong = double.Parse(Console.ReadLine()!);
            Console.Write("Mức tiêu hao (L/100km): "); double mucTieuHao = double.Parse(Console.ReadLine()!);
            Console.Write("Giá xăng (VND/Lít): "); decimal giaXang = decimal.Parse(Console.ReadLine()!);
            Console.Write("Số người đi: "); int soNguoi = int.Parse(Console.ReadLine()!);

            double tongLit = (quangDuong / 100) * mucTieuHao;
            decimal tongChiPhi = (decimal)tongLit * giaXang;
            decimal chiPhiMoiNguoi = Math.Ceiling((tongChiPhi / soNguoi) / 1000m) * 1000m;

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongLit:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VND");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VND");
        }

        static void Bai_8()
        {
            Console.WriteLine("Bài 8 : Kiểm tra mã OTP");
            string otpDung = "839201";
            Console.Write("Mã OTP nhận được: "); string otpNhap = Console.ReadLine()!;
            Console.Write("Số phút đã trôi qua: "); int soPhut = int.Parse(Console.ReadLine()!);

            int temp;
            bool isNumber = int.TryParse(otpNhap, out temp);

            if (otpNhap.Length != 6 || !isNumber)
                Console.WriteLine("LỖI: Mã OTP phải có đúng 6 chữ số!");
            else if (otpNhap != otpDung)
                Console.WriteLine("LỖI: Mã OTP không đúng!");
            else if (soPhut > 5)
                Console.WriteLine("LỖI: Mã OTP đã hết hạn!");
            else
            {
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG");
                Console.WriteLine("Giao dịch đã được phê duyệt.");
            }
        }

        static void Bai_9()
        {
            Console.WriteLine("Bài 9 :  Tính Lương Gross - Net & Thuế TNCN Nhân Viên");
            Console.Write("Lương Gross (VND): "); decimal gross = decimal.Parse(Console.ReadLine()!);
            Console.Write("Số người phụ thuộc: "); int phuThuoc = int.Parse(Console.ReadLine()!);

            decimal tongBaoHiem = gross * 0.105m;
            decimal thuNhapChiuThue = gross - tongBaoHiem - 11000000m - (phuThuoc * 4400000m);
            if (thuNhapChiuThue < 0) thuNhapChiuThue = 0;

            decimal thueTNCN = 0m;
            if (thuNhapChiuThue > 0)
            {
                if (thuNhapChiuThue <= 5000000m)
                    thueTNCN = thuNhapChiuThue * 0.05m;
                else if (thuNhapChiuThue <= 10000000m)
                    thueTNCN = 5000000m * 0.05m + (thuNhapChiuThue - 5000000m) * 0.10m;
                else
                    thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + (thuNhapChiuThue - 10000000m) * 0.15m;
            }

            decimal luongNet = gross - tongBaoHiem - thueTNCN;

            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {tongBaoHiem:N0} VND");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VND");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VND");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0} VND");
        }

        static void Bai_10()
        {
            Console.WriteLine("Bài 10 : Quản lý tồn kho ");
               string maSP = "KB-09";
            string tenSP = "Bàn phím Cơ Akko";
            int? quantity = null;
            DateTime? restockDate = null;
            int minThreshold = 10;

            Console.WriteLine($"Sản phẩm: {tenSP} (Mã: {maSP})");
            Console.WriteLine($"Số lượng tồn kho: {quantity?.ToString() ?? "null (Chưa kiểm kê)"}");
            Console.WriteLine($"Restock Date: {restockDate?.ToString() ?? "null"}");

            int quantityHienThi = quantity ?? 0;
            string trangThaiKho;
            if (quantity == null || quantity == 0) trangThaiKho = "OutOfStock (Hết hàng)";
            else if (quantity < minThreshold) trangThaiKho = "LowStock (Sắp hết)";
            else trangThaiKho = "InStock";

            string duKienNhap = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";

   
            Console.WriteLine($"Số lượng hiển thị: {quantityHienThi} (Cảnh báo: Dữ liệu trống)");
            Console.WriteLine($"Trạng thái kho: {trangThaiKho}");
            Console.WriteLine($"Dự kiến nhập hàng: {duKienNhap}");
        }

        static void Bai_11()
        {
            Console.WriteLine("Bài 11 : Tính lãi suất tiết kiệm ");
            Console.Write("Số tiền gửi (VND): "); decimal P = decimal.Parse(Console.ReadLine()!);
            Console.Write("Lãi suất năm  (%): "); double r = double.Parse(Console.ReadLine()!);
            Console.Write("Thời gian gửi (tháng): "); int n = int.Parse(Console.ReadLine()!);

            decimal laiDon = P * (decimal)(r / 100) * (decimal)(n / 12.0);
            double tongLaiKep = (double)P * Math.Pow(1 + (r / 100) / 12, n);
            decimal laiKep = (decimal)tongLaiKep - P;

            Console.WriteLine($"Tổng tiền lãi (Lãi đơn ): {laiDon:N0} VND");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép ): {laiKep:N0} VND");
            Console.WriteLine($"Lợi nhuận chênh lệch : {(laiKep - laiDon):N0} VND");
        }
      
        static void Bai_12()
        {
            Console.WriteLine("Bài 12 :  Bộ Mã Hóa & Giải Mã Tin Nhắn Mật Mã Caesar (Caesar Cipher)");
            Console.Write("Văn bản gốc : "); string text = Console.ReadLine()!;
            Console.Write("Khóa dịch chuyển  (k): "); int k = int.Parse(Console.ReadLine()!);

            string enc = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'A' && c <= 'Z') enc += (char)('A' + (c - 'A' + k) % 26);
                else if (c >= 'a' && c <= 'z') enc += (char)('a' + (c - 'a' + k) % 26);
                else enc += c;
            }
            string dec = "";
            for (int i = 0; i < enc.Length; i++)
            {
                char c = enc[i];
                if (c >= 'A' && c <= 'Z')
                    dec += (char)('A' + (c - 'A' - k + 26) % 26);
                else if (c >= 'a' && c <= 'z')
                    dec += (char)('a' + (c - 'a' - k + 26) % 26);
                else
                    dec += c;
            }

   
            Console.WriteLine($"Văn bản Mã hóa  (Encrypted): {enc}");
            Console.WriteLine($"Van ban Giải mã  (Decrypted): {dec}");
        }
        
        static void Bai_13()
        {
            Console.WriteLine("Bài 13 : Tính phí bãi gửi xe ");
            Console.Write("Loại xe (0-Motorbike, 1-Car, 2-Truck): ");
            VehicleType loaiXe = (VehicleType) int.Parse(Console.ReadLine()!);

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine()!);
            double totalHours = (checkOut - checkIn).TotalHours;
            int soGio = (int)Math.Ceiling(totalHours);

            decimal phi2GioDau = 0m;
            decimal phiGioTiep = 0m;

            switch (loaiXe)
            {
                case VehicleType.Motorbike:
                    phi2GioDau = 5000m;
                    phiGioTiep = 2000m;
                    break;
                case VehicleType.Car:
                    phi2GioDau = 20000m;
                    phiGioTiep = 10000m;
                    break;
                case VehicleType.Truck:
                    phi2GioDau = 50000m;
                    phiGioTiep = 25000m;
                    break;
            }

            int soGioTiepTheo = soGio > 2 ? soGio - 2 : 0;
            decimal tienGioTiepTheo = soGioTiepTheo * phiGioTiep;
            decimal tongTien = phi2GioDau + tienGioTiepTheo;
            if (checkOut.Date > checkIn.Date)
            {
                tongTien += 30000m;
            }
            Console.WriteLine($"Tổng thời gian đỗ: {totalHours:F2} giờ -> Tính phí: {soGio} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phi2GioDau:N0} VNĐ");
            Console.WriteLine($"Phí {soGioTiepTheo} giờ tiếp theo: {tienGioTiepTheo:N0} VNĐ ({phiGioTiep:N0} x {soGioTiepTheo})");
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {tongTien:N0} VNĐ");
        }

       
        static void Bai_14()
        {
            Console.WriteLine("Bài 14 : Kiểm tra số nguyên ");
            Console.Write("Nhập chuỗi số: ");
            string input = Console.ReadLine()!;
            int number;
            bool isValid = int.TryParse(input, out number);

            if (isValid)
            {
                Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {number}");

                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine("Phù hợp kiểu byte: CÓ (Vừa vặn trong dải 0-255)");
                }
                else
                {
                    Console.WriteLine("Phù hợp kiểu byte: KHÔNG");
                }
                int temp = Math.Abs(number);
                string strNum = temp.ToString();
                int sum = 0;
                string phepTinh = "";

                for (int i = 0; i < strNum.Length; i++)
                {
                    int digit = int.Parse(strNum[i].ToString());
                    sum += digit;
                    phepTinh += (i == 0) ? $"{digit}" : $" + {digit}";
                }
                Console.WriteLine($"Tổng các chữ số: {phepTinh} = {sum}");

             
                try
                {
                    checked
                    {
                        int testOverflow = number * 10000000;
                        Console.WriteLine("Kiểm tra Tràn số: An toàn trong phạm vi int32.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Kiểm tra Tràn số: Phát hiện tràn số (OverflowException)!");
                }
            }
            else
            {
                Console.WriteLine("Kiểm tra Parse: Thất bại! Chuỗi nhập vào không phải số nguyên hợp lệ.");
            }
        }
      
        static void Bai_15()
        {
            Console.WriteLine("Bài 15 : Vé rạp chiếu phim ");
            Console.Write("Khách hàng (0-Child, 1-Student, 2-Adult, 3-Senior): ");
            CustomerType customer = (CustomerType) int.Parse(Console.ReadLine()!);

            Console.Write("Thẻ SV hợp lệ (true/false): ");
            bool hasCard = bool.Parse(Console.ReadLine()!);

            Console.Write("Ngày xem (Monday, Tuesday, Wednesday, ...): ");
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine()!, true);

            decimal basePrice = 100000m;
            decimal giamGia = 0m;
            string tenGiamGia = "Giảm giá";

            // Logic giảm giá
            if (customer == CustomerType.Child || customer == CustomerType.Senior)
            {
                giamGia = basePrice * 0.5m;
                tenGiamGia = "Giảm giá (50%)";
            }
            else if (customer == CustomerType.Student && hasCard && (day >= DayOfWeek.Monday && day <= DayOfWeek.Thursday))
            {
                giamGia = basePrice * 0.3m;
                tenGiamGia = "Giảm giá SV (30%)";
            }
            else if (customer == CustomerType.Adult && day == DayOfWeek.Wednesday)
            {
                giamGia = basePrice * 0.2m;
                tenGiamGia = "Giảm giá Thứ 4 (20%)";
            }

            // Phụ thu cuối tuần (Thứ 6, Thứ 7, Chủ Nhật)
            decimal phuThu = 0m;
            if (day == DayOfWeek.Friday || day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                phuThu = 20000m;
            }

            decimal tongTien = basePrice - giamGia + phuThu;

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Giá vé gốc: {basePrice:N0} VNĐ");
            Console.WriteLine($"{tenGiamGia}: -{giamGia:N0} VNĐ");
            Console.WriteLine($"Phụ thu cuối tuần: {phuThu:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN VÉ: {tongTien:N0} VNĐ");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
            Bai_6();
            Bai_7();
            Bai_8();
            Bai_9();
            Bai_10();
            Bai_11();
            Bai_12();
            Bai_13();
            Bai_14();
            Bai_15();

            Console.ReadKey();


        }
    }
}

