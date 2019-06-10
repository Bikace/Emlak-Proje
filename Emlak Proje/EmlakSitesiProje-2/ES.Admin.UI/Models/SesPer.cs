using ES.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES.Admin.UI.Models
{
    public class SesPer
    {
        public int PersonelId { get; set; }
        private string _ad;
        private string _soyad;

        public string Tamadi
        {
            get
            {
                return _ad + " " + _soyad;
            }
        }

        public int RolId { get; set; }
        public Rol Rol { get; set; }

        public SesPer(Personel p,int rolId)
        {
            PersonelId = p.PersonelID;
            _ad = p.Adi;
            _soyad = p.Soyadi;
            this.RolId = rolId;
            this.Rol = (Rol)RolId;
        }
    }

}