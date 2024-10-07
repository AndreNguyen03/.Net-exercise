using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyBanHang.Models;

namespace WebsiteQuanLyBanHang.Data
{
    public class WebsiteQuanLyBanHangContext : DbContext
    {
        public WebsiteQuanLyBanHangContext (DbContextOptions<WebsiteQuanLyBanHangContext> options)
            : base(options)
        {
        }

        public DbSet<WebsiteQuanLyBanHang.Models.Catalog> Catalog { get; set; } = default!;
        public DbSet<WebsiteQuanLyBanHang.Models.Product> Product { get; set; } = default!;
    }
}
