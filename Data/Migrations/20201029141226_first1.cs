using Microsoft.EntityFrameworkCore.Migrations;

namespace MediSmartsAPI.Data.Migrations
{
    public partial class first1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Registrations");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Registrations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Registrations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Registrations",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Password",
                table: "Registrations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Registrations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Registrations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Registrations");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Registrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Registrations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Registrations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
