using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.Admin.UI.Controllers
{
    public class DefaultController : BaseController
    {
        public ActionResult Index()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);

            return View();
        }
    }
}