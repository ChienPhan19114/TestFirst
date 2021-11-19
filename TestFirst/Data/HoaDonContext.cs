using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestFirst.Models;

namespace TestFirst.Data
{
    public class HoaDonContext : DbContext
    {
        public HoaDonContext(DbContextOptions<HoaDonContext> options) : base(options) { }
        public DbSet<HoaDon> HoaDons { get; set; }
    }
}
