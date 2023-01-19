using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rusu_Iuliana_ECTS.Migrations
{
    public partial class AfterCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "Biscuit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biscuit_PublisherID",
                table: "Biscuit",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Biscuit_Publisher_PublisherID",
                table: "Biscuit",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biscuit_Publisher_PublisherID",
                table: "Biscuit");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Biscuit_PublisherID",
                table: "Biscuit");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "Biscuit");
        }
    }
}
