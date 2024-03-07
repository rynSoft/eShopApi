using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig38t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quality_NonComplianceCode_NonComplianceCodeId",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_QualityOperation_User_UserLiableId",
                table: "QualityOperation");

            migrationBuilder.DropIndex(
                name: "IX_QualityOperation_UserLiableId",
                table: "QualityOperation");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "034f33ef-417e-4ed4-b52a-765b77f7e92f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ce1f180c-9ef1-41e1-88ff-40d33edfe3b9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fd320b86-98dc-4049-9522-156d1a560f40");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2ac41c22-8d83-4ce6-a0c4-782d8300aebe"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7fba52d7-2873-4544-b2ee-0ccd8b0c6de2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a97bd829-34ab-4aff-af97-1c9f7d84fb88"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c995b8f8-09ed-45d0-9c71-eebf92de7633"));

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorizedPersonId",
                table: "QualityOperation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "NonComplianceCodeId",
                table: "Quality",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "NonComplianceCode",
                table: "Quality",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ff34ec2-3eca-4f41-8ca2-16be2ef93797", "c9b49955-b8f1-486c-a955-b7e005c0b1a6", "admin", "ADMİN" },
                    { "38ff9930-2775-4d29-8c39-54d44f9c8343", "74164c5a-973a-4184-a1c2-f0a50e6dd053", "depo", "DEPO" },
                    { "720738bf-7d05-4275-8293-8756ca5adb75", "497f85e8-8457-42f9-af33-83d1cb6b70be", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7345), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7612), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7858), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(7974), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9043), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9158), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("163e798b-ba41-43be-860a-2df130868158"), 0, "Hakan", "ca7552dc-e530-4410-97bc-fd00231ffa31", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("18f0d703-7c86-4344-b379-40e119e583c8"), 0, "Seref", "cf723746-6dc7-4128-b5e4-231e9e75852a", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("3a8d66dd-d1b7-443f-ae25-d93aaecabc34"), 0, "Tolga", "5a931783-2ca8-4d15-9de8-ccad5a3c271a", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("83e63bde-ba02-41f0-980f-b4c2937fbb2a"), 0, "Hakki", "3c0bb4ac-8989-4145-be29-e84ddaa9f933", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9426), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9428), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 21, 50, 45, 858, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperation_AuthorizedPersonId",
                table: "QualityOperation",
                column: "AuthorizedPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_NonComplianceCode_NonComplianceCodeId",
                table: "Quality",
                column: "NonComplianceCodeId",
                principalTable: "NonComplianceCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QualityOperation_User_AuthorizedPersonId",
                table: "QualityOperation",
                column: "AuthorizedPersonId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quality_NonComplianceCode_NonComplianceCodeId",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_QualityOperation_User_AuthorizedPersonId",
                table: "QualityOperation");

            migrationBuilder.DropIndex(
                name: "IX_QualityOperation_AuthorizedPersonId",
                table: "QualityOperation");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2ff34ec2-3eca-4f41-8ca2-16be2ef93797");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "38ff9930-2775-4d29-8c39-54d44f9c8343");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "720738bf-7d05-4275-8293-8756ca5adb75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("163e798b-ba41-43be-860a-2df130868158"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("18f0d703-7c86-4344-b379-40e119e583c8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3a8d66dd-d1b7-443f-ae25-d93aaecabc34"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("83e63bde-ba02-41f0-980f-b4c2937fbb2a"));

            migrationBuilder.DropColumn(
                name: "AuthorizedPersonId",
                table: "QualityOperation");

            migrationBuilder.DropColumn(
                name: "NonComplianceCode",
                table: "Quality");

            migrationBuilder.AlterColumn<int>(
                name: "NonComplianceCodeId",
                table: "Quality",
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
                    { "034f33ef-417e-4ed4-b52a-765b77f7e92f", "1c44ead4-28ce-4eff-a28c-61736c26da46", "sistemadmin", "SİSTEMADMİN" },
                    { "ce1f180c-9ef1-41e1-88ff-40d33edfe3b9", "02e14c18-a598-4521-aea1-b687e0f1f747", "depo", "DEPO" },
                    { "fd320b86-98dc-4049-9522-156d1a560f40", "1117a2ca-1aaa-4661-9aec-1ea54d617507", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(1985), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2214), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2673), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2785), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2ac41c22-8d83-4ce6-a0c4-782d8300aebe"), 0, "Tolga", "885523f8-1632-4017-939d-93c5dfeec868", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("7fba52d7-2873-4544-b2ee-0ccd8b0c6de2"), 0, "Hakan", "c65da42d-1afe-4063-b149-f4dc780b1ffb", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("a97bd829-34ab-4aff-af97-1c9f7d84fb88"), 0, "Hakki", "5eadab46-81b6-4dad-b141-d5f682757304", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("c995b8f8-09ed-45d0-9c71-eebf92de7633"), 0, "Seref", "fa3c6b90-e393-4024-98bf-73ca12d353ff", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2929), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2936), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2938), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 19, 14, 49, 30, 477, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperation_UserLiableId",
                table: "QualityOperation",
                column: "UserLiableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_NonComplianceCode_NonComplianceCodeId",
                table: "Quality",
                column: "NonComplianceCodeId",
                principalTable: "NonComplianceCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QualityOperation_User_UserLiableId",
                table: "QualityOperation",
                column: "UserLiableId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
