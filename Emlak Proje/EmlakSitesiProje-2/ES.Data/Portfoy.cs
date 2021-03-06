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
    using System.Linq;
    
    public partial class Portfoy : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Portfoy()
        {
            this.Sozlesmes = new HashSet<Sozlesme>();
        }
    
        public int PortfoyID { get; set; }
        public int FiyatMax { get; set; }
        public int FiyaMin { get; set; }
        public int Depozito { get; set; }
        public bool Takas { get; set; }
        public string AciklamaBaslik { get; set; }
        public string Aciklama { get; set; }
        public bool OneCikan { get; set; }
        public System.DateTime OneCikmaTarihi { get; set; }
        public Nullable<int> Emlaki_EmlakID { get; set; }
        public Nullable<int> Musteriler_MusteriID { get; set; }
        public Nullable<int> Personeli_PersonelID { get; set; }
    
        public virtual Emlak Emlak { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Personel Personel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sozlesme> Sozlesmes { get; set; }

        public string KapakFotoYol
        {
            get
            {
                return Emlak.EmlakFotoes
                    .Where(l => l.Emlak_EmlakID == this.Emlaki_EmlakID && l.KapakFotoYol.ToLower() == "true")
                    .Select(s => s.KucukFotoYol).FirstOrDefault();
            }
        }
    }
}
