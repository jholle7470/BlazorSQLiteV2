using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSQLiteV2.data.migrations
{
    /// <inheritdoc />
    public partial class _1stMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostPictures",
                columns: table => new
                {
                    PostPictureId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostPictureName = table.Column<string>(type: "TEXT", nullable: false),
                    PostPictureUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPictures", x => x.PostPictureId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    PostMessage = table.Column<string>(type: "TEXT", nullable: false),
                    PostDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    PostPictureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_PostPictures_PostPictureId",
                        column: x => x.PostPictureId,
                        principalTable: "PostPictures",
                        principalColumn: "PostPictureId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostPictureId",
                table: "Posts",
                column: "PostPictureId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "PostPictures");
        }
    }
}
