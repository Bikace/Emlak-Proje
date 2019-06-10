using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class UserManager
    {
        DB Db;
        Reposity<User> repUser;

        public UserManager()
        {
            Db = new DB();
            repUser = new Reposity<User>(Db.context);
        }
        public List<User> GetUsers()
        {
            return repUser.List();

        }

        public int? UserKontrol(string kAdi,string sf, out int rolId)
        {
            rolId = 0;
            try
            {
                var user =this.GetUsers().Where(x => x.KullaniciAdi == kAdi && x.Sifre == sf).FirstOrDefault();
                if (user != null)
                {
                    if (user.RolID != null)
                    {
                        rolId = (int)user.RolID;
                        return user.PersonelID;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return 0;
        }
        public int AddKullanici(User u)
        {
            repUser.Insert(u);
            return u.ID;
        }

    }
}
