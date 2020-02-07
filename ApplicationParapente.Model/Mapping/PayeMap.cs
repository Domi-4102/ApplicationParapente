using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class PayeMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Paye>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Paye> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Paye", "dbo");

            // key
            builder.HasKey(t => new { t.IdPilote, t.IdCotisation });

            // properties
            builder.Property(t => t.IdPilote)
                .IsRequired()
                .HasColumnName("Id_Pilote")
                .HasColumnType("int");

            builder.Property(t => t.IdCotisation)
                .IsRequired()
                .HasColumnName("Id_Cotisation")
                .HasColumnType("int");

            builder.Property(t => t.DateCotisation)
                .HasColumnName("DateCotisation")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.Cotisation)
                .WithMany(t => t.Payes)
                .HasForeignKey(d => d.IdCotisation)
                .HasConstraintName("FK__Paye__Id_Cotisat__46E78A0C");

            builder.HasOne(t => t.Pilote)
                .WithMany(t => t.Payes)
                .HasForeignKey(d => d.IdPilote)
                .HasConstraintName("FK__Paye__Id_Pilote__47DBAE45");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "Paye";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnIdCotisation = "Id_Cotisation";
        public const string ColumnDateCotisation = "DateCotisation";
        #endregion
    }
}
