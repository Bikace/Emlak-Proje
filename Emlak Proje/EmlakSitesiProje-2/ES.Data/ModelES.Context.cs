﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmlakSDBEntities : DbContext
    {
        public EmlakSDBEntities()
            : base("name=EmlakSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Adre> Adres { get; set; }
        public virtual DbSet<DaireTip> DaireTips { get; set; }
        public virtual DbSet<EmlakFoto> EmlakFotoes { get; set; }
        public virtual DbSet<EmlakOzellik> EmlakOzelliks { get; set; }
        public virtual DbSet<Emlak> Emlaks { get; set; }
        public virtual DbSet<KiraSozlesme> KiraSozlesmes { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<OdemePlan> OdemePlans { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Portfoy> Portfoys { get; set; }
        public virtual DbSet<SatisSozlesme> SatisSozlesmes { get; set; }
        public virtual DbSet<Sozlesme> Sozlesmes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tur> Turs { get; set; }
        public virtual DbSet<KonutDurum> KonutDurums { get; set; }
        public virtual DbSet<MusteriLike> MusteriLikes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
    }
}