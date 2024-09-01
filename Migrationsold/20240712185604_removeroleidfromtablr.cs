using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class removeroleidfromtablr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roleId",
                schema: "dbo",
                table: "tbl_NavSubMenu");

            migrationBuilder.DropColumn(
                name: "roleId",
                schema: "dbo",
                table: "tbl_Navigation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "roleId",
                schema: "dbo",
                table: "tbl_NavSubMenu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "roleId",
                schema: "dbo",
                table: "tbl_Navigation",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
