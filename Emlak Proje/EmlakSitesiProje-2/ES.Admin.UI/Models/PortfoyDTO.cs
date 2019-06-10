using ES.Bussiness.Manager;
using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES.Admin.UI.Models
{
    public class PortfoyDTO
    {
        public int PortfoyID { get; set; }
        public int PortfoyFiyatMax { get; set; }
        public int PortfoyFiyatMin { get; set; }
        public int PortfoyDepozito { get; set; }
        public bool PortfoyTakas { get; set; }
        public string PortfoyAciklamaBaslik { get; set; }
        public string PortfoyAciklama { get; set; }
        public bool PortfoyOneCikan { get; set; }
        public System.DateTime? PortfoyUpdateDate { get; set; }
        public System.DateTime? PortfoyDeleteDate { get; set; }
        public System.DateTime? PortfoyCreateDate { get; set; }



        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public int MusteriTC { get; set; }
        public System.DateTime? MusteriUpdateDate { get; set; }
        public System.DateTime? MusteriDeleteDate { get; set; }
        public System.DateTime? MusteriCreateDate { get; set; }



        public int EmlakID { get; set; }
        public int EmlakKatNumarasi { get; set; }
        public string EmlakDaireNo { get; set; }
        public int EmlakBrutMetrekare { get; set; }
        public int EmlakNetMetrekare { get; set; }
        public int EmlakBanyoSayisi { get; set; }
        public double EmlakPiyasaBedeli { get; set; }
        public double EmlakKiraBedeli { get; set; }
        public double EmlakAidat { get; set; }
        public int EmlakBinaYasi { get; set; }
        public int EmlakKatSayisi { get; set; }
        public string EmlakCephe { get; set; }
        public string EmlakIsinmaSekli { get; set; }
        public bool EmlakOtopark { get; set; }
        public System.DateTime? EmlakUpdateDate { get; set; }
        public System.DateTime? EmlakDeleteDate { get; set; }
        public System.DateTime? EmlakCreateDate { get; set; }





        public Nullable<int> Dairetipi_DaireTipID { get; set; }
        public Nullable<int> Durumu_KonutDurumID { get; set; }
        public Nullable<int> Turu_TurID { get; set; }
        public string DaireTip { get; set; }
        public string KonutDurum { get; set; }
        public string Turu { get; set; }



        public int EmlakAdresID { get; set; }
        public string EmlakAdresIl { get; set; }
        public string EmlakAdresIlce { get; set; }
        public string EmlakAdresKoordinat { get; set; }
        public System.DateTime? EmlakAdresUpdateDate { get; set; }
        public System.DateTime? EmlakAdresDeleteDate { get; set; }
        public System.DateTime? EmlakAdresCreateDate { get; set; }



        public int MusteriAdresID { get; set; }
        public string MusteriAdresIl { get; set; }
        public string MusteriAdresIlce { get; set; }
        public string MusteriAdresKoordinat { get; set; }
        public System.DateTime? MusteriAdresUpdateDate { get; set; }
        public System.DateTime? MusteriAdresDeleteDate { get; set; }
        public System.DateTime? MusteriAdresCreateDate { get; set; }


        public PortfoyDTO()
        {

        }
        public PortfoyDTO(Portfoy p)
        {
            SetObject(p);
        }

        public void SetObject(Portfoy p)
        {

            this.PortfoyID = p.PortfoyID;
            this.PortfoyFiyatMax = p.FiyatMax;
            this.PortfoyFiyatMin = p.FiyaMin;
            this.PortfoyDepozito = p.Depozito;
            this.PortfoyTakas = p.Takas;
            this.PortfoyAciklama = p.Aciklama;
            this.PortfoyAciklamaBaslik = p.AciklamaBaslik;
            this.PortfoyOneCikan = p.OneCikan;
            this.PortfoyCreateDate = p.CreateDate;
            this.PortfoyUpdateDate = p.UpdateDate;
            this.PortfoyDeleteDate = p.DeleteDate;


            if (p.Musteri != null)
            {
                this.MusteriID = p.Musteri.MusteriID;
                this.MusteriAdi = p.Musteri.Adi;
                this.MusteriSoyadi = p.Musteri.Soyadi;
                this.MusteriTC = p.Musteri.TC;

                this.MusteriAdresID = p.Musteri.Adre.AdresID;
                this.MusteriAdresIl = p.Musteri.Adre.Il;
                this.MusteriAdresIlce = p.Musteri.Adre.Ilce;
                this.MusteriAdresKoordinat = p.Musteri.Adre.Koordinat;
                this.MusteriCreateDate = p.CreateDate;
                this.MusteriUpdateDate = p.UpdateDate;
                this.MusteriDeleteDate = p.DeleteDate;
                this.MusteriAdresCreateDate = p.CreateDate;
                this.MusteriAdresUpdateDate = p.UpdateDate;
                this.MusteriAdresDeleteDate = p.DeleteDate;




            }


            if (p.Emlak != null)
            {
                this.EmlakID = p.Emlak.EmlakID;
                this.EmlakKatNumarasi = p.Emlak.KatNumarasi;
                this.EmlakDaireNo = p.Emlak.DaireNo;
                this.EmlakBrutMetrekare = p.Emlak.BrutMetrekare;
                this.EmlakNetMetrekare = p.Emlak.NetMetrekare;
                this.EmlakBanyoSayisi = p.Emlak.BanyoSayisi;
                this.EmlakPiyasaBedeli = p.Emlak.PiyasaBedeli;
                this.EmlakKiraBedeli = p.Emlak.KiraBedeli;
                this.EmlakAidat = p.Emlak.Aidat;
                this.EmlakBinaYasi = p.Emlak.BinaYasi;
                this.EmlakKatSayisi = p.Emlak.KatSayisi;
                this.EmlakCephe = p.Emlak.Cephe;
                this.EmlakIsinmaSekli = p.Emlak.IsinmaSekli;
                this.EmlakOtopark = p.Emlak.Otopark;
                this.EmlakCreateDate = p.CreateDate;
                this.EmlakUpdateDate = p.UpdateDate;
                this.EmlakDeleteDate = p.DeleteDate;

                this.Dairetipi_DaireTipID = p.Emlak.Dairetipi_DaireTipID;
                this.Durumu_KonutDurumID = p.Emlak.Durumu_KonutDurumID;
                this.Turu_TurID = p.Emlak.Turu_TurID;

                this.DaireTip = p.Emlak.DaireTip != null ? p.Emlak.DaireTip.Adi : "";
                this.Turu = p.Emlak.Tur != null ? p.Emlak.Tur.Adi : "";

                if (p.Emlak.Adre != null)
                {
                    this.EmlakAdresID = p.Emlak.Adre.AdresID;
                    this.EmlakAdresIl = p.Emlak.Adre.Il;
                    this.EmlakAdresIlce = p.Emlak.Adre.Ilce;
                    this.EmlakAdresKoordinat = p.Emlak.Adre.Koordinat;
                    this.EmlakAdresCreateDate = p.CreateDate;
                    this.EmlakAdresUpdateDate = p.UpdateDate;
                    this.EmlakAdresDeleteDate = p.DeleteDate;
                }
            }
        }

        public void Save()
        {
            AdreManager adresMan = new AdreManager();
            Adre mAdres = new Adre();
            mAdres.Il = this.MusteriAdresIl;
            mAdres.Ilce = this.MusteriAdresIlce;
            mAdres.Koordinat = this.MusteriAdresKoordinat;
            this.MusteriAdresID = adresMan.AddAdre(mAdres);

            MusteriManager musMan = new MusteriManager();
            Musteri mus = new Musteri();
            mus.Adi = this.MusteriAdi;
            mus.Soyadi = this.MusteriSoyadi;
            mus.TC = this.MusteriTC;
            mus.Adresi_AdresID = MusteriAdresID;
            this.MusteriID = musMan.AddMusteri(mus);


            Adre emAdres = new Adre();
            emAdres.Il = this.MusteriAdresIl;
            emAdres.Ilce = this.MusteriAdresIlce;
            emAdres.Koordinat = this.MusteriAdresKoordinat;
            this.EmlakAdresID = adresMan.AddAdre(emAdres);


            EmlakManager emMan = new EmlakManager();
            Emlak em = new Emlak();
            em.Aidat = this.EmlakAidat;
            em.BanyoSayisi = this.EmlakBanyoSayisi;
            em.BrutMetrekare = this.EmlakBrutMetrekare;
            em.BinaYasi = this.EmlakBinaYasi;
            em.NetMetrekare = this.EmlakNetMetrekare;
            em.PiyasaBedeli = this.EmlakPiyasaBedeli;
            em.KiraBedeli = this.EmlakKiraBedeli;
            em.Aidat = this.EmlakAidat;
            em.KatSayisi = this.EmlakKatSayisi;
            em.Cephe = this.EmlakCephe;
            em.EmlakID = this.EmlakID;
            em.Adresi_AdresID = EmlakAdresID;
            em.Turu_TurID = this.Turu_TurID;
            em.Dairetipi_DaireTipID = this.Dairetipi_DaireTipID;
            em.Durumu_KonutDurumID = this.Durumu_KonutDurumID;
            this.EmlakID = emMan.AddEmlak(em);


            PortfoyManager pMan = new PortfoyManager();
            Portfoy p = new Portfoy();
            p.FiyatMax = this.PortfoyFiyatMax;
            p.FiyaMin = this.PortfoyFiyatMin;
            p.Depozito = this.PortfoyDepozito;
            p.Emlaki_EmlakID = EmlakID;
            p.Musteriler_MusteriID = MusteriID;
            this.PortfoyID = pMan.AddPortfoy(p);



        }

        public void Update()
        {
            AdreManager adresMan = new AdreManager();
            Adre mAdres = new Adre();
            mAdres.Il = this.MusteriAdresIl;
            mAdres.Ilce = this.MusteriAdresIlce;
            mAdres.Koordinat = this.MusteriAdresKoordinat;
            mAdres.CreateDate = this.EmlakAdresCreateDate;
            mAdres.UpdateDate = this.EmlakAdresUpdateDate;
            mAdres.DeleteDate = this.EmlakAdresDeleteDate;
            mAdres.AdresID = this.EmlakAdresID;
            this.MusteriAdresID = adresMan.EditAdre(mAdres);


            MusteriManager musMan = new MusteriManager();
            Musteri mus = new Musteri();
            mus.Adi = this.MusteriAdi;
            mus.Soyadi = this.MusteriSoyadi;
            mus.TC = this.MusteriTC;
            mus.Adresi_AdresID = MusteriAdresID;
            mus.CreateDate = this.MusteriDeleteDate;
            mus.UpdateDate = this.MusteriUpdateDate;
            mus.DeleteDate = this.MusteriCreateDate;
            mus.MusteriID = this.MusteriID ;

            musMan.EditMusteri(mus);


            Adre emAdres = new Adre();
            emAdres.Il = this.MusteriAdresIl;
            emAdres.Ilce = this.MusteriAdresIlce;
            emAdres.Koordinat = this.MusteriAdresKoordinat;
            emAdres.CreateDate = this.EmlakAdresCreateDate;
            emAdres.UpdateDate = this.EmlakAdresDeleteDate;
            emAdres.DeleteDate = this.EmlakAdresUpdateDate;
            this.EmlakAdresID = adresMan.EditAdre(emAdres);


            EmlakManager emMan = new EmlakManager();
            Emlak em = new Emlak();
            em.Aidat = this.EmlakAidat;
            em.BanyoSayisi = this.EmlakBanyoSayisi;
            em.BrutMetrekare = this.EmlakBrutMetrekare;
            em.BinaYasi = this.EmlakBinaYasi;
            em.NetMetrekare = this.EmlakNetMetrekare;
            em.PiyasaBedeli = this.EmlakPiyasaBedeli;
            em.KiraBedeli = this.EmlakKiraBedeli;
            em.Aidat = this.EmlakAidat;
            em.KatSayisi = this.EmlakKatSayisi;
            em.Cephe = this.EmlakCephe;
            em.EmlakID = MusteriID;
            em.Adresi_AdresID = EmlakAdresID;
            em.CreateDate = this.EmlakCreateDate;
            em.UpdateDate = this.EmlakDeleteDate;
            em.DeleteDate = this.EmlakUpdateDate;
            this.EmlakID = emMan.EditEmlak(em);


            PortfoyManager pMan = new PortfoyManager();
            Portfoy p = new Portfoy();
            p.FiyatMax = this.PortfoyFiyatMax;
            p.FiyaMin = this.PortfoyFiyatMin;
            p.Depozito = this.PortfoyDepozito;
            p.Emlaki_EmlakID = EmlakID;
            p.Musteriler_MusteriID = MusteriID;
            p.CreateDate = this.PortfoyCreateDate;
            p.UpdateDate = this.PortfoyDeleteDate;
            p.DeleteDate = this.PortfoyUpdateDate;
            this.PortfoyID = pMan.EditPortfoy(p);
        }
    }
}
