using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class SiteAtterissageMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.SiteAtterissage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.SiteAtterissage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SITE_ATTERISSAGE", "dbo");

            // key
            builder.HasKey(t => t.IdAtterissage);

            // properties
            builder.Property(t => t.IdAtterissage)
                .IsRequired()
                .HasColumnName("Id_Atterissage")
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
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.NiveauRequis)
                .HasColumnName("NiveauRequis")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "SITE_ATTERISSAGE";

        public const string ColumnIdAtterissage = "Id_Atterissage";
        public const string ColumnNom = "Nom";
        public const string ColumnOrientation = "Orientation";
        public const string ColumnDescription = "Description";
        public const string ColumnNiveauRequis = "NiveauRequis";
        #endregion
    }
}
