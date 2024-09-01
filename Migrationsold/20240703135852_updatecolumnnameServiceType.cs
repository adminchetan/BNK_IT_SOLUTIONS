using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class updatecolumnnameServiceType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerivceType",
                schema: "dbo",
                table: "tbl_ServicesMaster",
                newName: "ServiceType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceType",
                schema: "dbo",
                table: "tbl_ServicesMaster",
                newName: "SerivceType");
        }
    }
}
