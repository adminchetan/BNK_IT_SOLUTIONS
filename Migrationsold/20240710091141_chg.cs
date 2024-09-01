using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class chg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                schema: "dbo",
                table: "tbl_UserMaster",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "tbl_UserMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "dbo",
                table: "tbl_UserMaster");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "dbo",
                table: "tbl_UserMaster",
                newName: "UserName");
        }
    }
}
