using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotifei.Migrations
{
    /// <inheritdoc />
    public partial class AddInfoPlaylistMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistMusicas_Musicas_MusicaId",
                table: "PlaylistMusicas");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistMusicas_Playlists_PlaylistId",
                table: "PlaylistMusicas");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "PlaylistMusicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MusicaId",
                table: "PlaylistMusicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "PlaylistMusicas",
                columns: new[] { "Id", "IdMusica", "IdPlaylist", "MusicaId", "PlaylistId" },
                values: new object[] { 1, 1, 1, null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistMusicas_Musicas_MusicaId",
                table: "PlaylistMusicas",
                column: "MusicaId",
                principalTable: "Musicas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistMusicas_Playlists_PlaylistId",
                table: "PlaylistMusicas",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistMusicas_Musicas_MusicaId",
                table: "PlaylistMusicas");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistMusicas_Playlists_PlaylistId",
                table: "PlaylistMusicas");

            migrationBuilder.DeleteData(
                table: "PlaylistMusicas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "PlaylistMusicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MusicaId",
                table: "PlaylistMusicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistMusicas_Musicas_MusicaId",
                table: "PlaylistMusicas",
                column: "MusicaId",
                principalTable: "Musicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistMusicas_Playlists_PlaylistId",
                table: "PlaylistMusicas",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
