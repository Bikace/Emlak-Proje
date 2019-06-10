
using ES.Bussiness.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ES.WEB.API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class DefaultController : ApiController
    {
        AdreManager ad = new AdreManager();
        public List<string> Get()
        {
            var list = ad.GetAdrelar().Where(x => x.Il != null).Select(x => x.Il).Distinct().ToList();
            return list;
        }
        public List<string> Get(string il)
        {
            var list = ad.GetAdrelar().Where(x => x.Il == il).Select(x => x.Ilce).Distinct().ToList();
            return list;
        }
    }
}