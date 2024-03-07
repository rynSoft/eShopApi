using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig83h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShiftTargetParameters_RestCause_RestCauseId",
                table: "ShiftTargetParameters");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "157ea065-12af-4811-96eb-dfbdbc2fca97");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "72e874d7-7bc5-4f66-9480-7ce9159ee926");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d864453e-900a-4bdd-b7b6-287af5e976d2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0c3ee7bc-52f0-468b-ba5c-3a7a65827af3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("179a0f55-f5a7-4b04-9007-7a0d4a6857b1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("74f96800-c316-47e8-af68-63acb805f3dc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fd4a3cf6-0147-4ca9-abca-1ccc885e3c33"));

            migrationBuilder.AlterColumn<int>(
                name: "RestCauseId",
                table: "ShiftTargetParameters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50b23c6d-c474-4b1d-a288-ae2916cc336c", "ed8e5cfa-9b2e-47cb-8035-69d774e265fd", "depo", "DEPO" },
                    { "675ba4cc-af2e-4453-a2d4-334a66f3b308", "49186545-f721-4a0f-ab1d-004251252e4c", "admin", "ADMİN" },
                    { "6f193767-5637-4b21-bdf9-1820781554cc", "9a38c1db-f6fe-4e72-8342-9f5d6bc6e94c", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(4179), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(8414), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 436, DateTimeKind.Unspecified).AddTicks(9895), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(235), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(1952), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(2287), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(4738), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(6455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(6831), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(7841), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(8183), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(8516), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(8849), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(9211), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 437, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0094c8ed-ecc9-4f03-821a-f2ca4a4c0958"), 0, "Seref", "899c6b43-7f6c-49e1-b030-29134f505953", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("3b47a777-7978-4314-8e6a-fe0e6e1035c8"), 0, "Hakki", "9244d487-5d64-43c7-b03b-ede3d6dab162", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("8a5338e5-29d0-436d-8d45-58644eedf357"), 0, "Tolga", "70ef8998-8049-4ba7-9c5d-1d6d47a2ed19", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("912aaa47-cd22-4582-aa16-984a742e42fd"), 0, "Hakan", "142443df-e916-4450-bf5f-b8931e595048", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(766), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 16, 12, 8, 23, 438, DateTimeKind.Unspecified).AddTicks(772), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftTargetParameters_RestCause_RestCauseId",
                table: "ShiftTargetParameters",
                column: "RestCauseId",
                principalTable: "RestCause",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShiftTargetParameters_RestCause_RestCauseId",
                table: "ShiftTargetParameters");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "50b23c6d-c474-4b1d-a288-ae2916cc336c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "675ba4cc-af2e-4453-a2d4-334a66f3b308");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6f193767-5637-4b21-bdf9-1820781554cc");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0094c8ed-ecc9-4f03-821a-f2ca4a4c0958"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3b47a777-7978-4314-8e6a-fe0e6e1035c8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a5338e5-29d0-436d-8d45-58644eedf357"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("912aaa47-cd22-4582-aa16-984a742e42fd"));

            migrationBuilder.AlterColumn<int>(
                name: "RestCauseId",
                table: "ShiftTargetParameters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "157ea065-12af-4811-96eb-dfbdbc2fca97", "ba3dc896-7dd7-4932-99d0-db6acdc40365", "admin", "ADMİN" },
                    { "72e874d7-7bc5-4f66-9480-7ce9159ee926", "0caac3a9-28ba-489e-a1c7-ee640da537db", "depo", "DEPO" },
                    { "d864453e-900a-4bdd-b7b6-287af5e976d2", "b6db4983-f12c-4752-97f2-788b0432fb66", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(447), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(889), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(3495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(3893), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(5573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(7368), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(8168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(8569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 965, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(1469), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(3983), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(4794), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c3ee7bc-52f0-468b-ba5c-3a7a65827af3"), 0, "Hakki", "4ae23be7-4f72-4621-a37d-0f0cc96f3134", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("179a0f55-f5a7-4b04-9007-7a0d4a6857b1"), 0, "Tolga", "c2a01759-97fb-4034-a6f2-90dc593888d5", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("74f96800-c316-47e8-af68-63acb805f3dc"), 0, "Hakan", "88ded4e1-e9aa-442b-967d-7fcdcc416718", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("fd4a3cf6-0147-4ca9-abca-1ccc885e3c33"), 0, "Seref", "5ce6bb06-79f3-4372-9948-84e0edfb947b", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6816), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 18, 56, 32, 966, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftTargetParameters_RestCause_RestCauseId",
                table: "ShiftTargetParameters",
                column: "RestCauseId",
                principalTable: "RestCause",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
