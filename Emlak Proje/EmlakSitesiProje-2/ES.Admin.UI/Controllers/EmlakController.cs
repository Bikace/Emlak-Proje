using ES.Bussiness.Manager;
using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.Admin.UI.Controllers
{
    public class EmlakController : BaseController
    {
        EmlakManager em = new EmlakManager();
        // GET: Emlak
        public ActionResult Index()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(em.GetEmlaklar());
        }

        // GET: Emlak/Details/5
        public ActionResult Details(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // GET: Emlak/Create
        public ActionResult Create()
        {
            DaireTipManager dTipMan = new DaireTipManager();
            KonutDurumManager kDurumMan = new KonutDurumManager();
            TurManager TManager = new TurManager();
            ViewBag.KonutDaireTipler = new SelectList(dTipMan.GetDaireTipler(), "DaireTipID", "Adi");
            ViewBag.KonutDurumlar = new SelectList(kDurumMan.GetKonutDurumlar(), "KonutDurumID", "Adi");
            ViewBag.KonutTur = new SelectList(TManager.GetTurlar(), "TurID", "Adi");
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // POST: Emlak/Create
        [HttpPost]
        public ActionResult Create(FormCollection c)
        {
            Adre a = new Adre();
            Emlak e = new Emlak();
            a.Il = c["Adre.Il"];
            //adres manager kullanarak adresi veritabanında oluşturacağız.
            AdreManager adm = new AdreManager();
            //oluşturma metodu bize oluşan kaydın id sini getirecek.
            int adresId = adm.AddAdre(a);
            //
            //manager yaratma metodunu burada kullan
            e.Adresi_AdresID = adresId;
            
            e.KatNumarasi = c["KatNumarasi"] != null ? int.Parse(c["KatNumarasi"]) : 0; 
            e.DaireNo = c["DaireNo"];
            e.BrutMetrekare = int.Parse(c["BrutMetrekare"]);
            e.NetMetrekare = int.Parse(c["NetMetrekare"]);
            e.BanyoSayisi = int.Parse(c["BanyoSayisi"]);
            e.PiyasaBedeli = int.Parse(c["PiyasaBedeli"]);
            e.KiraBedeli = double.Parse(c["KiraBedeli"]);
            e.Aidat = double.Parse(c["Aidat"]);
            e.BinaYasi = int.Parse(c["BinaYasi"]);
            e.KatSayisi = int.Parse(c["KatSayisi"]);
            e.Cephe = c["Cephe"];
            e.IsinmaSekli = c["IsinmaSekli"];
            e.Adresi_AdresID = adresId;
            e.Dairetipi_DaireTipID = int.Parse(c["Dairetipi_DaireTipID"]);
            e.Durumu_KonutDurumID = int.Parse(c["Durumu_KonutDurumID"]);
            //e.Otopark = c["Otopark"];
            em.AddEmlak(e);
            return RedirectToAction("Index");

        }

        // GET: Emlak/Edit/5
        public ActionResult Edit(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View(em.GetEmlakById(id));
        }

        // POST: Emlak/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection c)
        {
            int id = int.Parse(c["EmlakID"]);
            Emlak e = em.GetEmlakById(id);
            e.KatNumarasi = int.Parse(c["KatNumarasi"]);
            e.DaireNo = c["DaireNo"];
            e.BrutMetrekare = int.Parse(c["BrutMetrekare"]);
            e.NetMetrekare = int.Parse(c["NetMetrekare"]);
            e.BanyoSayisi = int.Parse(c["BanyoSayisi"]);
            e.PiyasaBedeli = int.Parse(c["PiyasaBedeli"]);
            e.KiraBedeli = int.Parse(c["KiraBedeli"]);
            e.Aidat = int.Parse(c["Aidat"]);
            e.BinaYasi = int.Parse(c["BinaYasi"]);
            e.KatSayisi = int.Parse(c["KatSayisi"]);
            e.Cephe = c["Cephe"];
            e.IsinmaSekli = c["IsınmaSekli"];
            e.Otopark = c["Otopark"] == "false" ? false : true;


            if (ModelState.IsValid)
            {
                em.EditEmlak(e);
            }

            return RedirectToAction("Index");
        }

        // GET: Emlak/Delete/5
        public ActionResult Delete(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // POST: Emlak/Delete/5
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
