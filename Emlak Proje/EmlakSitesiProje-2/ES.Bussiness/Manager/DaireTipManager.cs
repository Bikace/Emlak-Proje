using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Bussiness.Manager
{
    public class DaireTipManager
    {
        DB Db;
        Reposity<DaireTip> repDaireTip;

        public DaireTipManager()
        {
            Db = new DB();
            repDaireTip = new Reposity<DaireTip>(Db.context);

        }

        public List<DaireTip> GetDaireTipler()
        {
            return repDaireTip.List();

        }

        public void AddDaireTip(DaireTip e)
        {

            repDaireTip.Insert(e);
        }

        public DaireTip GetDaireTipById(int id)
        {
            return repDaireTip.List().Where(x => x.DaireTipID == id).FirstOrDefault();
        }

        public void EditDaireTip(DaireTip e)
        {
            repDaireTip.Update(e);
        }
    }
}
