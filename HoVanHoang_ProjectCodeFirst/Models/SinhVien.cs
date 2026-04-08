using System;

namespace HoVanHoang_ProjectCodeFirst.Models
{
    public class SinhVien
    {
        public int SinhVienId { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemTrungBinh { get; set; }

        public int LopHocId { get; set; }
        public LopHoc LopHoc { get; set; }
    }
}
