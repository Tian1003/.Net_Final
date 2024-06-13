using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace s1110834035_NetFinal.Migrations
{
    /// <inheritdoc />
    public partial class MyNewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadDate",
                value: new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7762), "Justin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7774), "Milly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 13, 28, 125, DateTimeKind.Local).AddTicks(7775), "Lucy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7907));

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
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7874), "user1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7886), "user2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RegistrationDate", "UserName" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 46, 26, 257, DateTimeKind.Local).AddTicks(7887), "user3" });
        }
    }
}
