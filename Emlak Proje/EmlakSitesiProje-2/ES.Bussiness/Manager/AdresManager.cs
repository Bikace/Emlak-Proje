using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class AdreManager
    {
        DB Db;
        Reposity<Adre> repAdre;

        public AdreManager()
        {
            Db = new DB();
            repAdre = new Reposity<Adre>(Db.context);
        }

        public List<Adre> GetAdrelar()
        {
            return repAdre.List();
        }

        public int AddAdre(Adre e)
        {
            repAdre.Insert(e);
            return e.AdresID;
        }

        public int EditAdre(Adre e)
        {
            repAdre.Update(e);
            return e.AdresID;
            
        }

        public Adre GetAdreById(int id)
        {
            return repAdre.List().Where(x => x.AdresID == id).FirstOrDefault();
        }

    
    }
}
