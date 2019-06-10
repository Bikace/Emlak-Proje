using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ES.WEB.API.Controllers
{

 
    public class DefaultController : ApiController
    {
       

        // GET: Default
        public string Get()
        {
            return "Selamın aleyküm";
        }
    }
}