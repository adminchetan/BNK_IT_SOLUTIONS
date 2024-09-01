using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uttaraonline.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNavigationTables0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF OBJECT_ID('dbo.tbl_Navigation', 'U') IS NOT NULL
            DROP TABLE dbo.tbl_Navigation;
        ");

            // Drop tbl_NavSubMenu if it exists
            migrationBuilder.Sql(@"
            IF OBJECT_ID('dbo.tbl_NavSubMenu', 'U') IS NOT NULL
            DROP TABLE dbo.tbl_NavSubMenu;
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Navigation",
                schema: "dbo",
                columns: table => new
                {
                    NavigationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faclass = table.Column<string>(name: "fa_class", type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    navigationid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Navigation", x => x.NavigationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_NavSubMenu",
                schema: "dbo",
                columns: table => new
                {
                    SubNavigationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faclass = table.Column<string>(name: "fa_class", type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_NavSubMenu", x => x.SubNavigationId);
                });
        }
    }
}
