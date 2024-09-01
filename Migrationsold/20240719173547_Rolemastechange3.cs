using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class Rolemastechange3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientRoleManager",
                schema: "dbo",
                table: "tbl_RoleMaster",
                newName: "Clientdashboard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Clientdashboard",
                schema: "dbo",
                table: "tbl_RoleMaster",
                newName: "ClientRoleManager");
        }
    }
}
