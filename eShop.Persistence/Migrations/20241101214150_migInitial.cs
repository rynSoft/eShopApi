using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "02a199d9-be66-4988-8eb3-37b9fe96a95d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aea0cebf-e106-4de9-8b24-ff043e4b5b17");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ccd8dac9-1d84-4ba2-ad73-0621b8ddd4ab");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("48af3a8e-cb3d-49a0-8bba-97580c8df050"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5a77d16f-7897-47c3-bf75-608b28649d2a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("65217fea-4a15-4154-928b-4cbfef53f80d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8e2ed5bf-afc4-4b75-8116-b2419b373a5e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cfd11b99-dde3-474a-aad0-cd2015f9d747"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "349eab65-a508-40e8-9470-4378351b0e56", null, "sistemadmin", "SISTEMADMIN" },
                    { "80c08013-89a0-4eb7-bbc6-55e4257e9cc1", null, "depo", "DEPO" },
                    { "93f15963-d79c-4df4-b231-4f530ada00c6", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 212, DateTimeKind.Unspecified).AddTicks(9526), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 212, DateTimeKind.Unspecified).AddTicks(9568), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 212, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 212, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 212, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(208), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(2781), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(5236), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(5520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(6155), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(6491), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(8337), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(8632), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(8914), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(9583), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 213, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(776), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 41, 50, 214, DateTimeKind.Unspecified).AddTicks(1719), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2ddbf7ea-6498-44b8-9bd7-b0c94b8ff0bd"), 0, "eShop", "ae5bc797-c38d-41ad-9e2c-a401b55e4975", "eShop@sentytech.com", true, "eShop@sentytech.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "eShop", null, false, "eShop" },
                    { new Guid("441ec584-2937-416d-8d90-9af9f114d62d"), 0, "Hakan", "6fc65e08-2445-4706-82c3-022d5a6f39f6", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("46bc1227-98fb-4022-aeae-4a9a767c95d6"), 0, "Cagan", "0a248121-6b6e-4f5a-a179-d5200b978941", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("4ef493a9-0508-464f-8558-ea71535eef03"), 0, "Salih", "03fdc75c-7b75-488f-982a-57c8f2c34516", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("8e2de0b0-90b4-49f5-9562-429d53d22616"), 0, "Tolga", "16e0bf01-c1a8-4572-9863-357c22ea5bfe", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "349eab65-a508-40e8-9470-4378351b0e56");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "80c08013-89a0-4eb7-bbc6-55e4257e9cc1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "93f15963-d79c-4df4-b231-4f530ada00c6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2ddbf7ea-6498-44b8-9bd7-b0c94b8ff0bd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("441ec584-2937-416d-8d90-9af9f114d62d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("46bc1227-98fb-4022-aeae-4a9a767c95d6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4ef493a9-0508-464f-8558-ea71535eef03"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8e2de0b0-90b4-49f5-9562-429d53d22616"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02a199d9-be66-4988-8eb3-37b9fe96a95d", null, "depo", "DEPO" },
                    { "aea0cebf-e106-4de9-8b24-ff043e4b5b17", null, "admin", "ADMIN" },
                    { "ccd8dac9-1d84-4ba2-ad73-0621b8ddd4ab", null, "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3479), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4537), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5632), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6185), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8968), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9228), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(1766), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("48af3a8e-cb3d-49a0-8bba-97580c8df050"), 0, "Tolga", "152ab07c-29b2-496f-b6ec-2300c35c725a", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("5a77d16f-7897-47c3-bf75-608b28649d2a"), 0, "eShop", "2f2ec740-5fdd-4fe8-981f-f1e3f84e8324", "eShop@sentytech.com", true, "eShop@sentytech.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "eShop", null, false, "eShop" },
                    { new Guid("65217fea-4a15-4154-928b-4cbfef53f80d"), 0, "Hakan", "f07e197a-c71f-4e42-a5a1-29ec44dec85f", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("8e2ed5bf-afc4-4b75-8116-b2419b373a5e"), 0, "Salih", "56695399-1ef2-4f0c-bc25-d80965f5f741", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("cfd11b99-dde3-474a-aad0-cd2015f9d747"), 0, "Cagan", "cf4981d2-2f0b-4189-b0bf-c8133155e012", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" }
                });
        }
    }
}
