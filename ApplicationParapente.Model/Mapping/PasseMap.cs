using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class PasseMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Passe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Passe> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Passe", "dbo");

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

            builder.Property(t => t.Examen)
                .IsRequired()
                .HasColumnName("examen")
                .HasColumnType("bit");

            builder.Property(t => t.Payement)
                .IsRequired()
                .HasColumnName("Payement")
                .HasColumnType("bit");

            // relationships
            builder.HasOne(t => t.Pilote)
                .WithMany(t => t.Passes)
                .HasForeignKey(d => d.IdPilote)
                .HasConstraintName("FK__Passe__Id_Pilote__44FF419A");

            builder.HasOne(t => t.Stage)
                .WithMany(t => t.Passes)
                .HasForeignKey(d => d.IdStage)
                .HasConstraintName("FK__Passe__Id_Stage__45F365D3");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "Passe";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnIdStage = "Id_Stage";
        public const string ColumnExamen = "examen";
        public const string ColumnPayement = "Payement";
        #endregion
    }
}
