using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanHang.Models;
using X.PagedList;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
		{
			int pageSize = 12;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			var listSanPham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);

			PagedList<TDanhMucSp> list = new PagedList<TDanhMucSp>(listSanPham, pageNumber, pageSize);

			return View(list);
		}

        [Route("themsanphammoi")]
        [HttpGet]
        public IActionResult ThemSanPhamMoi()
        {
            ViewBag.MaChatLieu = new SelectList(db.TChatLieus.ToList(),"MaChatLieu","ChatLieu");
            ViewBag.MaHangSx = new SelectList(db.THangSxes.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(db.TQuocGia.ToList(),"MaNuoc","TenNuoc");
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(),"MaLoai","Loai");
            ViewBag.MaDt = new SelectList(db.TLoaiDts.ToList(),"MaDt","TenLoai");
            return View();
        }

        [Route("themsanphammoi")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPhamMoi(TDanhMucSp sanPham)
        {
            if(ModelState.IsValid)
            {
                db.TDanhMucSps.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("DanhMucSanPham");
            }
            return View(sanPham);
        }

        [Route("suasanpham")]
        [HttpGet]
        public IActionResult SuaSanPham(string maSp)
        {
            ViewBag.MaChatLieu = new SelectList(db.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(db.THangSxes.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(db.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(db.TLoaiDts.ToList(), "MaDt", "TenLoai");
            var sanPham = db.TDanhMucSps.Find(maSp);
            return View(sanPham);
        }

        [Route("suasanpham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(TDanhMucSp sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Update(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhMucSanPham", "HomeAdmin");
            }
            return View(sanPham);
        }

        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult XoaSanPham(string maSp)
        {
            TempData["Message"] = "";
            var chiTietSanPham = db.TChiTietSanPhams.Where( x => x.MaSp == maSp).ToList(); 
            if(chiTietSanPham.Count() > 0)
            {
                TempData["Message"] = "Không xóa được sản phẩm này";
                return RedirectToAction("DanhMucSanPham", "HomeAdmin");
            }
            var anhSanPhams = db.TAnhSps.Where(x => x.MaSp.Equals(maSp));
            if (anhSanPhams.Any()) db.RemoveRange(anhSanPhams);
            var sanPham = db.TDanhMucSps.Find(maSp);
            TempData["Message"] = $"Đã xóa sản phẩm {sanPham.TenSp}";
            db.Remove(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucSanPham", "HomeAdmin");
        }
    }
}
