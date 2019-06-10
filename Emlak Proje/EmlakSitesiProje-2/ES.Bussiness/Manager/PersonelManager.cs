using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class PersonelManager
    {
        DB Db;
        Reposity<Personel> repPersonel;
        Reposity<User> repUser;

        public PersonelManager()
        {
            Db = new DB();
            repPersonel = new Reposity<Personel>(Db.context);
            repUser = new Reposity<User>(Db.context);

        }

        public List<Personel> GetPersoneller()
        {
            return repPersonel.List().Where(x => x.isDeleted == false).ToList();
           
        }

        public Personel GetPersonelById(int id)
        {
            try
            {
                return repPersonel.List().Where(x => x.PersonelID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

        
        }

        public void EditPersonel(Personel p)
        {
            repPersonel.Update(p);
        }

        public void DeletePersonel(int id)
        {
            repPersonel.Delete(this.GetPersonelById(id));
        }


        public void AddPersonel(Personel p)
        {
            
            p.AktifMi = true;
            if (p.DogumTarihi == DateTime.MaxValue)
            {
                p.DogumTarihi = DateTime.MaxValue;
            }
            
            repPersonel.Insert(p);
           
            User u = new User();
            u.KullaniciAdi = p.Adi;
            u.Sifre = p.TC+p.Soyadi;

            repUser.Insert(u);
        }
    }
}
