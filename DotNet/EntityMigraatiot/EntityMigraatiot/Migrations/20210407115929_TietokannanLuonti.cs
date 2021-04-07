using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityMigraatiot.Migrations
{
    public partial class TietokannanLuonti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tehtävät",
                columns: table => new
                {
                    TehtäväId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Otsikko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valmis = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tehtävät", x => x.TehtäväId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tehtävät");
        }
    }
}
