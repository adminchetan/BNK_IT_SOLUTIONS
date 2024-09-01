using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class ht : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_HostingDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyBandwidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAccount = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Backup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessToCpannel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessToFTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outlet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wholesale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CGST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HostingDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_HostingDetails",
                schema: "dbo");
        }
    }
}
