using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Data
{
    public class DB
    {
        public EmlakSDBEntities context = new EmlakSDBEntities();

        public List<Musteri> GetMusteriler()
        {
            return context.Musteris.ToList();
        }
        public List<Personel> GetPersoneller()
        {
            return context.Personels.ToList();
        }
        public List<Portfoy> GetPortfoyler()
        {
            return context.Portfoys.ToList();
        }
        public List<Emlak> GetEmlaklar()
        {
            return context.Emlaks.ToList();
        }
        public List<Tur> GetTurler()
        {
            return context.Turs.ToList();
        }
        public List<EmlakOzellik> GetEmlakOzellikler()
        {
            return context.EmlakOzelliks.ToList();
        }

        public List<Adre> GetAdres()
        {
            return context.Adres.Distinct().ToList();
        }

        public List<DaireTip> GetDaireTipler()
        {
            return context.DaireTips.ToList();
        }

        public List<KonutDurum> GetKonutDurumlari()
        {
            var list = context.KonutDurums.ToList(); 
            return context.KonutDurums.ToList();
        }
        public List<EmlakFoto> GetEmlakFoto()
        {
            return context.EmlakFotoes.ToList();

        }



    }
}
