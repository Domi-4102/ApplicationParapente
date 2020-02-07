using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class ObtientMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Obtient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Obtient> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Obtient", "dbo");

            // key
            builder.HasKey(t => new { t.IdPilote, t.IdBrevet });

            // properties
            builder.Property(t => t.IdPilote)
                .IsRequired()
                .HasColumnName("Id_Pilote")
                .HasColumnType("int");

            builder.Property(t => t.IdBrevet)
                .IsRequired()
                .HasColumnName("Id_Brevet")
                .HasColumnType("int");

            builder.Property(t => t.DateObtention)
                .HasColumnName("DateObtention")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.Brevet)
                .WithMany(t => t.Obtients)
                .HasForeignKey(d => d.IdBrevet)
                .HasConstraintName("FK__Obtient__Id_Brev__4222D4EF");

            builder.HasOne(t => t.Pilote)
                .WithMany(t => t.Obtients)
                .HasForeignKey(d => d.IdPilote)
                .HasConstraintName("FK__Obtient__Id_Pilo__4316F928");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "Obtient";

        public const string ColumnIdPilote = "Id_Pilote";
        public const string ColumnIdBrevet = "Id_Brevet";
        public const string ColumnDateObtention = "DateObtention";
        #endregion
    }
}
