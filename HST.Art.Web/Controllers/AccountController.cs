﻿using System.Web.Mvc;

namespace HST.Art.Web.Controllers
{
    public class AccountController : ApplicationBase
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (LoginBase(model.Account, model.Password))
            {
                return RedirectLogin();
            }
            else
            {
                ModelState.AddModelError("ErrorMessage", "密码或用户名错误！");
                return View(model);
            }
        }

        public ActionResult LoginOut()
        {
            LogoutBase();
            return RedirectLogin();
        }
        [AllowAnonymous]
        public ActionResult GetValidateCode()
        {
            YZMHelper yzm = new YZMHelper();
            yzm.CreateImage();
            Session["ValidateCode"] = yzm.Text;
            return File(yzm.ImageByte, @"image/jpeg");
        }

    }
}