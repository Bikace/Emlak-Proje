using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.Bussiness;

namespace ES.UI
{
    public partial class Liste : System.Web.UI.Page
    {
        BS bs = new BS();

        int KonutDurumId;
        int DairetipId;
        int TurId;
        string Il = string.Empty;
        string Ilce = string.Empty;
        double FiyatMin;
        double FiyatMax;

        protected void Page_Load(object sender, EventArgs e)
        {

            PortfoyBilgisi();
            lblPortfoy.Text = "Hiç bir veri dönmedi aslan :D";
            lblPortfoy.Visible = false;

            if (!IsPostBack)
            {
                try
                {
                    //ListItem l = new ListItem("Seçiniz", "0", true);
                    //ddIl.DataSource = bs.GetAdres();
                    //ddIl.DataTextField = "Il";
                    //ddIl.DataValueField = "Il";
                    //ddIl.DataBind();
                    //ddIl.Items.Insert(0, l);

                    //ListItem l1 = new ListItem("Seçiniz", "0", true);
                    //ddIlce.DataSource = bs.GetAdres();
                    //ddIlce.DataTextField = "Ilce";
                    //ddIlce.DataValueField = "Ilce";
                    //ddIlce.DataBind();
                    //ddIlce.Items.Insert(0, l);

                    ListItem l2 = new ListItem("Daire Tipleri", "0", true);
                    ddKonutDurum.DataSource = bs.GetKonutDurumlari();
                    ddKonutDurum.DataTextField = "Adi";
                    ddKonutDurum.DataValueField = "KonutDurumID";
                    ddKonutDurum.DataBind();
                    ddKonutDurum.Items.Insert(0, l2);
                }
                catch
                {
                    Response.Write("Bir hata olustu");
                }

                if (PersonelKontrol())
                    return;

                if (IlIlceKontrol())
                    return;

                if (KonutdurumVeTurKontrol())
                    return;

                if (DaireTipVeKonutDurumKontrol())
                    return;

                if (UcYuzTLFiyat())
                    return;

                if (OkulaYakinGetir())
                    return;

                //if (KonutdurumKontrol())
                //    return;

                //if (TurKontrol())
                //    return

                //if (PortfoyKontrol())
                //    return;



                SetPortfoysMain();


            }

        }

        public void PortfoyBilgisi()
        {
            var PBKira = bs.GetPortfoysByKonutDurum(1);//l.Where(x => x.Emlak != null && x.Emlak.KonutDurum != null && x.Emlak.KonutDurum.KonutDurumID == 1).ToList();
            lblkiralikKonutSayisi.Text = PBKira.Count().ToString();

            var PBSatilik = bs.GetPortfoysByKonutDurum(2);
            lblsatilikKonutSayisi.Text = PBSatilik.Count().ToString();

            var PBToplam = bs.GetAllPortfoyler();
            lbltoplamIlanSayisi.Text = PBToplam.Count().ToString();

            var PBkonutAdedi = bs.GetPortfoysByTur(1, 2, 4, 5);
            lblKonutAdedi.Text = PBkonutAdedi.Count().ToString();

            var PBOfisAdedi = bs.GetPortfoysByTur(2);
            lblOfisAdedi.Text = PBOfisAdedi.Count().ToString();

        }



        protected void btnAra_Click(object sender, EventArgs e)
        {
            SetPortfoysMain();
        }

        public void SetPortfoysMain()
        {
            string ara = txtAra.Text;
            KonutDurumId = int.Parse(ddKonutDurum.SelectedValue);

            DairetipId = int.Parse(ddDaireTipi.SelectedValue);
            //if (Request.QueryString["DaireTipID"] != null)
            //    int.TryParse(Request.QueryString["DaireTipID"], out DairetipId);
            Il = hdn_il.Value != "0" ? hdn_il.Value : string.Empty;
            Ilce = hdn_ilce.Value != "0" ? hdn_ilce.Value : string.Empty;

            double.TryParse(txtMinFiyat.Text, out FiyatMin);
            FiyatMax = !string.IsNullOrEmpty(txtMaxFiyat.Text) ? int.Parse(txtMaxFiyat.Text) : double.MaxValue;

            var list = bs.GetPortfoyler(KonutDurumId, DairetipId, TurId, Il, Ilce, FiyatMin, FiyatMax);

            if (ara != null)
            {
                string[] araDizi = ara.ToLower().Split(' ');

                foreach (var item in araDizi)
                {
                    list = list.Where(x => x.Aciklama != null && x.AciklamaBaslik != null && (x.Aciklama.ToLower().Contains(item) || x.AciklamaBaslik.ToLower().Contains(item))).ToList();
                }
            }


            rptPortfoy.DataSource = list;
            rptPortfoy.DataBind();
        }

        //public bool PortfoyKontrol()
        //{
            
        //        lblPortfoy.Visible = true;
        //        lblPortfoy.Text = "Hiç bir veri dönmedi aslan :D";
        //        return true;
     
        //}

        public bool KonutdurumVeTurKontrol()
        {
            if (Request.QueryString["konutDurum"] != null || Request.QueryString["tur"] != null)
            {
                int.TryParse(Request.QueryString["konutDurum"], out KonutDurumId);
                int.TryParse(Request.QueryString["tur"], out TurId);
                var personelportfoy = bs.GetPortfoysByKonutDurumVeTur(KonutDurumId, TurId);
                if (personelportfoy.Count > 0)
                {
                    
                    rptPortfoy.DataSource = personelportfoy;
                    rptPortfoy.DataBind();

                }
                else
                {
                    lblPortfoy.Visible = true;
                }
                return true;
            }
            return false;
        }

        public bool FiyatArtanAzalanKontrol()
        {
            if (Request.QueryString["konutDurum"] != null || Request.QueryString["tur"] != null)
            {
                int.TryParse(Request.QueryString["konutDurum"], out KonutDurumId);
                int.TryParse(Request.QueryString["tur"], out TurId);
                var personelportfoy = bs.GetPortfoysByKonutDurumVeTur(KonutDurumId, TurId);
                if (personelportfoy.Count > 0)
                {
                    rptPortfoy.DataSource = personelportfoy;
                    rptPortfoy.DataBind();

                }
                return true;
            }
            return false;
        }

        public bool KonutdurumKontrol()
        {
            if (Request.QueryString["konutDurum"] != null)
            {
                int personel = int.Parse(Request.QueryString["konutDurum"]);
                var personelportfoy = bs.GetPortfoysByKonutDurum(personel);
                if (personelportfoy.Count > 0)
                {
                    rptPortfoy.DataSource = personelportfoy;
                    rptPortfoy.DataBind();
                    return true;
                }
            }
            return false;
        }

        public bool TurKontrol()
        {
            if (Request.QueryString["turid"] != null)
            {
                int personel = int.Parse(Request.QueryString["turid"]);
                var personelportfoy = bs.GetPortfoysByTur(personel);
                if (personelportfoy.Count > 0)
                {
                    rptPortfoy.DataSource = personelportfoy;
                    rptPortfoy.DataBind();
                    return true;
                }
            }
            return false;
        }

        public bool PersonelKontrol()
        {
            if (Request.QueryString["personelid"] != null)
            {
                int personel = int.Parse(Request.QueryString["personelid"]);
                var personelportfoy = bs.GetPortfoysByPersonelID(personel);
                if (personelportfoy.Count > 0)
                {
                    rptPortfoy.DataSource = personelportfoy;
                    rptPortfoy.DataBind();
                }
                return true;
            }
            return false;
        }

        public bool DaireTipVeKonutDurumKontrol()
        {
            if (Request.QueryString["konutDurumID"] != null || Request.QueryString["DaireTipID"] != null)
            {
                int.TryParse(Request.QueryString["DaireTipID"], out DairetipId);
                int.TryParse(Request.QueryString["konutDurumID"], out KonutDurumId);
                var ListPortfoy = bs.GetPortfoysByKonutDurumDaireTip(DairetipId, KonutDurumId);
                if (ListPortfoy.Count > 0)
                {
                    rptPortfoy.DataSource = ListPortfoy;
                    rptPortfoy.DataBind();
                }
                else
                {
                    lblPortfoy.Visible = true;
                }
                return true;
            }
            return false;
        }

        public bool UcYuzTLFiyat()
        {
            if (Request.QueryString["Max"] != null || Request.QueryString["Daire"] != null)
            {
                double.TryParse(Request.QueryString["Max"], out FiyatMax);
                int.TryParse(Request.QueryString["Daire"], out TurId);
                var ListPortfoy = bs.GetUcYuzTLFiyat(FiyatMax, TurId);
                if (ListPortfoy.Count > 0)
                {
                    rptPortfoy.DataSource = ListPortfoy;
                    rptPortfoy.DataBind();
                }
                return true;
            }
            return false;
        }

        public bool OkulaYakinGetir()
        {
            if (Request.QueryString["KonutEv"] != null || Request.QueryString["KonutTur"] != null)
            {
                int.TryParse(Request.QueryString["KonutEv"], out KonutDurumId);
                int.TryParse(Request.QueryString["KonutTur"], out TurId);
                var ListPortfoy = bs.OkulaYakin(KonutDurumId, TurId);
                if (ListPortfoy.Count > 0)
                {
                    rptPortfoy.DataSource = ListPortfoy;
                    rptPortfoy.DataBind();
                }
                return true;
            }
            return false;
        }

        public bool IlIlceKontrol()
        {
            if (Request.QueryString["Il"] != null)
            {
                Il = Request.QueryString["Il"].ToString();

                if (Request.QueryString["Ilce"] != null)
                {
                    Ilce = Request.QueryString["Ilce"].ToString();
                }
                var ListPortfoy = bs.GetPortfoysByIlIlce(Il, Ilce);
                if (ListPortfoy.Count > 0)
                {
                    lblPortfoy.Visible = false;
                    rptPortfoy.DataSource = ListPortfoy;

                    rptPortfoy.DataBind();
                }
                return true;
            }
            return false;
        }

        protected void ddIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddIlce.DataSource = bs.GetAdres();
            ddIlce.DataBind();

            var Ildegis = ddIl.SelectedItem.ToString();
            var ilceler = bs.GetAdres().Where(x => x.Il == Ildegis).Select(x => x.Ilce).ToList();

            ddIlce.DataSource = ilceler;
            ddIlce.DataBind();
        }

        protected void ddFiyatArtanAzalan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var list = bs.GetAllPortfoyler();
                if (ddFiyatArtanAzalan.SelectedIndex == 1)
                {
                    list = list.OrderByDescending(x => x.FiyatMax).ToList();
                }
                if (ddFiyatArtanAzalan.SelectedIndex == 2)
                {
                    list = list.OrderBy(x => x.FiyatMax).ToList();
                }


                rptPortfoy.DataSource = list;
                rptPortfoy.DataBind();
                Utils.LogTut("Fiyat Artan Azalan", System.Reflection.MethodBase.GetCurrentMethod().Name, "Başarılı", LogDurum.Succes);

            }
            catch (Exception ex)
            {
                Utils.LogTut("Fiyat Artan Azalan", System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString() + "başarısız", LogDurum.Error);

            }

        }

        protected void ddTariheGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                var list = bs.GetAllPortfoyler();
                if (ddTariheGore.SelectedIndex == 1)
                {
                    list = list.OrderByDescending(x => x.CreateDate).ToList();
                }
                if (ddTariheGore.SelectedIndex == 2)
                {
                    list = list.OrderBy(x => x.CreateDate).ToList();
                }
                rptPortfoy.DataSource = list;
                rptPortfoy.DataBind();
                Utils.LogTut("Tarihe Gore Sırala", System.Reflection.MethodBase.GetCurrentMethod().Name, "Başarılı", LogDurum.Succes);

            }
            catch (Exception ex)
            {
                Utils.LogTut("Tarihe Göre sırala", System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), LogDurum.Succes);

                throw;
            }



        }


        protected void txtMaxFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
