using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interplanetary_delivery_simulator.Migrations
{
    /// <inheritdoc />
    public partial class OrbitInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Planets",
                newName: "Information_Type");

            migrationBuilder.RenameColumn(
                name: "PersonCount",
                table: "Planets",
                newName: "Information_PersonCount");

            migrationBuilder.RenameColumn(
                name: "PersonCapacity",
                table: "Planets",
                newName: "Information_PersonCapacity");

            migrationBuilder.RenameColumn(
                name: "MilesFromEarth",
                table: "Planets",
                newName: "Orbit_YCoordinate");

            migrationBuilder.AddColumn<double>(
                name: "Orbit_EarthMasses",
                table: "Planets",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "Orbit_OrbitsAroundId",
                table: "Planets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "Orbit_XCoordinate",
                table: "Planets",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Planets_Orbit_OrbitsAroundId",
                table: "Planets",
                column: "Orbit_OrbitsAroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Planets_Orbit_OrbitsAroundId",
                table: "Planets",
                column: "Orbit_OrbitsAroundId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Planets_Orbit_OrbitsAroundId",
                table: "Planets");

            migrationBuilder.DropIndex(
                name: "IX_Planets_Orbit_OrbitsAroundId",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Orbit_EarthMasses",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Orbit_OrbitsAroundId",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Orbit_XCoordinate",
                table: "Planets");

            migrationBuilder.RenameColumn(
                name: "Information_Type",
                table: "Planets",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Information_PersonCount",
                table: "Planets",
                newName: "PersonCount");

            migrationBuilder.RenameColumn(
                name: "Information_PersonCapacity",
                table: "Planets",
                newName: "PersonCapacity");

            migrationBuilder.RenameColumn(
                name: "Orbit_YCoordinate",
                table: "Planets",
                newName: "MilesFromEarth");
        }
    }
}
