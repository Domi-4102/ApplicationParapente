using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Parapente.Data
{
    public partial class ParapenteContext : DbContext
    {
        public ParapenteContext(DbContextOptions<ParapenteContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Parapente.Data.Entities.Brevet> Brevets { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Cotisation> Cotisations { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Encadre> Encadres { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Fonction> Fonctions { get; set; }

        public virtual DbSet<Parapente.Data.Entities.ModeleParapente> ModeleParapentes { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Niveau> Niveaus { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Obtient> Obtients { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Parapente> Parapentes { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Passe> Passes { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Paye> Payes { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Pilote> Pilotes { get; set; }

        public virtual DbSet<Parapente.Data.Entities.SiteAtterissage> SiteAtterissages { get; set; }

        public virtual DbSet<Parapente.Data.Entities.SiteDecollage> SiteDecollages { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Stage> Stages { get; set; }

        public virtual DbSet<Parapente.Data.Entities.Vol> Vols { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.BrevetMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.CotisationMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.EncadreMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.FonctionMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.ModeleParapenteMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.NiveauMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.ObtientMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.ParapenteMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.PasseMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.PayeMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.PiloteMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.SiteAtterissageMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.SiteDecollageMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.StageMap());
            modelBuilder.ApplyConfiguration(new Parapente.Data.Mapping.VolMap());
            #endregion
        }
    }
}
