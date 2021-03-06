﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class ParagliderContext : DbContext
    {
        public ParagliderContext()
        {
        }

        public ParagliderContext(DbContextOptions<ParagliderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<Flight> Fly { get; set; }
        public virtual DbSet<Fonction> Fonction { get; set; }
        public virtual DbSet<Internship> Internship { get; set; }
        public virtual DbSet<LandingSite> LandingSite { get; set; }
        public virtual DbSet<LaunchingSite> LaunchingSite { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<MemberShipFee> MemberShipFee { get; set; }
        public virtual DbSet<Obtain> Obtain { get; set; }
        public virtual DbSet<Paraglider> Paraglider { get; set; }
        public virtual DbSet<ParagliderModel> ParagliderModel { get; set; }
        public virtual DbSet<Pay> Pay { get; set; }
        public virtual DbSet<Pilot> Pilot { get; set; }
        public virtual DbSet<Supervise> Supervise { get; set; }
        public virtual DbSet<Take> Take { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Paraglider;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>(entity =>
            {
                

                entity.Property(e => e.Label).IsUnicode(false);

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Certificate)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Certifica__Id_Le__3F466844");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                

                entity.HasOne(d => d.IdLandingSiteNavigation)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.IdLandingSite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fly__Id_LandingS__403A8C7D");

                entity.HasOne(d => d.IdLaunchingSiteNavigation)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.IdLaunchingSite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fly__Id_Launchin__412EB0B6");

                entity.HasOne(d => d.IdParagliderNavigation)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.IdParaglider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fly__Id_Paraglid__4222D4EF");

                entity.HasOne(d => d.IdPilotNavigation)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.IdPilot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fly__Id_PILOT__4316F928");
            });

            modelBuilder.Entity<Fonction>(entity =>
            {
                

                entity.Property(e => e.Label).IsUnicode(false);
            });

            modelBuilder.Entity<Internship>(entity =>
            {
                

                entity.HasOne(d => d.IdCertificateNavigation)
                    .WithMany(p => p.Internship)
                    .HasForeignKey(d => d.IdCertificate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Internshi__Id_Ce__440B1D61");
            });

            modelBuilder.Entity<LandingSite>(entity =>
            {
               

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.LandingSite)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LandingSi__Id_Le__44FF419A");
            });

            modelBuilder.Entity<LaunchingSite>(entity =>
            {
                

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.LaunchingSite)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Launching__Id_Le__45F365D3");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Label).IsUnicode(false);
            });

            modelBuilder.Entity<MemberShipFee>(entity =>
            {
                entity.HasKey(e => e.AmountYear)
                    .HasName("PK__MemberSh__FE3924B45CF0786B");
            });

            modelBuilder.Entity<Obtain>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCertificate })
                    .HasName("PK__Obtain__B4A2F4C4BFD1C4A5");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Obtain)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Obtain__Id__46E78A0C");

                entity.HasOne(d => d.IdCertificateNavigation)
                    .WithMany(p => p.Obtain)
                    .HasForeignKey(d => d.IdCertificate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Obtain__Id_Certi__47DBAE45");
            });

            modelBuilder.Entity<Paraglider>(entity =>
            {
               

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Paraglider)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paraglide__Id_Le__48CFD27E");
            });

            modelBuilder.Entity<ParagliderModel>(entity =>
            {
                entity.HasIndex(e => e.NumberOfHomologation)
                    .HasName("UQ__Paraglid__1B6B7341D68F3614")
                    .IsUnique();

                

                entity.Property(e => e.HomologationDate).IsUnicode(false);

                entity.Property(e => e.MaxWeight).IsUnicode(false);

                entity.Property(e => e.NumberOfHomologation).IsUnicode(false);
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AmountYear })
                    .HasName("PK__Pay__6DF77E4CE87ECC17");

                entity.HasOne(d => d.AmountYearNavigation)
                    .WithMany(p => p.Pay)
                    .HasForeignKey(d => d.AmountYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pay__AmountYear__49C3F6B7");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Pay)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pay__Id__4AB81AF0");
            });

            modelBuilder.Entity<Pilot>(entity =>
            {
                

                entity.Property(e => e.Adress).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Tel).IsUnicode(false);

                entity.HasOne(d => d.IdFonctionNavigation)
                    .WithMany(p => p.Pilot)
                    .HasForeignKey(d => d.IdFonction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PILOT__Id_FONCTI__4BAC3F29");
            });

            modelBuilder.Entity<Supervise>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdInternship })
                    .HasName("PK__supervis__095D1154D14E60AE");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Supervise)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__supervise__Id__4CA06362");

                entity.HasOne(d => d.IdInternshipNavigation)
                    .WithMany(p => p.Supervise)
                    .HasForeignKey(d => d.IdInternship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__supervise__Id_In__4D94879B");
            });

            modelBuilder.Entity<Take>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdInternship })
                    .HasName("PK__Take__095D1154131AF90A");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Take)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Take__Id__4E88ABD4");

                entity.HasOne(d => d.IdInternshipNavigation)
                    .WithMany(p => p.Take)
                    .HasForeignKey(d => d.IdInternship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Take__Id_Interns__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}