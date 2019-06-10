using ES.Admin.UI.Models;
using ES.Bussiness.Manager;
using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.Admin.UI.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.mesaj = string.Empty;
            return View();
        }

        public ActionResult Out()
        {
            Session["actPer"] = null;
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Index(string kadi,string pw)
        {   
            if (base.Login(kadi,pw))
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı Adı eya Şifreyi hatalı girdiniz.";
            }
            return View();
        }



    }
}