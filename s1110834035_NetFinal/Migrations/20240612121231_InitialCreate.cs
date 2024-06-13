using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace s1110834035_NetFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PhotoCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AlbumsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumName", "CreationDate", "Description", "PhotoCount", "UserId" },
                values: new object[,]
                {
                    { 1, "相簿1", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3746), "相簿描述", 5, 1 },
                    { 2, "相簿2", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3750), "相簿描述", 1, 2 },
                    { 3, "相簿3", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3751), "相簿描述", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AlbumId", "AlbumsId", "Description", "FilePath", "PhotoName", "UploadDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "photo1 description", "img1.jpg", "photo1", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3795), 1 },
                    { 2, 2, null, "photo2 description", "img2.jpg", "photo2", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3799), 2 },
                    { 3, 3, null, "photo3 description", "img3.jpg", "photo3", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3800), 3 },
                    { 4, 1, null, "photo3 description", "img4.jpg", "photo4", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3801), 1 },
                    { 5, 1, null, "photo3 description", "img5.jpg", "photo5", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3802), 1 },
                    { 6, 1, null, "photo3 description", "img6.jpg", "photo6", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3802), 1 },
                    { 7, 1, null, "photo3 description", "img7.jpg", "photo7", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3803), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgF",
                value: "img1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgF",
                value: "img1.jpg");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "RegistrationDate", "UserName" },
                values: new object[,]
                {
                    { 1, "hapopo35@gmail.com", "a1", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3718), "user1" },
                    { 2, "user2@example.com", "a2", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3730), "user2" },
                    { 3, "user3@example.com", "a3", new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3731), "user3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AlbumsId",
                table: "Photos",
                column: "AlbumsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgF",
                value: "img3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgF",
                value: "img4.jpg");
        }
    }
}
