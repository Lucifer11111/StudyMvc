using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyMvc.Controllers
{
    public class AccountController : Controller
    {
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
            ViewBag.LoginState = email + "登录后。。。";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}