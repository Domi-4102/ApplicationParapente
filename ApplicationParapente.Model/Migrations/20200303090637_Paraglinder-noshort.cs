using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationParapente.DataModel.Migrations
{
    public partial class Paraglindernoshort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Take",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "supervise",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PILOT",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pay",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Obtain",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Id_PILOT",
                table: "Fly",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "Take",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "supervise",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "PILOT",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "Pay",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "Obtain",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Id_PILOT",
                table: "Fly",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
