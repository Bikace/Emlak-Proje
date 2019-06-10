using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class TurManager
    {
        DB Db;
        Reposity<Tur> repTur;

        public TurManager()
        {
            Db = new DB();
            repTur = new Reposity<Tur>(Db.context);

        }

        public List<Tur> GetTurlar()
        {
            return repTur.List();

        }

        public void AddTur(Tur e)
        {

            repTur.Insert(e);
        }

        public Tur GetTurById(int id)
        {
            return repTur.List().Where(x => x.TurID == id).FirstOrDefault();
        }

        public void EditTur(Tur e)
        {
            repTur.Update(e);
        }
    }
}
