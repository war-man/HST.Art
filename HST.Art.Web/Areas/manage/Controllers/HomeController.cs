﻿using HST.Art.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using HST.Art.Service;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class HomeController : ApplicationBase
    {
        OrganizationService orgService = new OrganizationService();
        // GET: Home
        public ActionResult Index()
        {
            Account account = GetAccount();

            return View(account);
        }
        public ActionResult welcome()
        {
            return View();

        }

        public ActionResult Edit()
        {
            Organization model = orgService.GetByNumber(Constant.INIT_ORG_NUMBER);
            return View();
        }

        public JsonResult SearchLog(string SearchDate)
        {
            if (string.IsNullOrEmpty(SearchDate)) return Json("", JsonRequestBehavior.AllowGet);
            string fileName = SearchDate.Replace("-", "") + ".txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + "log\\";
            if (!Directory.Exists(path)) return Json("", JsonRequestBehavior.AllowGet);
            FileInfo fi = new FileInfo(path + fileName);
            if (!fi.Exists) return Json("", JsonRequestBehavior.AllowGet);

            LogViewModel model = new LogViewModel();
            model.SearchDate = SearchDate;
            model.FileCount = 1;
            model.DownloadUrl = @"\log\" + fileName;

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FileResult DownloadFile(string SearchDate)
        {
            string fileName = SearchDate.Replace("-", "") + ".txt";
            string downFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\log\" + fileName;
            FileStream fs = new FileStream(downFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            return File(fs, "text/plain", Url.Encode(fileName));
        }
    }
}
