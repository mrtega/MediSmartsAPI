using Microsoft.EntityFrameworkCore.Migrations;

namespace MediSmartsAPI.Data.Migrations
{
    public partial class first111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Registrations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Registrations");
        }
    }
}
