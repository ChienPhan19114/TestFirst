using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestFirst.Models;

namespace TestFirst.Data
{
    public class SanPhamContext : DbContext
    {
        public SanPhamContext(DbContextOptions<SanPhamContext> options) : base(options) { }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
