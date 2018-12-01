﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WXDataBLL;
using WXDataBLL.Base;
using WXDataModel;

namespace WXDataUI.Areas.Base.Controllers
{
    public class HomeController : Controller
    {
        // GET: Base/Home
        public ActionResult Index()
        {
            return Redirect("/Base/APP/Index");
        }

        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(SYS_User info)
        {
            SYS_User user = new SYS_UserManager().Login(info);
            if (user!=null)
            {
                Session.Add("SYSUSER",user);
                return Redirect("/Base/Home/Index");
            }
            return Content("false");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return Redirect("/Base/Home/Login");
        }

        public ActionResult GetFunction()
        {
            var json = new SYS_FunctionManager().GetFunction((Session["SYSUSER"] as SYS_User).UserId);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

    }
}