using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class SiteDecollageMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.SiteDecollage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.SiteDecollage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SITE_DECOLLAGE", "dbo");

            // key
            builder.HasKey(t => t.IdDecollage);

            // properties
            builder.Property(t => t.IdDecollage)
                .IsRequired()
                .HasColumnName("Id_Decollage")
                .HasColumnType("int");

            builder.Property(t => t.Nom)
                .HasColumnName("Nom")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Orientation)
                .HasColumnName("Orientation")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.NiveauRequis)
                .HasColumnName("NiveauRequis")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "SITE_DECOLLAGE";

        public const string ColumnIdDecollage = "Id_Decollage";
        public const string ColumnNom = "Nom";
        public const string ColumnOrientation = "Orientation";
        public const string ColumnDescription = "Description";
        public const string ColumnNiveauRequis = "NiveauRequis";
        #endregion
    }
}
