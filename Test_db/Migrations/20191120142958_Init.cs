using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_db.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "newss",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    institution = table.Column<int>(nullable: false),
                    t = table.Column<DateTime>(nullable: false),
                    place = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    top_img = table.Column<byte[]>(nullable: true),
                    IDPlace = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newss", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "qrs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    top_img = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qrs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "reminds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    from = table.Column<DateTime>(nullable: false),
                    to = table.Column<DateTime>(nullable: false),
                    place = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reminds", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newss");

            migrationBuilder.DropTable(
                name: "qrs");

            migrationBuilder.DropTable(
                name: "reminds");
        }
    }
}
