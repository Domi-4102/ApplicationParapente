using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class VolMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Vol>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Vol> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Vol", "dbo");

            // key
            builder.HasKey(t => new { t.IdPilote, t.IdParapente, t.IdAtterissage, t.IdDecollage });

            // properties
            builder.Property(t => t.IdPilote)
                .IsRequired()
                .HasColumnName("Id_Pilote")
                .HasColumnType("int");

            builder.Property(t => t.IdParapente)
                .IsRequired()
                .HasColumnName("Id_Parapente")
                .HasColumnType("int");

            builder.Property(t => t.IdAtterissage)
                .IsRequired()
                .HasColumnName("Id_Atterissage")
                .HasColumnType("int");

            builder.Property(t => t.IdDecollage)
                .IsRequired()
                .HasColumnName("Id_Decollage")
                .HasColumnType("int");

            builder.Property(t => t.DateVol)
                .HasColumnName("DateVol")
                .HasColumnType("date");

            builder.Property(t => t.DureeVol)
                .HasColumnName("DureeVol")
                .HasColumnType("decimal(15,2)");

            // relationships
            builder.HasOne(t => t.SiteAtterissage)
                .WithMany(t => t.Vols)
                .HasForeignKey(d => d.IdAtterissage)
                .HasConstraintName("FK__Vol__Id_Atteriss__4AB81AF0");

            builder.HasOne(t => t.SiteDecollage)
                .WithMany(t => t.Vols)
                .HasForeignKey(d => d.IdDecollage)
                .HasConstraintName("FK__Vol__Id_Decollag__4BAC3F29");

            builder.HasOne(t => t.Parapente)
                .WithMany(t => t.Vols)
                .HasForeignKey(d => d.IdParapente)
                .HasConstraintName("FK__Vol__Id_Parapent__4CA06362");

            builder.HasOne(t => t.Pilote)
                .WithMany(t => t.Vols)
                .HasForeignKey(d => d.IdPilote)
                .HasConstraintName("FK__Vol__Id_Pilote__4D94879B");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "Vol";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnIdParapente = "Id_Parapente";
        public const string ColumnIdAtterissage = "Id_Atterissage";
        public const string ColumnIdDecollage = "Id_Decollage";
        public const string ColumnDateVol = "DateVol";
        public const string ColumnDureeVol = "DureeVol";
        #endregion
    }
}
