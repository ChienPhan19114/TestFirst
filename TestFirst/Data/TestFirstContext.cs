using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestFirst.Models;

namespace TestFirst.Data
{
    public class TestFirstContext : DbContext
    {
        public TestFirstContext (DbContextOptions<TestFirstContext> options)
            : base(options)
        {
        }

        public DbSet<TestFirst.Models.NhanVien> NhanVien { get; set; }

        public DbSet<TestFirst.Models.ChiTietHD> ChiTietHD { get; set; }

        public DbSet<TestFirst.Models.HoaDon> HoaDon { get; set; }

        public DbSet<TestFirst.Models.KhachHang> KhachHang { get; set; }

        public DbSet<TestFirst.Models.SanPham> SanPham { get; set; }
    }
}
