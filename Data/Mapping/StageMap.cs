using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parapente.Data.Mapping
{
    public partial class StageMap
        : IEntityTypeConfiguration<Parapente.Data.Entities.Stage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Parapente.Data.Entities.Stage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("STAGE", "dbo");

            // key
            builder.HasKey(t => t.IdStage);

            // properties
            builder.Property(t => t.IdStage)
                .IsRequired()
                .HasColumnName("Id_Stage")
                .HasColumnType("int");

            builder.Property(t => t.DateDebut)
                .HasColumnName("DateDebut")
                .HasColumnType("date");

            builder.Property(t => t.DateFin)
                .HasColumnName("DateFin")
                .HasColumnType("date");

            builder.Property(t => t.Prix)
                .HasColumnName("Prix")
                .HasColumnType("decimal(15,2)");

            builder.Property(t => t.NiveauRequis)
                .HasColumnName("NiveauRequis")
                .HasColumnType("int");

            builder.Property(t => t.IdBrevet)
                .IsRequired()
                .HasColumnName("Id_Brevet")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Brevet)
                .WithMany(t => t.Stages)
                .HasForeignKey(d => d.IdBrevet)
                .HasConstraintName("FK__STAGE__Id_Brevet__49C3F6B7");

            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "dbo";
        public const string TableName = "STAGE";

        public const string ColumnIdStage = "Id_Stage";
        public const string ColumnDateDebut = "DateDebut";
        public const string ColumnDateFin = "DateFin";
        public const string ColumnPrix = "Prix";
        public const string ColumnNiveauRequis = "NiveauRequis";
        public const string ColumnIdBrevet = "Id_Brevet";
        #endregion
    }
}
