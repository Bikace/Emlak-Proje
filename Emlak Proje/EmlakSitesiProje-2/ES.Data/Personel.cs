//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel:BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.Musteris = new HashSet<Musteri>();
            this.Portfoys = new HashSet<Portfoy>();
        }
    
        public int PersonelID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int TC { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public bool AktifMi { get; set; }
        public Nullable<int> Adresi_AdresID { get; set; }
    
        public virtual Adre Adre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteri> Musteris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Portfoy> Portfoys { get; set; }
    }
}