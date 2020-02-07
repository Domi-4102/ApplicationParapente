using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class ModeleParapenteMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.ModeleParapente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.ModeleParapente> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("MODELE_PARAPENTE", "dbo");

            // key
            builder.HasKey(t => t.IdModele);

            // properties
            builder.Property(t => t.IdModele)
                .IsRequired()
                .HasColumnName("Id_Modele")
                .HasColumnType("int");

            builder.Property(t => t.NumeroHomologation)
                .IsRequired()
                .HasColumnName("NumeroHomologation")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DateHomologation)
                .HasColumnName("dateHomologation")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Taille)
                .HasColumnName("Taille")
                .HasColumnType("decimal(15,2)");

            builder.Property(t => t.PoidsMin)
                .HasColumnName("PoidsMin")
                .HasColumnType("decimal(15,2)");

            builder.Property(t => t.PoidMax)
                .HasColumnName("PoidMax")
                .HasColumnType("decimal(15,2)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "MODELE_PARAPENTE";

        public const string ColumnIdModele = "Id_Modele";
        public const string ColumnNumeroHomologation = "NumeroHomologation";
        public const string ColumnDateHomologation = "dateHomologation";
        public const string ColumnTaille = "Taille";
        public const string ColumnPoidsMin = "PoidsMin";
        public const string ColumnPoidMax = "PoidMax";
        #endregion
    }
}
