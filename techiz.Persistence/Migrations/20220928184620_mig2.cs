using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "193d9c20-0aa3-49a1-bdbd-4ba956fdff08");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "81c03285-883f-4e7f-8b86-6f1736c2687a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fd60a91d-2fc8-4883-9804-8999036e4c93");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("08f78bc4-26bb-45ed-a604-7c88e97be215"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3960e26b-6881-44b0-8420-b4c0b057e209"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("40ae3996-6dd3-4833-9fd9-708bb68c0e3b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e92ab7c7-557d-47cb-9120-6ca410257d85"));

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
                    { "9360d1a3-668d-4c7b-bf0d-2a66159d8837", "dd8220a3-983d-4a02-a6b8-6bcb6f9b78d0", "sistemadmin", "SİSTEMADMİN" },
                    { "a502f98e-0304-4fc0-898c-d6d802922e75", "c0e5b93a-43fb-4123-a6c0-4fa3aec386f1", "depo", "DEPO" },
                    { "c20b308c-a790-44fd-9078-8cf0b0b48a51", "0a03ef96-cd64-4814-af0b-60c6b4da5446", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8250), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8620), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("04eba9b2-ff3b-45f8-ac6f-802d06606956"), 0, "Tolga", "1171e9a4-76af-4b1a-b320-d224cd7c9d53", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("bdb2014c-9efc-44a2-ba90-7b4eb233094d"), 0, "Hakki", "d06ffce9-b7b3-4d4c-b693-d224668647c4", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("e3db3eef-53b7-465d-a137-ef2101bc9fd3"), 0, "Hakan", "cf25869d-65e2-4654-b594-26fa564c6149", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("ee4d81cf-5399-4404-98d1-7b5fc3ba9820"), 0, "Seref", "c0929488-90c3-4b30-8944-df013020000f", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 21, 46, 19, 487, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9360d1a3-668d-4c7b-bf0d-2a66159d8837");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a502f98e-0304-4fc0-898c-d6d802922e75");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c20b308c-a790-44fd-9078-8cf0b0b48a51");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("04eba9b2-ff3b-45f8-ac6f-802d06606956"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bdb2014c-9efc-44a2-ba90-7b4eb233094d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3db3eef-53b7-465d-a137-ef2101bc9fd3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ee4d81cf-5399-4404-98d1-7b5fc3ba9820"));

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
                    { "193d9c20-0aa3-49a1-bdbd-4ba956fdff08", "b141d46d-dea0-4ee4-8e70-58a80299f5d6", "depo", "DEPO" },
                    { "81c03285-883f-4e7f-8b86-6f1736c2687a", "7be9a2f0-cd1c-43c4-8902-8edc493b285b", "sistemadmin", "SİSTEMADMİN" },
                    { "fd60a91d-2fc8-4883-9804-8999036e4c93", "d4c0aaee-523f-47cc-bf1b-5bd537111e8d", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1710), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(1960), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("08f78bc4-26bb-45ed-a604-7c88e97be215"), 0, "Seref", "60e73845-9a0e-44c6-9076-dca74db8579b", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("3960e26b-6881-44b0-8420-b4c0b057e209"), 0, "Hakan", "ae7ae797-0779-4f19-af58-46ed18a45319", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("40ae3996-6dd3-4833-9fd9-708bb68c0e3b"), 0, "Hakki", "66f7f563-42c8-4909-b203-685a5c3a7741", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("e92ab7c7-557d-47cb-9120-6ca410257d85"), 0, "Tolga", "64428734-e9a5-458b-8929-a73c3ac1138d", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 54, 7, 280, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
