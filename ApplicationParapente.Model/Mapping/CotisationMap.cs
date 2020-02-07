using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class CotisationMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Cotisation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Cotisation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("COTISATION", "dbo");

            // key
            builder.HasKey(t => t.IdCotisation);

            // properties
            builder.Property(t => t.IdCotisation)
                .IsRequired()
                .HasColumnName("Id_Cotisation")
                .HasColumnType("int");

            builder.Property(t => t.Montant)
                .HasColumnName("Montant")
                .HasColumnType("decimal(15,2)");

            builder.Property(t => t.AnnéeCotisation)
                .HasColumnName("AnnéeCotisation")
                .HasColumnType("date");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "COTISATION";

        public const string ColumnIdCotisation = "Id_Cotisation";
        public const string ColumnMontant = "Montant";
        public const string ColumnAnnéeCotisation = "AnnéeCotisation";
        #endregion
    }
}
