using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Building.DataLayer.Migrations
{
    public partial class Mig_Bulletin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bulletins",
                columns: table => new
                {
                    BulletinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BulletinHeader = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    BulletinText = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    BulletinImg = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulletins", x => x.BulletinId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bulletins");
        }
    }
}
