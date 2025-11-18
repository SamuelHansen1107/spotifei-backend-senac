using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotifei.Migrations
{
    /// <inheritdoc />
    public partial class AddInfoPlaylists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Usuarios_usuarioId",
                table: "Playlists");

            migrationBuilder.AlterColumn<int>(
                name: "usuarioId",
                table: "Playlists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "DataCriacao", "IdUsuario", "Nome", "usuarioId" },
                values: new object[] { 1, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Playlist Exemplo", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Usuarios_usuarioId",
                table: "Playlists",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Usuarios_usuarioId",
                table: "Playlists");

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioId",
                table: "Playlists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Usuarios_usuarioId",
                table: "Playlists",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
