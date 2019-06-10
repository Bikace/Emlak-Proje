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
    public class PortfoyController : BaseController
    {
        PortfoyManager pm = new PortfoyManager();
        // GET: Portfoy
        public ActionResult Index()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            var portfoyList = pm.GetPortfoyler();

            List<PortfoyDTO> DTOList = new List<PortfoyDTO>();

            foreach (Portfoy item in portfoyList)
            {
                PortfoyDTO temp = new PortfoyDTO(item);
                DTOList.Add(temp);
            }
            return View(DTOList);
        }

        // GET: Portfoy/Details/5
        public ActionResult Details(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            return View();
        }

        // GET: Portfoy/Create
        [HttpGet]
        public ActionResult Create()
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            DaireTipManager dTipMan = new DaireTipManager();
            KonutDurumManager kDurumMan = new KonutDurumManager();
            TurManager TManager = new TurManager();
            //daire tiplerini çekmem lazım
            //bunun için daire tipi manager yaratmam lazım
            ViewBag.KonutDaireTipler = new SelectList(dTipMan.GetDaireTipler(), "DaireTipID", "Adi");
            ViewBag.KonutDurumlar = new SelectList(kDurumMan.GetKonutDurumlar(), "KonutDurumID", "Adi");
            ViewBag.KonutTur = new SelectList(TManager.GetTurlar(), "TurID", "Adi");
           
            return View();
        }

        // POST: Portfoy/Create
        [HttpPost]
        public ActionResult Create(PortfoyDTO dto)
        {
            dto.Save();
            return RedirectToAction("Index");
        }

        // GET: Portfoy/Edit/5
        public ActionResult Edit(int id)
        {
            var routeArr = base.SetPage();
            if (routeArr != null)
                return RedirectToAction(routeArr[1], routeArr[0]);
            DaireTipManager dTipMan = new DaireTipManager();
            KonutDurumManager kDurumMan = new KonutDurumManager();
            TurManager TManager = new TurManager();

            ViewBag.KonutDaireTipler = new SelectList(dTipMan.GetDaireTipler(), "DaireTipID", "Adi");
            ViewBag.KonutDurumlar = new SelectList(kDurumMan.GetKonutDurumlar(), "KonutDurumID", "Adi");
            ViewBag.KonutTur = new SelectList(TManager.GetTurlar(), "TurID", "Adi");
            var portfoy = pm.GetPortfoyById(id);

            PortfoyDTO pDTO = new PortfoyDTO(portfoy);

            return View(pDTO);

        }

        // POST: Portfoy/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection c)
        {
            int id = int.Parse(c["PortfoyID"]);
            Portfoy e = pm.GetPortfoyById(id);
            PortfoyDTO pDTO = new PortfoyDTO(e);

            if (ModelState.IsValid)
            {
                pDTO.PortfoyTakas = c["PortfoyTakas"] == "false" ? false : true;
                pDTO.PortfoyAciklamaBaslik = c["PortfoyAciklamaBaslik"];
                pDTO.PortfoyAciklama = c["PortfoyAciklama"];
                pDTO.PortfoyOneCikan = c["PortfoyOneCikan"] == "false" ? false : true;
                pDTO.MusteriAdi = c["MusteriAdi"];
                pDTO.MusteriSoyadi = c["MusteriSoyadi"];
                pDTO.EmlakDaireNo = c["EmlakDaireNo"];
                pDTO.EmlakPiyasaBedeli = double.Parse(c["EmlakPiyasaBedeli"]);
                pDTO.EmlakKiraBedeli = double.Parse(c["EmlakKiraBedeli"]);
                pDTO.EmlakAidat = double.Parse(c["EmlakAidat"]);
                pDTO.EmlakCephe = c["EmlakCephe"];
                pDTO.EmlakIsinmaSekli = c["EmlakIsinmaSekli"];
                pDTO.EmlakOtopark = c["EmlakOtopark"] == "false" ? false : true;
                pDTO.DaireTip = c["DaireTip"];
                pDTO.KonutDurum = c["KonutDurum"];
                pDTO.EmlakAdresIl = c["EmlakAdresIl"];
                pDTO.EmlakAdresKoordinat = c["EmlakAdresKoordinat"];
                pDTO.MusteriAdresIl = c["MusteriAdresIl"];
                pDTO.MusteriAdresIlce = c["MusteriAdresIlce"];
                pDTO.MusteriAdresKoordinat = c["MusteriAdresKoordinat"];

                pDTO.Update();
            }
            else
            {
                return View(pDTO);
            }

            return RedirectToAction("Index");
        }

        // GET: Portfoy/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Portfoy/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            pm = new PortfoyManager();

            pm.DeletePortfoy(id);

            return RedirectToAction("Index");
        }
    }
}
