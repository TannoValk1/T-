using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace too.Data.Migrations
{
    /// <inheritdoc />
    public partial class KunstiToo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunstiteosed",
                columns: table => new
                {
                    KunstiteoseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeoseNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaalimiseAasta = table.Column<int>(type: "int", nullable: false),
                    Kunstnik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunstiteosed", x => x.KunstiteoseID);
                });

            migrationBuilder.CreateTable(
                name: "Kunstityyp",
                columns: table => new
                {
                    skulptuur = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunstityyp", x => x.skulptuur);
                });

            migrationBuilder.CreateTable(
                name: "Kunstnik",
                columns: table => new
                {
                    KunstnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KunstnikuNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vanus = table.Column<int>(type: "int", nullable: false),
                    KunstiTyyp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunstnik", x => x.KunstnikId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunstiteosed");

            migrationBuilder.DropTable(
                name: "Kunstityyp");

            migrationBuilder.DropTable(
                name: "Kunstnik");
        }
    }
}
