using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class EmlakManager
    {
        DB Db;
        Reposity<Emlak> repEmlak;

        public EmlakManager()
        {
            Db = new DB();
            repEmlak = new Reposity<Emlak>(Db.context);

        }

        public List<Emlak> GetEmlaklar()
        {
            return repEmlak.List();
           
        }

        public int AddEmlak(Emlak e)
        {

            repEmlak.Insert(e);
            return e.EmlakID;
        }

        public Emlak GetEmlakById(int id)
        {
            return repEmlak.List().Where(x => x.EmlakID == id).FirstOrDefault();
        }

        public int EditEmlak(Emlak e)
        {
            repEmlak.Update(e);
            return e.EmlakID;
          
        }
    }
}
