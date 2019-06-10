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
    public class BaseController : Controller
    {


        public string[] SetPage()
        {
            SetViewBagValues();
            return RolKontrol();
        }

        public void SetViewBagValues()
        {

            try
            {
                if (Session != null && Session["actPer"] != null)
                {
                    SesPer per = (SesPer)Session["actPer"];

                    ViewBag.ActPerRol = per.Rol.ToString();
                    ViewBag.ActPerName = per.Tamadi;
                    ViewBag.ActPerImg = "/Content/Template/dist/img/" + per.PersonelId + per.Tamadi.Replace(" ", "_") + ".jpg";
                }
            }
            catch (Exception ex)
            {

                //throw;
            }

        }


        public string[] RolKontrol()
        {
            string redirectUrl = Session["redirectUrl"].ToString().ToUpper();

            if (!Request.Url.AbsolutePath.ToUpper().Replace("/INDEX", "").Contains(redirectUrl.Replace("/INDEX", "")))
            {
                var redirectArr = Models.LoginControl.Allow(Session["actPer"], Request.Url.AbsolutePath, Session["redirectUrl"]);
                if (redirectArr != null)
                    Session["redirectUrl"] = "/" + redirectArr[0] + "/" + redirectArr[1];
                return redirectArr;
            }

            return null;
        }


        public bool Login(string username, string password)
        {
            var v = Session != null;
            UserManager man = new UserManager();
            PersonelManager pMan = new PersonelManager();
            int rolId;
            int? personelId = man.UserKontrol(username, password, out rolId);

            if (personelId != 0)
            {
                Personel p = pMan.GetPersonelById((int)personelId);
                Models.SesPer sesPer = new Models.SesPer(p, rolId);

                Session["actPer"] = sesPer;
                Session["redirectUrl"] = Request.Url.AbsolutePath;
                return true;
            }

            return false;
        }



    }

}