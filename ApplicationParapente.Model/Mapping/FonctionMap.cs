using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class FonctionMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Fonction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Fonction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FONCTION", "dbo");

            // key
            builder.HasKey(t => t.IdFonction);

            // properties
            builder.Property(t => t.IdFonction)
                .IsRequired()
                .HasColumnName("Id_Fonction")
                .HasColumnType("int");

            builder.Property(t => t.Label)
                .IsRequired()
                .HasColumnName("Label")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "FONCTION";

        public const string ColumnIdFonction = "Id_Fonction";
        public const string ColumnLabel = "Label";
        #endregion
    }
}
