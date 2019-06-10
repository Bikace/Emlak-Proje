using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class MusteriManager
    {
        DB Db;
        Reposity<Musteri> repMusteri;

        public MusteriManager()
        {
            Db = new DB();
            repMusteri = new Reposity<Musteri>(Db.context); 

        }

        public List<Musteri> GetMusteriler()
        {
            return repMusteri.List();
           
        }

        public int AddMusteri(Musteri m)
        {
            if (m.DogumTarihi == DateTime.MinValue)
            {
                m.DogumTarihi = DateTime.MaxValue;
            }
            repMusteri.Insert(m);
            return m.MusteriID;
        }

        public int EditMusteri(Musteri m)
        {
            if (m.DogumTarihi == DateTime.MinValue)
            {
                m.DogumTarihi = DateTime.Now;
            }
            repMusteri.Update(m);
            return m.MusteriID;
        
        }

        public Musteri GetMusteriById(int id)
        {
            return repMusteri.List().Where(x => x.MusteriID == id).FirstOrDefault();
        }



        
    }
}
