using ES.Bussiness.Manager;
using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.Admin.UI.Controllers
{
    public class MusteriController : BaseController
    {
        MusteriManager mm = new MusteriManager();
        // GET: Musteri
        public ActionResult Index()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(mm.GetMusteriler());
        }

        // GET: Musteri/Details/5
        public ActionResult Details(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // GET: Musteri/Create
        public ActionResult Create()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // POST: Musteri/Create
        [HttpPost]
        public ActionResult Create(FormCollection c)
        {
            Musteri p = new Musteri();
            p.Adi = c["Adi"];
            p.Soyadi = c["Soyadi"];
            p.TC = int.Parse(c["TC"]);
            if (!string.IsNullOrEmpty(c["DogumTarihi"]))
            {
                p.DogumTarihi = Convert.ToDateTime(c["DogumTarihi"]);
            }

            mm.AddMusteri(p);
            return RedirectToAction("Index");
        }

        // GET: Musteri/Edit/5
        public ActionResult Edit(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(mm.GetMusteriById(id));
        }

        // POST: Musteri/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection c)
        {
            int id = int.Parse(c["MusteriID"]);
            Musteri m = mm.GetMusteriById(id);
            m.Adi = c["Adi"];
            m.Soyadi = c["Soyadi"];

            if (ModelState.IsValid)
            {
                mm.EditMusteri(m);
            }

            return RedirectToAction("Index");

        }

        // GET: Musteri/Delete/5
        public ActionResult Delete(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // POST: Musteri/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
