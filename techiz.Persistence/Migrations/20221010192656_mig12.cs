using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoNewId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoOldId",
                table: "SetupVerificationDChange");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "38acafb2-dfb1-40b7-9ee3-7a117e90dc42");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "909f75dc-df42-4787-be7c-5b939ae099fd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "da521d1d-4ba5-4fd9-a5f0-2153970ee79f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("31399a8c-099a-4de0-98ce-616ff3230b2f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ac8a20f5-d667-4b21-8e29-72288a05b14c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e37b0eb6-26dc-450d-a880-835ede39674c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eeb0c0a7-345b-4909-b23a-89183b0abba0"));

            migrationBuilder.DropColumn(
                name: "NewBomKitInfoId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropColumn(
                name: "OldBomKitInfoId",
                table: "SetupVerificationDChange");

            migrationBuilder.AlterColumn<int>(
                name: "BomKitInfoOldId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BomKitInfoNewId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Revoked",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05ad7daf-32c2-4c0e-8ccc-f199abc325cc", "0bbb6883-c912-441e-b2bf-8a9fd749a7d9", "admin", "ADMİN" },
                    { "5922db0b-d88a-42b8-9421-65763bd8df9c", "b3a7ddb1-93af-4a7d-913c-4e5785bc850a", "depo", "DEPO" },
                    { "9f69466b-1f92-47ab-8eee-6d383abb6557", "bff701b4-48c3-4117-92e3-0064114ed496", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(5390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("169e4935-b778-417f-9b3b-a28fe9f15bc5"), 0, "Hakki", "fdb64ecc-dbf9-433b-8783-859b1e91e2d7", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("d5b50041-e168-49b1-8b95-2c25a93de466"), 0, "Tolga", "77baed37-c495-4cc2-a11e-69d49b52a40b", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("f73a8250-fa69-4a4a-bf0c-80d265ff2da9"), 0, "Hakan", "c4ffcf4a-72b8-437d-8e20-064ab5861c8b", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("ff8a6151-899f-4a51-8404-f786b35092b7"), 0, "Seref", "b3f08cc3-17d3-4934-8fb5-609542e95111", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 10, 22, 26, 55, 909, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoNewId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoNewId",
                principalTable: "BomKitInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoOldId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoOldId",
                principalTable: "BomKitInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoNewId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoOldId",
                table: "SetupVerificationDChange");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "05ad7daf-32c2-4c0e-8ccc-f199abc325cc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5922db0b-d88a-42b8-9421-65763bd8df9c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9f69466b-1f92-47ab-8eee-6d383abb6557");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("169e4935-b778-417f-9b3b-a28fe9f15bc5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d5b50041-e168-49b1-8b95-2c25a93de466"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f73a8250-fa69-4a4a-bf0c-80d265ff2da9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ff8a6151-899f-4a51-8404-f786b35092b7"));

            migrationBuilder.AlterColumn<int>(
                name: "BomKitInfoOldId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BomKitInfoNewId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "NewBomKitInfoId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OldBomKitInfoId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Revoked",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38acafb2-dfb1-40b7-9ee3-7a117e90dc42", "a0c96718-7f50-4e52-a01e-cc43b7b48c12", "depo", "DEPO" },
                    { "909f75dc-df42-4787-be7c-5b939ae099fd", "ae826670-3810-4f69-98ea-7f000aa16ed6", "sistemadmin", "SİSTEMADMİN" },
                    { "da521d1d-4ba5-4fd9-a5f0-2153970ee79f", "9e0f9461-5402-4bbf-ad2f-a62a9eafa029", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9372), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9402), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9406), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9695), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 236, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(29), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1002), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("31399a8c-099a-4de0-98ce-616ff3230b2f"), 0, "Seref", "3753133a-af6f-4f62-9653-5696a5738057", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("ac8a20f5-d667-4b21-8e29-72288a05b14c"), 0, "Tolga", "a64f11e9-37cc-4ce3-9983-f24aff6b4676", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("e37b0eb6-26dc-450d-a880-835ede39674c"), 0, "Hakki", "210df1ab-bfe8-4d57-b65a-fd317089c8fc", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("eeb0c0a7-345b-4909-b23a-89183b0abba0"), 0, "Hakan", "16ad51a2-68c5-435f-9382-2a652ffbf4af", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1141), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 44, 27, 237, DateTimeKind.Unspecified).AddTicks(1151), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoNewId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoNewId",
                principalTable: "BomKitInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoOldId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoOldId",
                principalTable: "BomKitInfo",
                principalColumn: "Id");
        }
    }
}
