using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interplanetary_delivery_simulator.Migrations
{
    /// <inheritdoc />
    public partial class LunarLogiticsDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
