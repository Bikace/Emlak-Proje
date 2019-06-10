using ES.Bussiness.Manager;
using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.Admin.UI.Controllers
{
    public class PersonelController : BaseController
    {
        PersonelManager pm = new PersonelManager();
        // GET: Personel
        public ActionResult Index()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(pm.GetPersoneller());
        }

        // GET: Personel/Details/5
        public ActionResult Details(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // GET: Personel/Create
        public ActionResult Create()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // POST: Personel/Create
        [HttpPost]
        public ActionResult Create(string Adi, string Soyadi,string TC, string DogumTarihi)
        {

            Personel p = new Personel();
            p.Adi = Adi;
            p.Soyadi = Soyadi;
            if (!string.IsNullOrEmpty(DogumTarihi))
            {
                p.DogumTarihi = Convert.ToDateTime(DogumTarihi);
            }

            pm.AddPersonel(p);
            return RedirectToAction("Index");

        }

        // GET: Personel/Edit/5
        public ActionResult Edit(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(pm.GetPersonelById(id));
        }

        // POST: Personel/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection c)
        {
            int id = int.Parse(c["PersonelID"]);
            Personel p = pm.GetPersonelById(id);
            p.Adi = c["Adi"];
            p.Soyadi = c["Soyadi"];

            if (ModelState.IsValid)
            {
                pm.EditPersonel(p);
            }

            return RedirectToAction("Index");
        }

        // GET: Personel/Delete/5
        public ActionResult Delete(int id)
        {
            //var routeArr = base.SetPage();
            //if (routeArr != null)
            //    return RedirectToAction(routeArr[1], routeArr[0]);
            pm.DeletePersonel(id);
            return RedirectToAction("Index");
        }

        // POST: Personel/Delete/5
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
