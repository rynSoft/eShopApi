using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig43t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QualityOperationDocument_QualityInfo_QualityInfoId",
                table: "QualityOperationDocument");

            migrationBuilder.DropIndex(
                name: "IX_QualityOperationDocument_QualityInfoId",
                table: "QualityOperationDocument");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0439c46a-1034-456e-9aa7-1c0121bf0b03");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b7d5efc0-2706-425a-828a-d67083c266f9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb9d9138-5f07-4de5-bbff-c32c300accc6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7bc66284-8286-452c-bd64-c61bbbc6d7aa"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("988d47b8-a95c-4654-9d24-8fc15cee6831"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9f9821f2-0a83-4e51-9981-bdc57cc08eb1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dec4b1b2-e96c-4b74-aad8-102227d535d6"));

            migrationBuilder.DropColumn(
                name: "QualityInfoId",
                table: "QualityOperationDocument");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ffa656c-db8a-4e7d-970c-ceb6b18818a1", "6ed7396e-7beb-44b9-9ccf-48afbbf9a16d", "admin", "ADMİN" },
                    { "9b5d8e09-e185-4f98-8228-b52415a2f115", "28cdbce7-4e74-49ec-bf36-d1e8b9c2cc7f", "sistemadmin", "SİSTEMADMİN" },
                    { "f6755b18-b5da-436e-bd31-e171d9f35e02", "1262dd7c-0083-414e-90e5-d393dc0451b8", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(238), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(263), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(545), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1316), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1525), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(1953), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("04a0a467-8eb7-4478-b0d7-a64af9e24b93"), 0, "Seref", "8ba8495f-c6f3-4bce-9276-be01940eda33", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("2d0d1f59-b757-456d-8572-6bd9d5b5d923"), 0, "Tolga", "ecbe9b60-35dd-4053-8ed8-9cbe557d1650", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("9a67e578-d6d4-4a90-889d-ef710eff810a"), 0, "Hakan", "7b65bff6-c716-4d8a-9458-66905938e7b9", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("b3562a84-1082-41e3-b1c9-b73b6e9ab200"), 0, "Hakki", "962ac380-7696-42b0-8437-bfa487e946f3", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2199), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2201), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 58, 56, 148, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ffa656c-db8a-4e7d-970c-ceb6b18818a1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9b5d8e09-e185-4f98-8228-b52415a2f115");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f6755b18-b5da-436e-bd31-e171d9f35e02");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("04a0a467-8eb7-4478-b0d7-a64af9e24b93"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2d0d1f59-b757-456d-8572-6bd9d5b5d923"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9a67e578-d6d4-4a90-889d-ef710eff810a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b3562a84-1082-41e3-b1c9-b73b6e9ab200"));

            migrationBuilder.AddColumn<int>(
                name: "QualityInfoId",
                table: "QualityOperationDocument",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0439c46a-1034-456e-9aa7-1c0121bf0b03", "4cc623cc-a490-4dc6-ba61-e2a92547ddf2", "admin", "ADMİN" },
                    { "b7d5efc0-2706-425a-828a-d67083c266f9", "b3131b24-3fb0-467b-a1b0-85334d061d6f", "sistemadmin", "SİSTEMADMİN" },
                    { "cb9d9138-5f07-4de5-bbff-c32c300accc6", "bb14f45f-5fe9-4d51-9f06-e6f011b7025f", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3498), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3527), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(3929), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4032), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4559), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4661), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4768), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(4979), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5289), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7bc66284-8286-452c-bd64-c61bbbc6d7aa"), 0, "Seref", "eae5ad70-87af-4143-be94-64e8d2e34a12", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("988d47b8-a95c-4654-9d24-8fc15cee6831"), 0, "Tolga", "74d7fd2b-6f9d-4ed7-bed9-f9142fd2a8d0", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("9f9821f2-0a83-4e51-9981-bdc57cc08eb1"), 0, "Hakki", "28586d4a-df91-4030-83fd-2b684f51d5a0", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("dec4b1b2-e96c-4b74-aad8-102227d535d6"), 0, "Hakan", "8c899b67-231d-4c9c-ad29-ddc0b6b4fa75", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5418), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5423), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 13, 35, 622, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperationDocument_QualityInfoId",
                table: "QualityOperationDocument",
                column: "QualityInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_QualityOperationDocument_QualityInfo_QualityInfoId",
                table: "QualityOperationDocument",
                column: "QualityInfoId",
                principalTable: "QualityInfo",
                principalColumn: "Id");
        }
    }
}
