using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class mobilemn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
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
                name: "MobileNumber",
                schema: "dbo",
                table: "tbl_UserMaster");
        }
    }
}
