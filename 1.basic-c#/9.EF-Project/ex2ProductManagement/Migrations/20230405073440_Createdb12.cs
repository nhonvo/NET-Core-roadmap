using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ex2ProductManagement.Migrations
{
    /// <inheritdoc />
    public partial class Createdb12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductName",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
