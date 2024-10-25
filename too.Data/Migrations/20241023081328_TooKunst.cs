using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace too.Data.Migrations
{
    /// <inheritdoc />
    public partial class TooKunst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KunstiOmanik",
                columns: table => new
                {
                    OmanikuNimi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KunstiOmanikuVanus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KunstiOmanik", x => x.OmanikuNimi);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KunstiOmanik");
        }
    }
}
