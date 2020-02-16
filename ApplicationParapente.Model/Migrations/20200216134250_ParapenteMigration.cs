using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationParapente.DataModel.Migrations
{
    public partial class ParapenteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COTISATION",
                columns: table => new
                {
                    Id_Cotisation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    AnnéeCotisation = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COTISATI__F3DA9ACA5D45871F", x => x.Id_Cotisation);
                });

            migrationBuilder.CreateTable(
                name: "FONCTION",
                columns: table => new
                {
                    Id_Fonction = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FONCTION__91F04474B198408F", x => x.Id_Fonction);
                });

            migrationBuilder.CreateTable(
                name: "MODELE_PARAPENTE",
                columns: table => new
                {
                    Id_Modele = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroHomologation = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    dateHomologation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Taille = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    PoidsMin = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    PoidMax = table.Column<decimal>(type: "decimal(15, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MODELE_P__D5BA161C39564CAB", x => x.Id_Modele);
                });

            migrationBuilder.CreateTable(
                name: "NIVEAU",
                columns: table => new
                {
                    Id_Niveau = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitulé = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NIVEAU__2033157735765FF4", x => x.Id_Niveau);
                });

            migrationBuilder.CreateTable(
                name: "SITE_ATTERISSAGE",
                columns: table => new
                {
                    Id_Atterissage = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Orientation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NiveauRequis = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SITE_ATT__73E7E7945E4B48B9", x => x.Id_Atterissage);
                });

            migrationBuilder.CreateTable(
                name: "SITE_DECOLLAGE",
                columns: table => new
                {
                    Id_Decollage = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Orientation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    NiveauRequis = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SITE_DEC__04FEF9BA1FB39D0D", x => x.Id_Decollage);
                });

            migrationBuilder.CreateTable(
                name: "PILOTE",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Prenom = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Poids = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    Adresse = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Tel = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Id_Fonction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PILOTE__884F15358E0CBE76", x => x.Id_Pilote);
                    table.ForeignKey(
                        name: "FK__PILOTE__Id_Fonct__48CFD27E",
                        column: x => x.Id_Fonction,
                        principalTable: "FONCTION",
                        principalColumn: "Id_Fonction",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PARAPENTE",
                columns: table => new
                {
                    Id_Parapente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateMiseEnService = table.Column<DateTime>(type: "date", nullable: true),
                    DateDerniereRevision = table.Column<DateTime>(type: "date", nullable: true),
                    Id_Modele = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PARAPENT__6D210CDF4AA2CFF2", x => x.Id_Parapente);
                    table.ForeignKey(
                        name: "FK__PARAPENTE__Id_Mo__440B1D61",
                        column: x => x.Id_Modele,
                        principalTable: "MODELE_PARAPENTE",
                        principalColumn: "Id_Modele",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BREVET",
                columns: table => new
                {
                    Id_Brevet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Id_Niveau = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BREVET__042931069F1C72B7", x => x.Id_Brevet);
                    table.ForeignKey(
                        name: "FK__BREVET__Id_Nivea__3F466844",
                        column: x => x.Id_Niveau,
                        principalTable: "NIVEAU",
                        principalColumn: "Id_Niveau",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paye",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false),
                    Id_Cotisation = table.Column<int>(nullable: false),
                    DateCotisation = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paye__3772BC99194BE957", x => new { x.Id_Pilote, x.Id_Cotisation });
                    table.ForeignKey(
                        name: "FK__Paye__Id_Cotisat__46E78A0C",
                        column: x => x.Id_Cotisation,
                        principalTable: "COTISATION",
                        principalColumn: "Id_Cotisation",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Paye__Id_Pilote__47DBAE45",
                        column: x => x.Id_Pilote,
                        principalTable: "PILOTE",
                        principalColumn: "Id_Pilote",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vol",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false),
                    Id_Parapente = table.Column<int>(nullable: false),
                    Id_Atterissage = table.Column<int>(nullable: false),
                    Id_Decollage = table.Column<int>(nullable: false),
                    DateVol = table.Column<DateTime>(type: "date", nullable: true),
                    DureeVol = table.Column<decimal>(type: "decimal(15, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vol__605EADF09A04B8FD", x => new { x.Id_Pilote, x.Id_Parapente, x.Id_Atterissage, x.Id_Decollage });
                    table.ForeignKey(
                        name: "FK__Vol__Id_Atteriss__4AB81AF0",
                        column: x => x.Id_Atterissage,
                        principalTable: "SITE_ATTERISSAGE",
                        principalColumn: "Id_Atterissage",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vol__Id_Decollag__4BAC3F29",
                        column: x => x.Id_Decollage,
                        principalTable: "SITE_DECOLLAGE",
                        principalColumn: "Id_Decollage",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vol__Id_Parapent__4CA06362",
                        column: x => x.Id_Parapente,
                        principalTable: "PARAPENTE",
                        principalColumn: "Id_Parapente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vol__Id_Pilote__4D94879B",
                        column: x => x.Id_Pilote,
                        principalTable: "PILOTE",
                        principalColumn: "Id_Pilote",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obtient",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false),
                    Id_Brevet = table.Column<int>(nullable: false),
                    DateObtention = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Obtient__F80D86256FBD686E", x => new { x.Id_Pilote, x.Id_Brevet });
                    table.ForeignKey(
                        name: "FK__Obtient__Id_Brev__4222D4EF",
                        column: x => x.Id_Brevet,
                        principalTable: "BREVET",
                        principalColumn: "Id_Brevet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Obtient__Id_Pilo__4316F928",
                        column: x => x.Id_Pilote,
                        principalTable: "PILOTE",
                        principalColumn: "Id_Pilote",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STAGE",
                columns: table => new
                {
                    Id_Stage = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "date", nullable: true),
                    DateFin = table.Column<DateTime>(type: "date", nullable: true),
                    Prix = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    NiveauRequis = table.Column<int>(nullable: true),
                    Id_Brevet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__STAGE__3FD8835DEBCD370C", x => x.Id_Stage);
                    table.ForeignKey(
                        name: "FK__STAGE__Id_Brevet__49C3F6B7",
                        column: x => x.Id_Brevet,
                        principalTable: "BREVET",
                        principalColumn: "Id_Brevet",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Encadre",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false),
                    Id_Stage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Encadre__4BB29D007972F5A7", x => new { x.Id_Pilote, x.Id_Stage });
                    table.ForeignKey(
                        name: "FK__Encadre__Id_Pilo__403A8C7D",
                        column: x => x.Id_Pilote,
                        principalTable: "PILOTE",
                        principalColumn: "Id_Pilote",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Encadre__Id_Stag__412EB0B6",
                        column: x => x.Id_Stage,
                        principalTable: "STAGE",
                        principalColumn: "Id_Stage",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passe",
                columns: table => new
                {
                    Id_Pilote = table.Column<int>(nullable: false),
                    Id_Stage = table.Column<int>(nullable: false),
                    examen = table.Column<bool>(nullable: false),
                    Payement = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Passe__4BB29D000E1CA7D0", x => new { x.Id_Pilote, x.Id_Stage });
                    table.ForeignKey(
                        name: "FK__Passe__Id_Pilote__44FF419A",
                        column: x => x.Id_Pilote,
                        principalTable: "PILOTE",
                        principalColumn: "Id_Pilote",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Passe__Id_Stage__45F365D3",
                        column: x => x.Id_Stage,
                        principalTable: "STAGE",
                        principalColumn: "Id_Stage",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BREVET_Id_Niveau",
                table: "BREVET",
                column: "Id_Niveau");

            migrationBuilder.CreateIndex(
                name: "IX_Encadre_Id_Stage",
                table: "Encadre",
                column: "Id_Stage");

            migrationBuilder.CreateIndex(
                name: "UQ__MODELE_P__926D7EA43C48F393",
                table: "MODELE_PARAPENTE",
                column: "NumeroHomologation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Obtient_Id_Brevet",
                table: "Obtient",
                column: "Id_Brevet");

            migrationBuilder.CreateIndex(
                name: "IX_PARAPENTE_Id_Modele",
                table: "PARAPENTE",
                column: "Id_Modele");

            migrationBuilder.CreateIndex(
                name: "IX_Passe_Id_Stage",
                table: "Passe",
                column: "Id_Stage");

            migrationBuilder.CreateIndex(
                name: "IX_Paye_Id_Cotisation",
                table: "Paye",
                column: "Id_Cotisation");

            migrationBuilder.CreateIndex(
                name: "IX_PILOTE_Id_Fonction",
                table: "PILOTE",
                column: "Id_Fonction");

            migrationBuilder.CreateIndex(
                name: "IX_STAGE_Id_Brevet",
                table: "STAGE",
                column: "Id_Brevet");

            migrationBuilder.CreateIndex(
                name: "IX_Vol_Id_Atterissage",
                table: "Vol",
                column: "Id_Atterissage");

            migrationBuilder.CreateIndex(
                name: "IX_Vol_Id_Decollage",
                table: "Vol",
                column: "Id_Decollage");

            migrationBuilder.CreateIndex(
                name: "IX_Vol_Id_Parapente",
                table: "Vol",
                column: "Id_Parapente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encadre");

            migrationBuilder.DropTable(
                name: "Obtient");

            migrationBuilder.DropTable(
                name: "Passe");

            migrationBuilder.DropTable(
                name: "Paye");

            migrationBuilder.DropTable(
                name: "Vol");

            migrationBuilder.DropTable(
                name: "STAGE");

            migrationBuilder.DropTable(
                name: "COTISATION");

            migrationBuilder.DropTable(
                name: "SITE_ATTERISSAGE");

            migrationBuilder.DropTable(
                name: "SITE_DECOLLAGE");

            migrationBuilder.DropTable(
                name: "PARAPENTE");

            migrationBuilder.DropTable(
                name: "PILOTE");

            migrationBuilder.DropTable(
                name: "BREVET");

            migrationBuilder.DropTable(
                name: "MODELE_PARAPENTE");

            migrationBuilder.DropTable(
                name: "FONCTION");

            migrationBuilder.DropTable(
                name: "NIVEAU");
        }
    }
}
