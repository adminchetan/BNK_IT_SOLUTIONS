using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class addnewroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AdminApproval",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ClientPayment",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminApproval",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "ClientPayment",
                schema: "dbo",
                table: "tbl_RoleMaster");
        }
    }
}
