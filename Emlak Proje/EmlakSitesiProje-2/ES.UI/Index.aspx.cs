using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.Bussiness;
namespace ES.UI
{
    public partial class Index : System.Web.UI.Page
    {
        BS bs;

        protected void Page_Load(object sender, EventArgs e)
        {
            bs = new BS();
       
            rptOneCikanlar.DataSource = bs.GetAllPortfoyler().Where(x => x.OneCikan == true).ToList().Take(8);
            rptOneCikanlar.DataBind();

           

            rptResimler.DataSource = bs.GetAllPersoneller().Take(6);
            rptResimler.DataBind();
        }
    }
}