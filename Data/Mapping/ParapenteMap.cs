using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class ParapenteMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Parapente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Parapente> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PARAPENTE", "dbo");

            // key
            builder.HasKey(t => t.IdParapente);

            // properties
            builder.Property(t => t.IdParapente)
                .IsRequired()
                .HasColumnName("Id_Parapente")
                .HasColumnType("int");

            builder.Property(t => t.DateMiseEnService)
                .HasColumnName("DateMiseEnService")
                .HasColumnType("date");

            builder.Property(t => t.DateDerniereRevision)
                .HasColumnName("DateDerniereRevision")
                .HasColumnType("date");

            builder.Property(t => t.IdModele)
                .IsRequired()
                .HasColumnName("Id_Modele")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.ModeleParapente)
                .WithMany(t => t.Parapentes)
                .HasForeignKey(d => d.IdModele)
                .HasConstraintName("FK__PARAPENTE__Id_Mo__440B1D61");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "PARAPENTE";

        public const string ColumnIdParapente = "Id_Parapente";
        public const string ColumnDateMiseEnService = "DateMiseEnService";
        public const string ColumnDateDerniereRevision = "DateDerniereRevision";
        public const string ColumnIdModele = "Id_Modele";
        #endregion
    }
}
