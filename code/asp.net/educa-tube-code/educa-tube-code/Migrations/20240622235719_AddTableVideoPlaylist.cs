using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace educa_tube_code.Migrations
{
    /// <inheritdoc />
    public partial class AddTableVideoPlaylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoPlaylist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    PlaylistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoPlaylist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoPlaylist_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoPlaylist_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoPlaylist_PlaylistId",
                table: "VideoPlaylist",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoPlaylist_VideoId",
                table: "VideoPlaylist",
                column: "VideoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoPlaylist");
        }
    }
}
