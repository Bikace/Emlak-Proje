using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.Bussiness;

namespace ES.UI
{
    public partial class Detay : System.Web.UI.Page
    {
        int emlakId;
        //int FiyatMax;
        BS bs;
        protected void Page_Load(object sender, EventArgs e)
        {
            bs = new BS();

            if (Request.QueryString["Id"] != null)
                int.TryParse(Request.QueryString["Id"], out emlakId);
            else
            {
                Response.Redirect("404Detay.aspx?");
            }

            var portfoy = bs.GetPortfoyById(emlakId);
            var emlakOzellik = bs.GetEmlakOzellikById(emlakId);

            var pf = bs.GetPortfoyById(emlakId);
            var crsllist = bs.GetAllEmlakFoto().Where(x => x.Emlak_EmlakID == pf.Emlaki_EmlakID).ToList().Take(1);
            

            rptCarouselBuyukFotograf.DataSource = crsllist;
            rptCarouselBuyukFotograf.DataBind();

            rptCarouselKucukFotograf.DataSource = bs.GetAllEmlakFoto().Where(x => x.Emlak_EmlakID == pf.Emlaki_EmlakID).ToList();
            rptCarouselKucukFotograf.DataBind();

            lblaciklama.Text = portfoy.AciklamaBaslik;
            lblodaSayisi.Text = portfoy.Emlak.DaireTip.Adi!=null ? portfoy.Emlak.DaireTip.Adi:"-";
            lblFiyatMax.Text = portfoy.FiyatMax.ToString();
            lblMetreKare.Text = portfoy.Emlak.NetMetrekare.ToString();
            lblKatSayisi.Text = portfoy.Emlak.KatSayisi.ToString();
            lblIlanNo.Text = portfoy.PortfoyID.ToString();
            lblkonutDurumu.Text = portfoy.Emlak.KonutDurum.Adi;
            lblbrutMetrekare.Text = portfoy.Emlak.BrutMetrekare.ToString();
            lblbanyoSayisi.Text = portfoy.Emlak.BanyoSayisi.ToString();
            lblwcsayisi.Text = portfoy.Emlak.BanyoSayisi.ToString();
            lblpersonel.Text = (portfoy.Personel.Adi + " " + portfoy.Personel.Soyadi);
            //if (emlakOzellik.CaddeyeYakin)
            //    lblcaddeyeYakin.Text = "Caddeye Yakın";
            lbldepozito.Text = portfoy.Depozito.ToString();
            lblodaSayisi2.Text = portfoy.Emlak.DaireTip.Adi;
            lblMetreKare2.Text = portfoy.Emlak.NetMetrekare.ToString();
            lblbinaYasi.Text = portfoy.Emlak.BinaYasi.ToString();
            lblkatSayisi2.Text = portfoy.Emlak.KatSayisi.ToString();
            lblIl.Text = portfoy.Emlak.Adre.Il;
            lblIlce.Text = portfoy.Emlak.Adre.Ilce;
            lblKonutDurum2.Text = portfoy.Emlak.KonutDurum.Adi;

            lblAciklama2.Text = portfoy.Aciklama;

            lblTur.Text = portfoy.Emlak.Tur.Adi;
            linkTur.PostBackUrl = "~/Liste.aspx?turid=" + portfoy.Emlak.Tur.TurID;

            lblKonutDurum2.Text = portfoy.Emlak.KonutDurum.Adi;
            linkKonutDurum.PostBackUrl = "~/Liste.aspx?konutdurum=" + portfoy.Emlak.KonutDurum.KonutDurumID;

            lblIl.Text = portfoy.Emlak.Adre.Il;
            linkIl.PostBackUrl = "~/Liste.aspx?Il=" + portfoy.Emlak.Adre.Il;

            lblIlce.Text = portfoy.Emlak.Adre.Ilce;
            linkIlce.PostBackUrl = "~/Liste.aspx?Ilce=" + portfoy.Emlak.Adre.Ilce;

            linkPersonel.PostBackUrl = "~/Liste.aspx?personelid=" + portfoy.Personel.PersonelID;

            linkEmlakcininTumIlanlari.PostBackUrl = "~/Liste.aspx?personelid=" + portfoy.Personel.PersonelID;

            string yesilTik = "assets\\Images\\tik.png";
            string griTik = "assets\\Images\\tikGri.png";


            if (emlakOzellik != null)
            {
                imgAcikBalkon.ImageUrl = emlakOzellik.AcikBalkon ? yesilTik : griTik;
                imgCelikKapi.ImageUrl = emlakOzellik.CelikKapi ? yesilTik : griTik;
                imgDolaplıMutfak.ImageUrl = emlakOzellik.DolaplıMutfak ? yesilTik : griTik;
                imgDusakabin.ImageUrl = emlakOzellik.Dusakabin ? yesilTik : griTik;
                imgFransizBalkon.ImageUrl = emlakOzellik.FransizBalkon ? yesilTik : griTik;
                imgKapaliBalkon.ImageUrl = emlakOzellik.KapaliBalkon ? yesilTik : griTik;
                imgKartonpiyer.ImageUrl = emlakOzellik.Kartonpiyer ? yesilTik : griTik;
                imgLaminant.ImageUrl = emlakOzellik.Laminant ? yesilTik : griTik;
                imgOcakDogalgazi.ImageUrl = emlakOzellik.OcakDogalgazi ? yesilTik : griTik;
                imgSeramikZemin.ImageUrl = emlakOzellik.SeramikZemin ? yesilTik : griTik;
                imgSicakSu.ImageUrl = emlakOzellik.SicakSu ? yesilTik : griTik;
                imgAsansor.ImageUrl = emlakOzellik.Asansor ? yesilTik : griTik;
                imgGuneyCepheli.ImageUrl = emlakOzellik.GuneyCepheli ? yesilTik : griTik;
                imgHidrofor.ImageUrl = emlakOzellik.Hidrafor ? yesilTik : griTik;
                imgısıYalıtım.ImageUrl = emlakOzellik.IsiYalitimi ? yesilTik : griTik;
                imgcaddeYakin.ImageUrl = emlakOzellik.CaddeyeYakin ? yesilTik : griTik;
                imgdolmus.ImageUrl = emlakOzellik.Dolmus ? yesilTik : griTik;
                imgokulaYakin.ImageUrl = emlakOzellik.OkulaYakin ? yesilTik : griTik;

            }
            else
            {
                imgAsansor.ImageUrl = griTik;
                imgGuneyCepheli.ImageUrl = griTik;
                imgHidrofor.ImageUrl = griTik;
                imgısıYalıtım.ImageUrl = griTik;
                imgAcikBalkon.ImageUrl = griTik;
                imgCelikKapi.ImageUrl = griTik;
                imgDolaplıMutfak.ImageUrl = griTik;
                imgDusakabin.ImageUrl = griTik;
                imgFransizBalkon.ImageUrl = griTik;
                imgKapaliBalkon.ImageUrl = griTik;
                imgKartonpiyer.ImageUrl = griTik;
                imgLaminant.ImageUrl = griTik;
                imgOcakDogalgazi.ImageUrl = griTik;
                imgSeramikZemin.ImageUrl = griTik;
                imgSicakSu.ImageUrl = griTik;
                imgcaddeYakin.ImageUrl = griTik;
                imgdolmus.ImageUrl = griTik;
                imgokulaYakin.ImageUrl = griTik;
            }

            //int id = int.Parse(Request.QueryString["id"]);
            //Repeater1.DataSource = bs.GetPortfoyById(id);
            //Repeater1.DataBind();

        }
    }
}