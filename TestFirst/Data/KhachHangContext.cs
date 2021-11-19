using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestFirst.Models;

namespace TestFirst.Data
{
    public class KhachHangContext : DbContext
    {
        public KhachHangContext(DbContextOptions<KhachHangContext> options) : base(options) { }
        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}
