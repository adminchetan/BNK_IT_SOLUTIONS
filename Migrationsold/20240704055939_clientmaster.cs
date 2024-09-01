using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class clientmaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_ClientMaster",
                schema: "dbo",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientBuiisnessEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimarContactCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimarContactState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimarContactCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimarContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMaster", x => x.ClientId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_ClientMaster",
                schema: "dbo");
        }
    }
}
