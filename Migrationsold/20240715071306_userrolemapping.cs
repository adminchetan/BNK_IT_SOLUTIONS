using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class userrolemapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "tbl_RoleMaster");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
