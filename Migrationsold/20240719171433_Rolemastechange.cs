using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class Rolemastechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.AddColumn<string>(
                name: "AdminDashboard",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminRoleManager",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminUserCreation",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClientRoleManager",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientUserCreation",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminDashboard",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "AdminRoleManager",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "AdminUserCreation",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "ClientId",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "ClientRoleManager",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.DropColumn(
                name: "ClientUserCreation",
                schema: "dbo",
                table: "tbl_RoleMaster");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                schema: "dbo",
                table: "tbl_RoleMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
