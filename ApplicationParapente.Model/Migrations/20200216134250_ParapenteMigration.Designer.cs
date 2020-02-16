using System;
using ApplicationParapente.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationParapente.DataModel.Migrations
{
    [DbContext(typeof(ParapenteContext))]
    [Migration("20200216134250_ParapenteMigration")]
    partial class ParapenteMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationParapente.DataModel.Brevet", b =>
                {
                    b.Property<int>("IdBrevet")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Brevet")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdNiveau")
                        .HasColumnName("Id_Niveau")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdBrevet")
                        .HasName("PK__BREVET__042931069F1C72B7");

                    b.HasIndex("IdNiveau");

                    b.ToTable("BREVET");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Cotisation", b =>
                {
                    b.Property<int>("IdCotisation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Cotisation")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnnéeCotisation")
                        .HasColumnType("date");

                    b.Property<decimal?>("Montant")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("IdCotisation")
                        .HasName("PK__COTISATI__F3DA9ACA5D45871F");

                    b.ToTable("COTISATION");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Encadre", b =>
                {
                    b.Property<int>("IdPilote")
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int");

                    b.Property<int>("IdStage")
                        .HasColumnName("Id_Stage")
                        .HasColumnType("int");

                    b.HasKey("IdPilote", "IdStage")
                        .HasName("PK__Encadre__4BB29D007972F5A7");

                    b.HasIndex("IdStage");

                    b.ToTable("Encadre");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Fonction", b =>
                {
                    b.Property<int>("IdFonction")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Fonction")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdFonction")
                        .HasName("PK__FONCTION__91F04474B198408F");

                    b.ToTable("FONCTION");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.ModeleParapente", b =>
                {
                    b.Property<int>("IdModele")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Modele")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateHomologation")
                        .HasColumnName("dateHomologation")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NumeroHomologation")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("PoidMax")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal?>("PoidsMin")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<decimal?>("Taille")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("IdModele")
                        .HasName("PK__MODELE_P__D5BA161C39564CAB");

                    b.HasIndex("NumeroHomologation")
                        .IsUnique()
                        .HasName("UQ__MODELE_P__926D7EA43C48F393");

                    b.ToTable("MODELE_PARAPENTE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Niveau", b =>
                {
                    b.Property<int>("IdNiveau")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Niveau")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Intitulé")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdNiveau")
                        .HasName("PK__NIVEAU__2033157735765FF4");

                    b.ToTable("NIVEAU");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Obtient", b =>
                {
                    b.Property<int>("IdPilote")
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int");

                    b.Property<int>("IdBrevet")
                        .HasColumnName("Id_Brevet")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateObtention")
                        .HasColumnType("date");

                    b.HasKey("IdPilote", "IdBrevet")
                        .HasName("PK__Obtient__F80D86256FBD686E");

                    b.HasIndex("IdBrevet");

                    b.ToTable("Obtient");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Parapente", b =>
                {
                    b.Property<int>("IdParapente")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Parapente")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateDerniereRevision")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateMiseEnService")
                        .HasColumnType("date");

                    b.Property<int>("IdModele")
                        .HasColumnName("Id_Modele")
                        .HasColumnType("int");

                    b.HasKey("IdParapente")
                        .HasName("PK__PARAPENT__6D210CDF4AA2CFF2");

                    b.HasIndex("IdModele");

                    b.ToTable("PARAPENTE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Passe", b =>
                {
                    b.Property<int>("IdPilote")
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int");

                    b.Property<int>("IdStage")
                        .HasColumnName("Id_Stage")
                        .HasColumnType("int");

                    b.Property<bool>("Examen")
                        .HasColumnName("examen")
                        .HasColumnType("bit");

                    b.Property<bool>("Payement")
                        .HasColumnType("bit");

                    b.HasKey("IdPilote", "IdStage")
                        .HasName("PK__Passe__4BB29D000E1CA7D0");

                    b.HasIndex("IdStage");

                    b.ToTable("Passe");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Paye", b =>
                {
                    b.Property<int>("IdPilote")
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int");

                    b.Property<int>("IdCotisation")
                        .HasColumnName("Id_Cotisation")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCotisation")
                        .HasColumnType("date");

                    b.HasKey("IdPilote", "IdCotisation")
                        .HasName("PK__Paye__3772BC99194BE957");

                    b.HasIndex("IdCotisation");

                    b.ToTable("Paye");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Pilote", b =>
                {
                    b.Property<int>("IdPilote")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<int>("IdFonction")
                        .HasColumnName("Id_Fonction")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal?>("Poids")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<string>("Prenom")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tel")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdPilote")
                        .HasName("PK__PILOTE__884F15358E0CBE76");

                    b.HasIndex("IdFonction");

                    b.ToTable("PILOTE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.SiteAtterissage", b =>
                {
                    b.Property<int>("IdAtterissage")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Atterissage")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("NiveauRequis")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Orientation")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdAtterissage")
                        .HasName("PK__SITE_ATT__73E7E7945E4B48B9");

                    b.ToTable("SITE_ATTERISSAGE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.SiteDecollage", b =>
                {
                    b.Property<int>("IdDecollage")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Decollage")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int?>("NiveauRequis")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Orientation")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdDecollage")
                        .HasName("PK__SITE_DEC__04FEF9BA1FB39D0D");

                    b.ToTable("SITE_DECOLLAGE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Stage", b =>
                {
                    b.Property<int>("IdStage")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Stage")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("date");

                    b.Property<int>("IdBrevet")
                        .HasColumnName("Id_Brevet")
                        .HasColumnType("int");

                    b.Property<int?>("NiveauRequis")
                        .HasColumnType("int");

                    b.Property<decimal?>("Prix")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("IdStage")
                        .HasName("PK__STAGE__3FD8835DEBCD370C");

                    b.HasIndex("IdBrevet");

                    b.ToTable("STAGE");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Vol", b =>
                {
                    b.Property<int>("IdPilote")
                        .HasColumnName("Id_Pilote")
                        .HasColumnType("int");

                    b.Property<int>("IdParapente")
                        .HasColumnName("Id_Parapente")
                        .HasColumnType("int");

                    b.Property<int>("IdAtterissage")
                        .HasColumnName("Id_Atterissage")
                        .HasColumnType("int");

                    b.Property<int>("IdDecollage")
                        .HasColumnName("Id_Decollage")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateVol")
                        .HasColumnType("date");

                    b.Property<decimal?>("DureeVol")
                        .HasColumnType("decimal(15, 2)");

                    b.HasKey("IdPilote", "IdParapente", "IdAtterissage", "IdDecollage")
                        .HasName("PK__Vol__605EADF09A04B8FD");

                    b.HasIndex("IdAtterissage");

                    b.HasIndex("IdDecollage");

                    b.HasIndex("IdParapente");

                    b.ToTable("Vol");
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Brevet", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Niveau", "IdNiveauNavigation")
                        .WithMany("Brevet")
                        .HasForeignKey("IdNiveau")
                        .HasConstraintName("FK__BREVET__Id_Nivea__3F466844")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Encadre", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Pilote", "IdPiloteNavigation")
                        .WithMany("Encadre")
                        .HasForeignKey("IdPilote")
                        .HasConstraintName("FK__Encadre__Id_Pilo__403A8C7D")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Stage", "IdStageNavigation")
                        .WithMany("Encadre")
                        .HasForeignKey("IdStage")
                        .HasConstraintName("FK__Encadre__Id_Stag__412EB0B6")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Obtient", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Brevet", "IdBrevetNavigation")
                        .WithMany("Obtient")
                        .HasForeignKey("IdBrevet")
                        .HasConstraintName("FK__Obtient__Id_Brev__4222D4EF")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Pilote", "IdPiloteNavigation")
                        .WithMany("Obtient")
                        .HasForeignKey("IdPilote")
                        .HasConstraintName("FK__Obtient__Id_Pilo__4316F928")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Parapente", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.ModeleParapente", "IdModeleNavigation")
                        .WithMany("Parapente")
                        .HasForeignKey("IdModele")
                        .HasConstraintName("FK__PARAPENTE__Id_Mo__440B1D61")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Passe", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Pilote", "IdPiloteNavigation")
                        .WithMany("Passe")
                        .HasForeignKey("IdPilote")
                        .HasConstraintName("FK__Passe__Id_Pilote__44FF419A")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Stage", "IdStageNavigation")
                        .WithMany("Passe")
                        .HasForeignKey("IdStage")
                        .HasConstraintName("FK__Passe__Id_Stage__45F365D3")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Paye", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Cotisation", "IdCotisationNavigation")
                        .WithMany("Paye")
                        .HasForeignKey("IdCotisation")
                        .HasConstraintName("FK__Paye__Id_Cotisat__46E78A0C")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Pilote", "IdPiloteNavigation")
                        .WithMany("Paye")
                        .HasForeignKey("IdPilote")
                        .HasConstraintName("FK__Paye__Id_Pilote__47DBAE45")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Pilote", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Fonction", "IdFonctionNavigation")
                        .WithMany("Pilote")
                        .HasForeignKey("IdFonction")
                        .HasConstraintName("FK__PILOTE__Id_Fonct__48CFD27E")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Stage", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.Brevet", "IdBrevetNavigation")
                        .WithMany("Stage")
                        .HasForeignKey("IdBrevet")
                        .HasConstraintName("FK__STAGE__Id_Brevet__49C3F6B7")
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationParapente.DataModel.Vol", b =>
                {
                    b.HasOne("ApplicationParapente.DataModel.SiteAtterissage", "IdAtterissageNavigation")
                        .WithMany("Vol")
                        .HasForeignKey("IdAtterissage")
                        .HasConstraintName("FK__Vol__Id_Atteriss__4AB81AF0")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.SiteDecollage", "IdDecollageNavigation")
                        .WithMany("Vol")
                        .HasForeignKey("IdDecollage")
                        .HasConstraintName("FK__Vol__Id_Decollag__4BAC3F29")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Parapente", "IdParapenteNavigation")
                        .WithMany("Vol")
                        .HasForeignKey("IdParapente")
                        .HasConstraintName("FK__Vol__Id_Parapent__4CA06362")
                        .IsRequired();

                    b.HasOne("ApplicationParapente.DataModel.Pilote", "IdPiloteNavigation")
                        .WithMany("Vol")
                        .HasForeignKey("IdPilote")
                        .HasConstraintName("FK__Vol__Id_Pilote__4D94879B")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
