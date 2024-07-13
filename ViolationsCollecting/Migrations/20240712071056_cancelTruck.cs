using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViolationsCollecting.Migrations
{
    /// <inheritdoc />
    public partial class cancelTruck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Trucks_TruckCode",
                table: "Violations");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Violations_TruckCode",
                table: "Violations");

            migrationBuilder.AlterColumn<string>(
                name: "TruckCode",
                table: "Violations",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TruckCode",
                table: "Violations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    TruckCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsExplored = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.TruckCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Violations_TruckCode",
                table: "Violations",
                column: "TruckCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Trucks_TruckCode",
                table: "Violations",
                column: "TruckCode",
                principalTable: "Trucks",
                principalColumn: "TruckCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
