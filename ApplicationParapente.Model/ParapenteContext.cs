﻿
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApplicationParapente.DataModel
{
    public partial class ParapenteContext : DbContext
    {
        public ParapenteContext()
        {
        }

        public ParapenteContext(DbContextOptions<ParapenteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brevet> Brevet { get; set; }
        public virtual DbSet<Cotisation> Cotisation { get; set; }
        public virtual DbSet<Encadre> Encadre { get; set; }
        public virtual DbSet<Function> Fonction { get; set; }
        public virtual DbSet<ModeleParapente> ModeleParapente { get; set; }
        public virtual DbSet<Niveau> Niveau { get; set; }
        public virtual DbSet<Obtient> Obtient { get; set; }
        public virtual DbSet<Parapente> Parapente { get; set; }
        public virtual DbSet<Passe> Passe { get; set; }
        public virtual DbSet<Paye> Paye { get; set; }
        public virtual DbSet<Pilote> Pilote { get; set; }
        public virtual DbSet<SiteAtterissage> SiteAtterissage { get; set; }
        public virtual DbSet<SiteDecollage> SiteDecollage { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Vol> Vol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brevet>(entity =>
            {
                entity.HasKey(e => e.IdBrevet)
                    .HasName("PK__BREVET__042931069F1C72B7");

                entity.Property(e => e.Label).IsUnicode(false);

                entity.HasOne(d => d.IdNiveauNavigation)
                    .WithMany(p => p.Brevet)
                    .HasForeignKey(d => d.IdNiveau)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BREVET__Id_Nivea__3F466844");
            });

            modelBuilder.Entity<Cotisation>(entity =>
            {
                entity.HasKey(e => e.IdCotisation)
                    .HasName("PK__COTISATI__F3DA9ACA5D45871F");
            });

            modelBuilder.Entity<Encadre>(entity =>
            {
                entity.HasKey(e => new { e.IdPilote, e.IdStage })
                    .HasName("PK__Encadre__4BB29D007972F5A7");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Encadre)
                    .HasForeignKey(d => d.IdPilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Encadre__Id_Pilo__403A8C7D");

                entity.HasOne(d => d.IdStageNavigation)
                    .WithMany(p => p.Encadre)
                    .HasForeignKey(d => d.IdStage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Encadre__Id_Stag__412EB0B6");
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.HasKey(e => e.IdFonction)
                    .HasName("PK__FONCTION__91F04474B198408F");

                entity.Property(e => e.Label).IsUnicode(false);
            });

            modelBuilder.Entity<ModeleParapente>(entity =>
            {
                entity.HasKey(e => e.IdModele)
                    .HasName("PK__MODELE_P__D5BA161C39564CAB");

                entity.HasIndex(e => e.NumeroHomologation)
                    .HasName("UQ__MODELE_P__926D7EA43C48F393")
                    .IsUnique();

                entity.Property(e => e.DateHomologation).IsUnicode(false);

                entity.Property(e => e.NumeroHomologation).IsUnicode(false);
            });

            modelBuilder.Entity<Niveau>(entity =>
            {
                entity.HasKey(e => e.IdNiveau)
                    .HasName("PK__NIVEAU__2033157735765FF4");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Intitulé).IsUnicode(false);
            });

            modelBuilder.Entity<Obtient>(entity =>
            {
                entity.HasKey(e => new { e.IdPilote, e.IdBrevet })
                    .HasName("PK__Obtient__F80D86256FBD686E");

                entity.HasOne(d => d.IdBrevetNavigation)
                    .WithMany(p => p.Obtient)
                    .HasForeignKey(d => d.IdBrevet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Obtient__Id_Brev__4222D4EF");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Obtient)
                    .HasForeignKey(d => d.IdPilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Obtient__Id_Pilo__4316F928");
            });

            modelBuilder.Entity<Parapente>(entity =>
            {
                entity.HasKey(e => e.IdParapente)
                    .HasName("PK__PARAPENT__6D210CDF4AA2CFF2");

                entity.HasOne(d => d.IdModeleNavigation)
                    .WithMany(p => p.Parapente)
                    .HasForeignKey(d => d.IdModele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PARAPENTE__Id_Mo__440B1D61");
            });

            modelBuilder.Entity<Passe>(entity =>
            {
                entity.HasKey(e => new { e.IdPilote, e.IdStage })
                    .HasName("PK__Passe__4BB29D000E1CA7D0");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Passe)
                    .HasForeignKey(d => d.IdPilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Passe__Id_Pilote__44FF419A");

                entity.HasOne(d => d.IdStageNavigation)
                    .WithMany(p => p.Passe)
                    .HasForeignKey(d => d.IdStage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Passe__Id_Stage__45F365D3");
            });

            modelBuilder.Entity<Paye>(entity =>
            {
                entity.HasKey(e => new { e.IdPilote, e.IdCotisation })
                    .HasName("PK__Paye__3772BC99194BE957");

                entity.HasOne(d => d.IdCotisationNavigation)
                    .WithMany(p => p.Paye)
                    .HasForeignKey(d => d.IdCotisation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paye__Id_Cotisat__46E78A0C");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Paye)
                    .HasForeignKey(d => d.IdPilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paye__Id_Pilote__47DBAE45");
            });

            modelBuilder.Entity<Pilote>(entity =>
            {
                entity.HasKey(e => e.IdPilote)
                    .HasName("PK__PILOTE__884F15358E0CBE76");

                entity.Property(e => e.Adresse).IsUnicode(false);

                entity.Property(e => e.Nom).IsUnicode(false);

                entity.Property(e => e.Prenom).IsUnicode(false);

                entity.Property(e => e.Tel).IsUnicode(false);

                entity.HasOne(d => d.IdFonctionNavigation)
                    .WithMany(p => p.Pilote)
                    .HasForeignKey(d => d.IdFonction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PILOTE__Id_Fonct__48CFD27E");
            });

            modelBuilder.Entity<SiteAtterissage>(entity =>
            {
                entity.HasKey(e => e.IdAtterissage)
                    .HasName("PK__SITE_ATT__73E7E7945E4B48B9");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Nom).IsUnicode(false);

                entity.Property(e => e.Orientation).IsUnicode(false);
            });

            modelBuilder.Entity<SiteDecollage>(entity =>
            {
                entity.HasKey(e => e.IdDecollage)
                    .HasName("PK__SITE_DEC__04FEF9BA1FB39D0D");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Nom).IsUnicode(false);

                entity.Property(e => e.Orientation).IsUnicode(false);
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.HasKey(e => e.IdStage)
                    .HasName("PK__STAGE__3FD8835DEBCD370C");

                entity.HasOne(d => d.IdBrevetNavigation)
                    .WithMany(p => p.Stage)
                    .HasForeignKey(d => d.IdBrevet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STAGE__Id_Brevet__49C3F6B7");
            });

            modelBuilder.Entity<Vol>(entity =>
            {
                entity.HasKey(e => new { e.IdPilote, e.IdParapente, e.IdAtterissage, e.IdDecollage })
                    .HasName("PK__Vol__605EADF09A04B8FD");

                entity.HasOne(d => d.IdAtterissageNavigation)
                    .WithMany(p => p.Vol)
                    .HasForeignKey(d => d.IdAtterissage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vol__Id_Atteriss__4AB81AF0");

                entity.HasOne(d => d.IdDecollageNavigation)
                    .WithMany(p => p.Vol)
                    .HasForeignKey(d => d.IdDecollage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vol__Id_Decollag__4BAC3F29");

                entity.HasOne(d => d.IdParapenteNavigation)
                    .WithMany(p => p.Vol)
                    .HasForeignKey(d => d.IdParapente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vol__Id_Parapent__4CA06362");

                entity.HasOne(d => d.IdPiloteNavigation)
                    .WithMany(p => p.Vol)
                    .HasForeignKey(d => d.IdPilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vol__Id_Pilote__4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}