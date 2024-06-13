using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace s1110834035_NetFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoCountToAlbums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Albums_AlbumsId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_AlbumsId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "AlbumsId",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "PhotoCount",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PhotoCount" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7904), 5 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PhotoCount" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7906), 1 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PhotoCount" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7907), 1 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7887));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoCount",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "AlbumsId",
                table: "Photos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AlbumsId", "UploadDate" },
                values: new object[] { null, new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AlbumsId",
                table: "Photos",
                column: "AlbumsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Albums_AlbumsId",
                table: "Photos",
                column: "AlbumsId",
                principalTable: "Albums",
                principalColumn: "Id");
        }
    }
}
