using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyVokabulary.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LanguageDoublets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RusianWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglisfWord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageDoublets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageDoubletUser",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    languageDoubletsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageDoubletUser", x => new { x.UsersId, x.languageDoubletsId });
                    table.ForeignKey(
                        name: "FK_LanguageDoubletUser_LanguageDoublets_languageDoubletsId",
                        column: x => x.languageDoubletsId,
                        principalTable: "LanguageDoublets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageDoubletUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageDoubletUser_languageDoubletsId",
                table: "LanguageDoubletUser",
                column: "languageDoubletsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageDoubletUser");

            migrationBuilder.DropTable(
                name: "LanguageDoublets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
