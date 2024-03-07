using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "36edcbc6-c2c8-48ec-9509-2a9f42003904");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "48440ee0-3fab-456b-9810-efdae2edddff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d85fd170-e20d-4fa2-b84d-c3887f79a6f6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c99e30e1-8cdf-469f-b809-113865d7addb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e26ab6f1-c440-4505-9297-a33502511ebc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f989ca2a-d106-48c3-8455-254d0a5103a6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa8b3e89-1e5a-4693-b989-a9b662f6ee76"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36edcbc6-c2c8-48ec-9509-2a9f42003904", "a45ded7e-fc58-4143-9450-23599460a3b2", "admin", "ADMİN" },
                    { "48440ee0-3fab-456b-9810-efdae2edddff", "8c976eb4-db2a-4478-9625-c9d3ba3a1ebf", "sistemadmin", "SİSTEMADMİN" },
                    { "d85fd170-e20d-4fa2-b84d-c3887f79a6f6", "53751a5a-9366-4b24-b76c-867b89a6da56", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7470), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c99e30e1-8cdf-469f-b809-113865d7addb"), 0, "Seref", "63e307a4-bcad-4974-99e1-a2437f364b3d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("e26ab6f1-c440-4505-9297-a33502511ebc"), 0, "Tolga", "4965651a-0a9e-4200-8c67-16bbd6aa66a0", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("f989ca2a-d106-48c3-8455-254d0a5103a6"), 0, "Hakki", "d4aa9245-18ad-4134-830d-6d7fcb47011f", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("fa8b3e89-1e5a-4693-b989-a9b662f6ee76"), 0, "Hakan", "3b1e24e1-e685-4111-a017-ac49fffa1e30", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8290), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
