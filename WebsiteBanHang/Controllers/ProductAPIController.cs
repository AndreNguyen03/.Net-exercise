using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Models;
using WebsiteBanHang.Models.ProductModels;

namespace WebsiteBanHang.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var sanPham = (from p in db.TDanhMucSps
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               AnhDaiDien = p.AnhDaiDien,
                               GiaNhoNhat = p.GiaNhoNhat,
                               MaLoai = p.MaLoai
                           }).ToList();
            return sanPham;
        }

        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetAllProducts(string maloai)
        {
            var sanPham = (from p in db.TDanhMucSps
                           where p.MaLoai == maloai
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               AnhDaiDien = p.AnhDaiDien,
                               GiaNhoNhat = p.GiaNhoNhat,
                               MaLoai = p.MaLoai
                           }).ToList();
            return sanPham;
        }
    }
}
