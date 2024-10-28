using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class AccessController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("UserName")==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }

        [HttpPost]
        public IActionResult Login(TUser user)
        {
            if(HttpContext.Session.GetString("UserName")==null)
            {
                var getUser = db.TUsers.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password))
                                        .FirstOrDefault();
                if(getUser != null)
                {
                    HttpContext.Session.SetString("UserName", getUser.Username.ToString());
                    if(getUser.LoaiUser == 0)
                    {
                        return RedirectToAction("Index", "Home");
                    } else if (getUser.LoaiUser == 1)
                    {
                        return RedirectToAction("Index", "HomeAdmin", new { area = "Admin" });
                    }
                }
            }
            return View();
        }
        

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(TUser user)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var getUser = db.TUsers.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password))
                                        .FirstOrDefault();
                if (getUser == null)
                {
                    user.LoaiUser = 0;
                    db.TUsers.Add(user);
                    db.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Access");
        }
    }
}
