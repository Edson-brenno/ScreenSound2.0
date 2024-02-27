using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ScreenSound2._0.Migrations
{
    /// <inheritdoc />
    public partial class AddTbAlbums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_albums",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    band_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_albums", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_albums_tb_bands_band_id",
                        column: x => x.band_id,
                        principalTable: "tb_bands",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_albums_band_id",
                table: "tb_albums",
                column: "band_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_albums");
        }
    }
}
