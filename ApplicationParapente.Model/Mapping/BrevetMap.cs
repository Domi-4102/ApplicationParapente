using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class BrevetMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Brevet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Brevet> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BREVET", "dbo");

            // key
            builder.HasKey(t => t.IdBrevet);

            // properties
            builder.Property(t => t.IdBrevet)
                .IsRequired()
                .HasColumnName("Id_Brevet")
                .HasColumnType("int");

            builder.Property(t => t.Label)
                .IsRequired()
                .HasColumnName("Label")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IdNiveau)
                .IsRequired()
                .HasColumnName("Id_Niveau")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Niveau)
                .WithMany(t => t.Brevets)
                .HasForeignKey(d => d.IdNiveau)
                .HasConstraintName("FK__BREVET__Id_Nivea__3F466844");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "BREVET";

        public const string ColumnIdBrevet = "Id_Brevet";
        public const string ColumnLabel = "Label";
        public const string ColumnIdNiveau = "Id_Niveau";
        #endregion
    }
}
