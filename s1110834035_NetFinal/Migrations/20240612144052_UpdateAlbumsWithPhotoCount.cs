using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace s1110834035_NetFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAlbumsWithPhotoCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoCount",
                table: "Albums");

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
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 22, 40, 51, 633, DateTimeKind.Local).AddTicks(4852));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3746), 5 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PhotoCount" },
                values: new object[] { new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3750), 1 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PhotoCount" },
                values: new object[] { new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3751), 1 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 12, 20, 12, 31, 125, DateTimeKind.Local).AddTicks(3731));
        }
    }
}
