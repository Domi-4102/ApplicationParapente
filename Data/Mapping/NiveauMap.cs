using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class NiveauMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Niveau>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Niveau> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("NIVEAU", "dbo");

            // key
            builder.HasKey(t => t.IdNiveau);

            // properties
            builder.Property(t => t.IdNiveau)
                .IsRequired()
                .HasColumnName("Id_Niveau")
                .HasColumnType("int");

            builder.Property(t => t.Intitulé)
                .HasColumnName("Intitulé")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "NIVEAU";

        public const string ColumnIdNiveau = "Id_Niveau";
        public const string ColumnIntitulé = "Intitulé";
        public const string ColumnDescription = "Description";
        #endregion
    }
}
