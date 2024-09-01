using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationhosting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HostingDetails",
                schema: "dbo",
                table: "tbl_ClientHostingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HostingName",
                schema: "dbo",
                table: "tbl_ClientHostingDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DomainDetails",
                schema: "dbo",
                table: "tbl_ClientDomainDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DomainName",
                schema: "dbo",
                table: "tbl_ClientDomainDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HostingDetails",
                schema: "dbo",
                table: "tbl_ClientHostingDetails");

            migrationBuilder.DropColumn(
                name: "HostingName",
                schema: "dbo",
                table: "tbl_ClientHostingDetails");

            migrationBuilder.DropColumn(
                name: "DomainDetails",
                schema: "dbo",
                table: "tbl_ClientDomainDetails");

            migrationBuilder.DropColumn(
                name: "DomainName",
                schema: "dbo",
                table: "tbl_ClientDomainDetails");
        }
    }
}
