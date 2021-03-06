﻿// <auto-generated />
using System;
using ApplicationParapente.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationParapente.DataModel.Migrations
{
    [DbContext(typeof(ParagliderContext))]
    [Migration("20200519075708_start")]
    partial class start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdLevel")
                        .HasColumnName("Id_Level")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("IdLevel");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateFly")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("IdLandingSite")
                        .HasColumnName("Id_LandingSite")
                        .HasColumnType("int");

                    b.Property<int>("IdLaunchingSite")
                        .HasColumnName("Id_LaunchingSite")
                        .HasColumnType("int");

                    b.Property<int>("IdParaglider")
                        .HasColumnName("Id_Paraglider")
                        .HasColumnType("int");

                    b.Property<int>("IdPilot")
                        .HasColumnName("Id_PILOT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLandingSite");

                    b.HasIndex("IdLaunchingSite");

                    b.HasIndex("IdParaglider");

                    b.HasIndex("IdPilot");

                    b.ToTable("Fly");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Fonction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("FONCTION");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Internship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("IdCertificate")
                        .HasColumnName("Id_Certificate")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("IdCertificate");

                    b.ToTable("Internship");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.LandingSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("IdLevel")
                        .HasColumnName("Id_Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Orientation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdLevel");

                    b.ToTable("LandingSite");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.LaunchingSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("IdLevel")
                        .HasColumnName("Id_Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Orientation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdLevel");

                    b.ToTable("LaunchingSite");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Label")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.MemberShipFee", b =>
                {
                    b.Property<DateTime>("AmountYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("AmountYear")
                        .HasName("PK__MemberSh__FE3924B45CF0786B");

                    b.ToTable("MemberShipFee");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Obtain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCertificate")
                        .HasColumnName("Id_Certificate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ObtainingDate")
                        .HasColumnType("date");

                    b.HasKey("Id", "IdCertificate")
                        .HasName("PK__Obtain__B4A2F4C4BFD1C4A5");

                    b.HasIndex("IdCertificate");

                    b.ToTable("Obtain");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Paraglider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdLevel")
                        .HasColumnName("Id_Level")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUseService")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ServiceDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("IdLevel");

                    b.ToTable("Paraglider");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.ParagliderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomologationDate")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("MaxWeight")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("MinWeight")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<string>("NumberOfHomologation")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Size")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Id");

                    b.HasIndex("NumberOfHomologation")
                        .IsUnique()
                        .HasName("UQ__Paraglid__1B6B7341D68F3614");

                    b.ToTable("ParagliderModel");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Pay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AmountYear")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateCotisation")
                        .HasColumnType("date");

                    b.HasKey("Id", "AmountYear")
                        .HasName("PK__Pay__6DF77E4CE87ECC17");

                    b.HasIndex("AmountYear");

                    b.ToTable("Pay");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("IdFonction")
                        .HasColumnName("Id_FONCTION")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tel")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("Id");

                    b.HasIndex("IdFonction");

                    b.ToTable("PILOT");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Supervise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdInternship")
                        .HasColumnName("Id_Internship")
                        .HasColumnType("int");

                    b.HasKey("Id", "IdInternship")
                        .HasName("PK__supervis__095D1154D14E60AE");

                    b.HasIndex("IdInternship");

                    b.ToTable("supervise");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Take", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdInternship")
                        .HasColumnName("Id_Internship")
                        .HasColumnType("int");

                    b.Property<bool>("Examen")
                        .HasColumnName("examen")
                        .HasColumnType("bit");

                    b.Property<bool?>("Payement")
                        .HasColumnType("bit");

                    b.HasKey("Id", "IdInternship")
                        .HasName("PK__Take__095D1154131AF90A");

                    b.HasIndex("IdInternship");

                    b.ToTable("Take");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Certificate", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Level", "IdLevelNavigation")
                        .WithMany("Certificate")
                        .HasForeignKey("IdLevel")
                        .HasConstraintName("FK__Certifica__Id_Le__3F466844")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Flight", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.LandingSite", "IdLandingSiteNavigation")
                        .WithMany("Flight")
                        .HasForeignKey("IdLandingSite")
                        .HasConstraintName("FK__Fly__Id_LandingS__403A8C7D")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.LaunchingSite", "IdLaunchingSiteNavigation")
                        .WithMany("Flight")
                        .HasForeignKey("IdLaunchingSite")
                        .HasConstraintName("FK__Fly__Id_Launchin__412EB0B6")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Paraglider", "IdParagliderNavigation")
                        .WithMany("Flight")
                        .HasForeignKey("IdParaglider")
                        .HasConstraintName("FK__Fly__Id_Paraglid__4222D4EF")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Pilot", "IdPilotNavigation")
                        .WithMany("Flight")
                        .HasForeignKey("IdPilot")
                        .HasConstraintName("FK__Fly__Id_PILOT__4316F928")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Internship", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Certificate", "IdCertificateNavigation")
                        .WithMany("Internship")
                        .HasForeignKey("IdCertificate")
                        .HasConstraintName("FK__Internshi__Id_Ce__440B1D61")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.LandingSite", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Level", "IdLevelNavigation")
                        .WithMany("LandingSite")
                        .HasForeignKey("IdLevel")
                        .HasConstraintName("FK__LandingSi__Id_Le__44FF419A")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.LaunchingSite", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Level", "IdLevelNavigation")
                        .WithMany("LaunchingSite")
                        .HasForeignKey("IdLevel")
                        .HasConstraintName("FK__Launching__Id_Le__45F365D3")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Obtain", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Pilot", "IdNavigation")
                        .WithMany("Obtain")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK__Obtain__Id__46E78A0C")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Certificate", "IdCertificateNavigation")
                        .WithMany("Obtain")
                        .HasForeignKey("IdCertificate")
                        .HasConstraintName("FK__Obtain__Id_Certi__47DBAE45")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Paraglider", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.ParagliderModel", "IdLevelNavigation")
                        .WithMany("Paraglider")
                        .HasForeignKey("IdLevel")
                        .HasConstraintName("FK__Paraglide__Id_Le__48CFD27E")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Pay", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.MemberShipFee", "AmountYearNavigation")
                        .WithMany("Pay")
                        .HasForeignKey("AmountYear")
                        .HasConstraintName("FK__Pay__AmountYear__49C3F6B7")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Pilot", "IdNavigation")
                        .WithMany("Pay")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK__Pay__Id__4AB81AF0")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Pilot", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Fonction", "IdFonctionNavigation")
                        .WithMany("Pilot")
                        .HasForeignKey("IdFonction")
                        .HasConstraintName("FK__PILOT__Id_FONCTI__4BAC3F29")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Supervise", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Pilot", "IdNavigation")
                        .WithMany("Supervise")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK__supervise__Id__4CA06362")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Internship", "IdInternshipNavigation")
                        .WithMany("Supervise")
                        .HasForeignKey("IdInternship")
                        .HasConstraintName("FK__supervise__Id_In__4D94879B")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Entities.Take", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Entities.Pilot", "IdNavigation")
                        .WithMany("Take")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK__Take__Id__4E88ABD4")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Entities.Internship", "IdInternshipNavigation")
                        .WithMany("Take")
                        .HasForeignKey("IdInternship")
                        .HasConstraintName("FK__Take__Id_Interns__4F7CD00D")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
