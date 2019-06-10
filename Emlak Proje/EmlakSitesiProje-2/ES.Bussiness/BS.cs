using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.Data;
namespace ES.Bussiness
{
    public class BS
    {
        DB db;

        public BS()
        {
            db = new DB();
        }
        public List<Data.Portfoy> GetPortfoyler(int KonutDurumId, int DairetipId, int TurId, string Il, string Ilce, double FiyatMin, double FiyatMax)
        {//todo geri dön
            //var list = GetPortfoyler().Where(x => x.FiyatMax >= FiyatMin && x.FiyaMin <= FiyatMax && !x.isDeleted).ToList();
            var list = GetPortfoyler().Where(x => x.FiyaMin >= FiyatMin && x.FiyatMax <= FiyatMax).ToList();

            if (KonutDurumId > 0)
            {
                list = list.Where(x => x.Emlak != null && x.Emlak.KonutDurum != null && x.Emlak.KonutDurum.KonutDurumID == KonutDurumId).ToList();
            }
            if (DairetipId > 0)
            {
                list = list.Where(x => x.Emlak != null && x.Emlak.DaireTip != null && x.Emlak.DaireTip.DaireTipID == DairetipId).ToList();
            }

            if (TurId > 0)
            {
                list = list.Where(x => x.Emlak != null && x.Emlak.Tur != null && x.Emlak.Tur.TurID == TurId).ToList();
            }
            if (!string.IsNullOrEmpty(Il))
            {
                list = list.Where(x => x.Emlak != null && x.Emlak.Adre != null && x.Emlak.Adre.Il == Il).ToList();
            }
            if (!string.IsNullOrEmpty(Ilce))
            {
                list = list.Where(x => x.Emlak != null && x.Emlak.Adre != null && x.Emlak.Adre.Ilce == Ilce).ToList();
            }


            return list;
        }

        public List<Data.KonutDurum> GetKonutDurumlari()
        {
            try
            {
                var list = db.GetKonutDurumlari();
                if (list.Count > 0)
                    return list;//       GetPortfoyler().Where(p => !p.isDeleted ).ToArray();
            }
            catch (Exception e)
            {
            }
            return null;
        }

        public List<Data.Portfoy> GetAllPortfoyler()
        {
            try
            {
                var list = db.GetPortfoyler();
                list = list.Where(p => p.isDeleted == false).ToList();
                if (list.Count > 0)
                    return list.Where(p => p.isDeleted == false).ToList();
            }
            catch (Exception e)
            {
            }
            return null;

        }
        public Emlak GetEmlakById(int Id)
        {
            var list = db.GetEmlaklar().Where(x => x.EmlakID == Id).FirstOrDefault();
            return list;
        }

        public List<Tur> GetTurs()
        {
            return db.GetTurler();
        }

        public List<Adre> GetAdres()
        {
            return db.GetAdres();
        }

        public List<DaireTip> GetDaireTipler()
        {
            return db.GetDaireTipler();
        }

        public List<Personel> GetAllPersoneller()
        {
            return db.GetPersoneller();
        }

        public List<Portfoy> GetPortfoysByKonutDurumDaireTip(int daireTip, int konutDurum)
        {
            var port = GetPortfoyler().ToList();
            if (konutDurum > 0 || daireTip > 0)
            {
                if (konutDurum > 0)
                {
                    port = port.Where(x => x.Emlak.KonutDurum != null && x.Emlak.KonutDurum.KonutDurumID == konutDurum).ToList();

                }
                if (daireTip > 0)
                {
                    port = port.Where(x => x.Emlak.DaireTip != null && x.Emlak.DaireTip.DaireTipID == daireTip).ToList();
                }
                return port;
            }
            return null;

        }

        public List<Portfoy> GetPortfoysByPersonelID(int Id)
        {
            var port = GetPortfoyler().Where(x => x.Personeli_PersonelID == Id).ToList();
            return port;
        }

        public List<Portfoy> GetPortfoysByKonutDurum(int id)
        {
            var port = GetPortfoyler().Where(x => x.Emlak != null && x.Emlak.KonutDurum != null && x.Emlak.KonutDurum.KonutDurumID == id).ToList();
            return port;
        }

        public List<Portfoy> GetPortfoyler()
        {
            //return db.GetPortfoyler().ToList();
            //return db.GetPortfoyler().OrderBy(o => o.OneCikan).ThenBy(o => o.OneCikmaTarihi).ToList();
            var list = db.GetPortfoyler().OrderByDescending(x => x.OneCikmaTarihi).ThenBy(x => x.CreateDate).ToList();
            //list = list.Where(x => x.OneCikan == false).OrderByDescending(x => x.CreateDate).ToList();
        
            return list;
        }

        public List<Portfoy> GetPortfoysByKonutDurumVeTur(int konutdurumid, int turid)
        {
            var port = GetPortfoyler().ToList();
            if (konutdurumid > 0 || turid > 0)
            {
                if (konutdurumid > 0)
                {
                    port = port.Where(x => x.Emlak != null && x.Emlak.KonutDurum != null && (x.Emlak.KonutDurum.KonutDurumID == konutdurumid || x.Emlak.KonutDurum.KonutDurumID == 3)).ToList();

                }
                if (turid > 0)
                {
                    port = port.Where(x => x.Emlak != null && x.Emlak.Tur != null && x.Emlak.Tur.TurID == turid).ToList();

                }
                return port;

            }
            return null;
        }

        public List<Portfoy> GetPortfoysByTur(int id)
        {
            var port = GetPortfoyler().Where(x => x.Emlak.Tur != null && x.Emlak.Tur.TurID == id).ToList();
            return port;
        }

        public List<Portfoy> GetPortfoysByTur(params int[] idArr)
        {
            List<Portfoy> returnList = new List<Portfoy>();
            List<Portfoy> port;

            foreach (var id in idArr)
            {
                port = GetPortfoyler().Where(x => x.Emlak != null && x.Emlak.Tur != null && x.Emlak.Tur.TurID == id).ToList();
                returnList.AddRange(port);
            }

            return returnList;
        }

        public List<Portfoy> GetPortfoysByIlIlce(string Il, string Ilce)
        {
            var port = new List<Portfoy>();
            if (string.IsNullOrEmpty(Il) == false)
            {
                port = GetPortfoyler().Where(x => x.Emlak.Adre.Il == Il).ToList();

                if (!string.IsNullOrEmpty(Ilce))
                {
                    port = port.Where(x => x.Emlak.Adre.Ilce == Ilce).ToList();

                }

            }
            return port;
        }

        public Portfoy GetPortfoyById(int Id)
        {
            var port = db.GetPortfoyler().Where(x => x.PortfoyID == Id).FirstOrDefault();
            return port;
        }

        public EmlakOzellik GetEmlakOzellikById(int Id)
        {
            var port = db.GetEmlakOzellikler().Where(x => x.Emlak_EmlakID == Id).FirstOrDefault();
            return port;
        }

        public List<Portfoy> GetUcYuzTLFiyat(double fiyat, int Turid)
        {
            var f = GetPortfoyler().Where(x => x.Emlak.PiyasaBedeli <= fiyat && x.Emlak.Turu_TurID == Turid).ToList();
            return f;
        }

        public List<Portfoy> OkulaYakin(int konutDurum, int Turid)
        {

            List<int?> okulaYakinEmlakIDs = db.GetEmlakOzellikler().Where(e => e.OkulaYakin).Select(s => s.Emlak_EmlakID).ToList();


            var portfoyList = db.GetPortfoyler().Where(p => okulaYakinEmlakIDs.Any(i => i == p.Emlaki_EmlakID)).ToList();



            return portfoyList;
        }

        public List<EmlakFoto> GetAllEmlakFoto()
        {

            return db.GetEmlakFoto();
        }


    }
}
