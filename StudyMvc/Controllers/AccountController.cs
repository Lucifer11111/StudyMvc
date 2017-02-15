using StudyMvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyMvc.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前。。。";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            //获取信息
            var email = form["inputEmail3"];
            var password = form["inputPassword3"];

            //进行下一步处理，这里修改显示文字
            var user = db.SysUsers.Where(it => it.Email == email & it.Password == password).ToList();

            if (user.Count() > 0)
            {
                ViewBag.LoginState = email + "登录后。。。";
            }
            else
            {
                ViewBag.LoginState = email + "用户不存在。。。";
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}