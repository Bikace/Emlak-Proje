using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class PortfoyManager
    {
        DB Db;
        Reposity<Portfoy> repPortfoy;

        public PortfoyManager()
        {
            Db = new DB();
            repPortfoy = new Reposity<Portfoy>(Db.context);

        }

        public List<Portfoy> GetPortfoyler()
        {
            return repPortfoy.List().Where(x => x.isDeleted == false).ToList();

        }

        public Portfoy GetPortfoyById(int id)
        {
            try
            {
                return repPortfoy.List().Where(x => x.PortfoyID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int AddPortfoy(Portfoy p)
        {

            if (p.OneCikmaTarihi == DateTime.MinValue)
            {
                p.OneCikmaTarihi = DateTime.MaxValue;
            }
            var portfoy = repPortfoy.Insert(p);

            return portfoy.PortfoyID;
        }

        public void DeletePortfoy(int id)
        {
            repPortfoy.Delete(this.GetPortfoyById(id));
        }

        public void UpdatePortfoy(int id)
        {
            repPortfoy.Update(this.GetPortfoyById(id));
        }


        public int EditPortfoy(Portfoy p)
        {

            repPortfoy.Update(p);
            return p.PortfoyID;
        }

    }
}
