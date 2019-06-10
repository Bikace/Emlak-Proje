using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class KonutDurumManager
    {
        DB Db;
        Reposity<Data.KonutDurum> repKonutDurum;

        public KonutDurumManager()
        {
            Db = new DB();
            repKonutDurum = new Reposity<Data.KonutDurum>(Db.context);

        }

        public List<Data.KonutDurum> GetKonutDurumlar()
        {
            return repKonutDurum.List();

        }

        public void AddKonutDurum(Data.KonutDurum e)
        {

            repKonutDurum.Insert(e);
        }

        public Data.KonutDurum GetKonutDurumById(int id)
        {
            return repKonutDurum.List().Where(x => x.KonutDurumID == id).FirstOrDefault();
        }

        public void EditKonutDurum(Data.KonutDurum e)
        {
            repKonutDurum.Update(e);
        }
    }
}
