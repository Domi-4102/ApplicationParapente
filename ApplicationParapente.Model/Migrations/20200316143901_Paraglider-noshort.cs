using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationParapente.DataModel.Migrations
{
    public partial class Paraglidernoshort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FONCTION",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Label = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FONCTION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Label = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberShipFee",
                columns: table => new
                {
                    AmountYear = table.Column<DateTime>(type: "date", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(15, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MemberSh__FE3924B45CF0786B", x => x.AmountYear);
                });

            migrationBuilder.CreateTable(
                name: "ParagliderModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NumberOfHomologation = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    HomologationDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Size = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    MinWeight = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    MaxWeight = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParagliderModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PILOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    Adress = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Tel = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Id_FONCTION = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PILOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PILOT__Id_FONCTI__4BAC3F29",
                        column: x => x.Id_FONCTION,
                        principalTable: "FONCTION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Label = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Id_Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Certifica__Id_Le__3F466844",
                        column: x => x.Id_Level,
                        principalTable: "Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandingSite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Orientation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Id_Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingSite", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LandingSi__Id_Le__44FF419A",
                        column: x => x.Id_Level,
                        principalTable: "Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaunchingSite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Orientation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Id_Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchingSite", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Launching__Id_Le__45F365D3",
                        column: x => x.Id_Level,
                        principalTable: "Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paraglider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUseService = table.Column<DateTime>(type: "date", nullable: true),
                    Id_Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paraglider", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Paraglide__Id_Le__48CFD27E",
                        column: x => x.Id_Level,
                        principalTable: "ParagliderModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AmountYear = table.Column<DateTime>(type: "date", nullable: false),
                    DateCotisation = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pay__6DF77E4CE87ECC17", x => new { x.Id, x.AmountYear });
                    table.ForeignKey(
                        name: "FK__Pay__AmountYear__49C3F6B7",
                        column: x => x.AmountYear,
                        principalTable: "MemberShipFee",
                        principalColumn: "AmountYear",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Pay__Id__4AB81AF0",
                        column: x => x.Id,
                        principalTable: "PILOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Internship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    Id_Certificate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internship", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Internshi__Id_Ce__440B1D61",
                        column: x => x.Id_Certificate,
                        principalTable: "Certificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obtain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Id_Certificate = table.Column<int>(nullable: false),
                    ObtainingDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Obtain__B4A2F4C4BFD1C4A5", x => new { x.Id, x.Id_Certificate });
                    table.ForeignKey(
                        name: "FK__Obtain__Id__46E78A0C",
                        column: x => x.Id,
                        principalTable: "PILOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Obtain__Id_Certi__47DBAE45",
                        column: x => x.Id_Certificate,
                        principalTable: "Certificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DateFly = table.Column<DateTime>(type: "date", nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true),
                    Id_LandingSite = table.Column<int>(nullable: false),
                    Id_LaunchingSite = table.Column<int>(nullable: false),
                    Id_PILOT = table.Column<int>(nullable: false),
                    Id_Paraglider = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fly", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Fly__Id_LandingS__403A8C7D",
                        column: x => x.Id_LandingSite,
                        principalTable: "LandingSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Fly__Id_Launchin__412EB0B6",
                        column: x => x.Id_LaunchingSite,
                        principalTable: "LaunchingSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Fly__Id_Paraglid__4222D4EF",
                        column: x => x.Id_Paraglider,
                        principalTable: "Paraglider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Fly__Id_PILOT__4316F928",
                        column: x => x.Id_PILOT,
                        principalTable: "PILOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "supervise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Id_Internship = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__supervis__095D1154D14E60AE", x => new { x.Id, x.Id_Internship });
                    table.ForeignKey(
                        name: "FK__supervise__Id__4CA06362",
                        column: x => x.Id,
                        principalTable: "PILOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__supervise__Id_In__4D94879B",
                        column: x => x.Id_Internship,
                        principalTable: "Internship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Take",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Id_Internship = table.Column<int>(nullable: false),
                    examen = table.Column<bool>(nullable: false),
                    Payement = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Take__095D1154131AF90A", x => new { x.Id, x.Id_Internship });
                    table.ForeignKey(
                        name: "FK__Take__Id__4E88ABD4",
                        column: x => x.Id,
                        principalTable: "PILOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Take__Id_Interns__4F7CD00D",
                        column: x => x.Id_Internship,
                        principalTable: "Internship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_Id_Level",
                table: "Certificate",
                column: "Id_Level");

            migrationBuilder.CreateIndex(
                name: "IX_Fly_Id_LandingSite",
                table: "Fly",
                column: "Id_LandingSite");

            migrationBuilder.CreateIndex(
                name: "IX_Fly_Id_LaunchingSite",
                table: "Fly",
                column: "Id_LaunchingSite");

            migrationBuilder.CreateIndex(
                name: "IX_Fly_Id_Paraglider",
                table: "Fly",
                column: "Id_Paraglider");

            migrationBuilder.CreateIndex(
                name: "IX_Fly_Id_PILOT",
                table: "Fly",
                column: "Id_PILOT");

            migrationBuilder.CreateIndex(
                name: "IX_Internship_Id_Certificate",
                table: "Internship",
                column: "Id_Certificate");

            migrationBuilder.CreateIndex(
                name: "IX_LandingSite_Id_Level",
                table: "LandingSite",
                column: "Id_Level");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchingSite_Id_Level",
                table: "LaunchingSite",
                column: "Id_Level");

            migrationBuilder.CreateIndex(
                name: "IX_Obtain_Id_Certificate",
                table: "Obtain",
                column: "Id_Certificate");

            migrationBuilder.CreateIndex(
                name: "IX_Paraglider_Id_Level",
                table: "Paraglider",
                column: "Id_Level");

            migrationBuilder.CreateIndex(
                name: "UQ__Paraglid__1B6B7341D68F3614",
                table: "ParagliderModel",
                column: "NumberOfHomologation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pay_AmountYear",
                table: "Pay",
                column: "AmountYear");

            migrationBuilder.CreateIndex(
                name: "IX_PILOT_Id_FONCTION",
                table: "PILOT",
                column: "Id_FONCTION");

            migrationBuilder.CreateIndex(
                name: "IX_supervise_Id_Internship",
                table: "supervise",
                column: "Id_Internship");

            migrationBuilder.CreateIndex(
                name: "IX_Take_Id_Internship",
                table: "Take",
                column: "Id_Internship");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fly");

            migrationBuilder.DropTable(
                name: "Obtain");

            migrationBuilder.DropTable(
                name: "Pay");

            migrationBuilder.DropTable(
                name: "supervise");

            migrationBuilder.DropTable(
                name: "Take");

            migrationBuilder.DropTable(
                name: "LandingSite");

            migrationBuilder.DropTable(
                name: "LaunchingSite");

            migrationBuilder.DropTable(
                name: "Paraglider");

            migrationBuilder.DropTable(
                name: "MemberShipFee");

            migrationBuilder.DropTable(
                name: "PILOT");

            migrationBuilder.DropTable(
                name: "Internship");

            migrationBuilder.DropTable(
                name: "ParagliderModel");

            migrationBuilder.DropTable(
                name: "FONCTION");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Level");
        }
    }
}
