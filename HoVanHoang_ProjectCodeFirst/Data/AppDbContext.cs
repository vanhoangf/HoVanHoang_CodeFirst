using Microsoft.EntityFrameworkCore;
using HoVanHoang_ProjectCodeFirst.Models;

namespace HoVanHoang_ProjectCodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
    }
}