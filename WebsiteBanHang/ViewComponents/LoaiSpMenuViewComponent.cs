using WebsiteBanHang.Models;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Repository;

namespace WebsiteBanHang.ViewComponents
{
	public class LoaiSpMenuViewComponent: ViewComponent
	{
		private readonly ILoaiSpRepository _repository;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _repository = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaiSp = _repository.GetAll().OrderBy(x => x.Loai);
            return View(loaiSp);
        }
    }
}
