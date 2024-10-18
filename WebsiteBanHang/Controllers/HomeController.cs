using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebsiteBanHang.Models;
using WebsiteBanHang.Models.Authentication;
using WebsiteBanHang.ViewModels;
using X.PagedList;

namespace WebsiteBanHang.Controllers
{
	public class HomeController : Controller
	{
		QlbanVaLiContext db = new QlbanVaLiContext();
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		/*[Authentication]*/
		public IActionResult Index(int? page)
		{
			int pageSize = 8;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			var listSanPham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);

			PagedList<TDanhMucSp> list = new PagedList<TDanhMucSp>(listSanPham, pageNumber, pageSize);

			return View(list);
		}

		public IActionResult SanPhamTheoLoai(string maloai, int? page)
		{
			int pageSize = 8;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			List<TDanhMucSp> listSanPham = db.TDanhMucSps.Where(x => x.MaLoai == maloai)
														.ToList();

			PagedList<TDanhMucSp> list = new PagedList<TDanhMucSp>(listSanPham, pageNumber, pageSize);
			ViewBag.maloai = maloai;
			return View(list);
		}

		public IActionResult ProductDetail(string maSp)
		{
			var sanPham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
			var anhSanPham = db.TAnhSps.Where(x => x.MaSp == maSp).ToList();
			var homeProductDetailViewModel = new HomeProductDetailViewModel
			{
				danhMucSp = sanPham,
				anhSps = anhSanPham
			};
			return View(homeProductDetailViewModel);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
