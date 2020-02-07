using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class PiloteMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Pilote>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Pilote> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PILOTE", "dbo");

            // key
            builder.HasKey(t => t.IdPilote);

            // properties
            builder.Property(t => t.IdPilote)
                .IsRequired()
                .HasColumnName("Id_Pilote")
                .HasColumnType("int");

            builder.Property(t => t.Nom)
                .HasColumnName("Nom")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Prenom)
                .HasColumnName("Prenom")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Poids)
                .HasColumnName("Poids")
                .HasColumnType("decimal(15,2)");

            builder.Property(t => t.Adresse)
                .HasColumnName("Adresse")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.Tel)
                .HasColumnName("Tel")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.IdFonction)
                .IsRequired()
                .HasColumnName("Id_Fonction")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Fonction)
                .WithMany(t => t.Pilotes)
                .HasForeignKey(d => d.IdFonction)
                .HasConstraintName("FK__PILOTE__Id_Fonct__48CFD27E");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "PILOTE";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnNom = "Nom";
        public const string ColumnPrenom = "Prenom";
        public const string ColumnPoids = "Poids";
        public const string ColumnAdresse = "Adresse";
        public const string ColumnTel = "Tel";
        public const string ColumnIdFonction = "Id_Fonction";
        #endregion
    }
}
