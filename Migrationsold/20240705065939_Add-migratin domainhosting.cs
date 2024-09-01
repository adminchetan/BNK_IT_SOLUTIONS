using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class Addmigratindomainhosting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_ClientDomainDetails",
                schema: "dbo",
                columns: table => new
                {
                    DomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    HostingId = table.Column<int>(type: "int", nullable: false),
                    ServerIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiaryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientDomainDetails", x => x.DomainId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientHostingDetails",
                schema: "dbo",
                columns: table => new
                {
                    HostingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ServerIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiaryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientHostingDetails", x => x.HostingId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_ClientDomainDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbl_ClientHostingDetails",
                schema: "dbo");
        }
    }
}
