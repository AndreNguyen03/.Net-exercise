using WebsiteBanHang.Models;

namespace WebsiteBanHang.Repository
{
	public class LoaiSpRepository : ILoaiSpRepository
	{
		private readonly QlbanVaLiContext _context;
        public LoaiSpRepository(QlbanVaLiContext context)
        {
			_context = context;
        }
        public TLoaiSp Add(TLoaiSp loaiSp)
		{
			_context.TLoaiSps.Add(loaiSp);
			_context.SaveChanges();
			return loaiSp;
		}

		public TLoaiSp Delete(string maLoaiSp)
		{
			throw new NotImplementedException();
		}

		public TLoaiSp Get(string maLoaiSp)
		{
			return _context.TLoaiSps.Find(maLoaiSp);
		}

		public IEnumerable<TLoaiSp> GetAll()
		{
			return _context.TLoaiSps;
		}

		public TLoaiSp Update(TLoaiSp loaiSp)
		{
			_context.Update(loaiSp);
			_context.SaveChanges();
			return loaiSp;
		}
	}
}
