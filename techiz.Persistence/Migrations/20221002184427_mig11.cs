using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30ad68c7-4fa4-4612-8459-3aa30151e29a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8fa6c355-b18d-45ba-83b0-a59ccde01ab7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5f9961a-f869-4a47-91fb-32d4c850eb98");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("11612f24-1a2c-4322-a99f-6487516313a5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("54af67a1-d4fc-4659-ade0-eb2a0d94ac89"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5ebc72d8-b68c-4c2b-a1de-eab02627b1d9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f9e814b3-eea3-43f9-941b-d7f119141dd5"));

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

            migrationBuilder.AlterColumn<int>(
                name: "IsKitProvided",
                table: "BomKitInfo",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "IsKitPreperated",
                table: "BomKitInfo",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<float>(
                name: "IsKitProvided",
                table: "BomKitInfo",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<float>(
                name: "IsKitPreperated",
                table: "BomKitInfo",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30ad68c7-4fa4-4612-8459-3aa30151e29a", "958f8383-8f3e-4223-a428-8c68842b86cd", "sistemadmin", "SİSTEMADMİN" },
                    { "8fa6c355-b18d-45ba-83b0-a59ccde01ab7", "67d5920a-fb04-4cf9-81be-01f4a7eada74", "depo", "DEPO" },
                    { "d5f9961a-f869-4a47-91fb-32d4c850eb98", "15b0dff9-0775-4b0b-87a7-04a97a14b43b", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 89, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(320), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(3810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("11612f24-1a2c-4322-a99f-6487516313a5"), 0, "Hakan", "04f0773f-8ec7-4d72-b2a5-28e460044dba", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("54af67a1-d4fc-4659-ade0-eb2a0d94ac89"), 0, "Tolga", "41f35f15-4a8f-4711-928a-cb9e1ad93430", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("5ebc72d8-b68c-4c2b-a1de-eab02627b1d9"), 0, "Seref", "fd956b8f-63c0-41f1-8878-a2f6ab0362f8", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("f9e814b3-eea3-43f9-941b-d7f119141dd5"), 0, "Hakki", "c1f4d278-f638-4f53-a2f3-c7a58cecc67b", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 21, 35, 40, 90, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
