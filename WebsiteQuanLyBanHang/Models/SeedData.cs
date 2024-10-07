using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyBanHang.Data;

namespace WebsiteQuanLyBanHang.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebsiteQuanLyBanHangContext(
                                     serviceProvider.
                                     GetRequiredService<DbContextOptions<WebsiteQuanLyBanHangContext>>()))
            {
                if (context.Catalog.Any())
                {
                    return;
                }
                context.Catalog.AddRange(
                    new Catalog
                    {
                        CatalogCode = "DM01",
                        CatalogName = "Điện Thoại"
                    },
                    new Catalog
                    {
                        CatalogCode = "DM02",
                        CatalogName = "Máy Tính"
                    },
                    new Catalog
                    {
                        CatalogCode = "DM03",
                        CatalogName = "Thời Trang"
                    },
                    new Catalog
                    {
                        CatalogCode = "DM04",
                        CatalogName = "Gia Dụng"
                    },
                    new Catalog
                    {
                        CatalogCode = "CAT113",
                        CatalogName = "Hàng Cháy Nổ"
                    }
                  );
                if (context.Product.Any())
                {
                    return;
                }
                context.Product.AddRange(
                    new Product
                    {
                        CatalogId = 1,
                        ProductCode = "PRO01",
                        ProductName = "SamSung J7",
                        Picture = "PRO01.PNG",
                        UnitPrice = 10000000
                    },
                    new Product
                    {
                        CatalogId = 1,
                        ProductCode = "PRO02",
                        ProductName = "Iphone X",
                        Picture = "PRO02.PNG",
                        UnitPrice = 30000000
                    },
                    new Product
                    {
                        CatalogId = 2,
                        ProductCode = "PRO03",
                        ProductName = "Dell Inspiron 03",
                        Picture = "PRO03.PNG",
                        UnitPrice = 12000000
                    }, 
                    new Product
                    {
                        CatalogId = 2,
                        ProductCode = "PRO04",
                        ProductName = "Dell Inspiron 04",
                        Picture = "PRO04.PNG",
                        UnitPrice = 13000000
                    },
                    new Product
                    {
                        CatalogId = 2,
                        ProductCode = "PRO05",
                        ProductName = "Acer AS A3",
                        Picture = "PRO05.PNG",
                        UnitPrice = 9000000
                    }
                  );
                context.SaveChanges();
            }
        }
    }
}
