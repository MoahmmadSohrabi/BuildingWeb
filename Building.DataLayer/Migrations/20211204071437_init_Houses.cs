using Microsoft.EntityFrameworkCore.Migrations;

namespace Building.DataLayer.Migrations
{
    public partial class init_Houses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HouseInformations",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Floor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Facility = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseInformations", x => x.HouseId);
                });

            migrationBuilder.CreateTable(
                name: "HouseRoles",
                columns: table => new
                {
                    HouseRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseRoleTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseRoles", x => x.HouseRoleId);
                });

            migrationBuilder.CreateTable(
                name: "UserToHouses",
                columns: table => new
                {
                    UT_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HouseRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToHouses", x => x.UT_Id);
                    table.ForeignKey(
                        name: "FK_UserToHouses_HouseInformations_HouseId",
                        column: x => x.HouseId,
                        principalTable: "HouseInformations",
                        principalColumn: "HouseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToHouses_HouseRoles_HouseRoleId",
                        column: x => x.HouseRoleId,
                        principalTable: "HouseRoles",
                        principalColumn: "HouseRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToHouses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserToHouses_HouseId",
                table: "UserToHouses",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToHouses_HouseRoleId",
                table: "UserToHouses",
                column: "HouseRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToHouses_UserId",
                table: "UserToHouses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserToHouses");

            migrationBuilder.DropTable(
                name: "HouseInformations");

            migrationBuilder.DropTable(
                name: "HouseRoles");
        }
    }
}
