using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ScreenSound2._0.Migrations
{
    /// <inheritdoc />
    public partial class CreateTbSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_songs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    band_id = table.Column<int>(type: "integer", nullable: false),
                    album_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_songs", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_songs_tb_albums_album_id",
                        column: x => x.album_id,
                        principalTable: "tb_albums",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_songs_tb_bands_band_id",
                        column: x => x.band_id,
                        principalTable: "tb_bands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_songs_album_id",
                table: "tb_songs",
                column: "album_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_songs_band_id",
                table: "tb_songs",
                column: "band_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_songs");
        }
    }
}
