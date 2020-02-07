using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class EncadreMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Encadre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Encadre> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Encadre", "dbo");

            // key
            builder.HasKey(t => new { t.IdPilote, t.IdStage });

            // properties
            builder.Property(t => t.IdPilote)
                .IsRequired()
                .HasColumnName("Id_Pilote")
                .HasColumnType("int");

            builder.Property(t => t.IdStage)
                .IsRequired()
                .HasColumnName("Id_Stage")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Pilote)
                .WithMany(t => t.Encadres)
                .HasForeignKey(d => d.IdPilote)
                .HasConstraintName("FK__Encadre__Id_Pilo__403A8C7D");

            builder.HasOne(t => t.Stage)
                .WithMany(t => t.Encadres)
                .HasForeignKey(d => d.IdStage)
                .HasConstraintName("FK__Encadre__Id_Stag__412EB0B6");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "Encadre";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnIdStage = "Id_Stage";
        #endregion
    }
}
