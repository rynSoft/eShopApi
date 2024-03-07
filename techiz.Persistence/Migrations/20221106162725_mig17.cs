using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig17 : Migration
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
                keyValue: "015535c3-8ec9-47ad-80e4-9677e3a34a6b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0e49a4be-f655-44ba-8a13-4d10ba7b7228");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17bc0978-7260-45db-a2d8-27d5a9c0ad0d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("74415327-0ac1-46bc-8b06-243ca5fc33a7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("92ca5be1-6a37-45ae-8d3f-3157b1936fa3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a050bd39-a275-4b72-ba05-1803d5a916c7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ddc0b085-8c04-4a78-906b-c5c9403f0f85"));

            migrationBuilder.RenameColumn(
                name: "BomKitInfoOldId",
                table: "SetupVerificationDChange",
                newName: "SetupVerificationDetailsOldId");

            migrationBuilder.RenameColumn(
                name: "BomKitInfoNewId",
                table: "SetupVerificationDChange",
                newName: "SetupVerificationDetailsNewId");

            migrationBuilder.RenameIndex(
                name: "IX_SetupVerificationDChange_BomKitInfoOldId",
                table: "SetupVerificationDChange",
                newName: "IX_SetupVerificationDChange_SetupVerificationDetailsOldId");

            migrationBuilder.RenameIndex(
                name: "IX_SetupVerificationDChange_BomKitInfoNewId",
                table: "SetupVerificationDChange",
                newName: "IX_SetupVerificationDChange_SetupVerificationDetailsNewId");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a24aa86-db51-48cd-aef5-412ae6c185cc", "12fd7fd5-82eb-46db-ad0f-4941a9eca087", "admin", "ADMİN" },
                    { "33d7f9f6-48c8-47e4-b605-436877b5be1c", "067d0c3b-686d-4aed-90fe-e3fcd0728d1d", "sistemadmin", "SİSTEMADMİN" },
                    { "78f724df-47c1-46a7-8fe0-4397ea0e74fd", "24ea7057-0639-4fd4-baff-09f9f34a69d0", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2372bdfb-529e-412f-8d71-87a4d0d2a091"), 0, "Tolga", "67297079-94ea-4ae5-a3a4-05dbcc6bde90", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("37973a9c-5db6-4f74-9de0-6f94a8924f60"), 0, "Seref", "cc39c312-d8e5-4bdc-b925-8ce9a00465a0", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("86e7e721-e0ab-4dfa-9192-7a7fd8fb1b7b"), 0, "Hakan", "2ed7d1c4-988a-427f-8f7f-d6122fc1e4c4", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("cda4b3e5-aa0a-4a5e-8a87-f012974912ed"), 0, "Hakki", "af9cf908-f531-4cb2-b2c7-9c82319ad3a1", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVer~1",
                table: "SetupVerificationDChange",
                column: "SetupVerificationDetailsOldId",
                principalTable: "SetupVerificationDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVeri~",
                table: "SetupVerificationDChange",
                column: "SetupVerificationDetailsNewId",
                principalTable: "SetupVerificationDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVer~1",
                table: "SetupVerificationDChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVeri~",
                table: "SetupVerificationDChange");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1a24aa86-db51-48cd-aef5-412ae6c185cc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "33d7f9f6-48c8-47e4-b605-436877b5be1c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "78f724df-47c1-46a7-8fe0-4397ea0e74fd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2372bdfb-529e-412f-8d71-87a4d0d2a091"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("37973a9c-5db6-4f74-9de0-6f94a8924f60"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86e7e721-e0ab-4dfa-9192-7a7fd8fb1b7b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cda4b3e5-aa0a-4a5e-8a87-f012974912ed"));

            migrationBuilder.RenameColumn(
                name: "SetupVerificationDetailsOldId",
                table: "SetupVerificationDChange",
                newName: "BomKitInfoOldId");

            migrationBuilder.RenameColumn(
                name: "SetupVerificationDetailsNewId",
                table: "SetupVerificationDChange",
                newName: "BomKitInfoNewId");

            migrationBuilder.RenameIndex(
                name: "IX_SetupVerificationDChange_SetupVerificationDetailsOldId",
                table: "SetupVerificationDChange",
                newName: "IX_SetupVerificationDChange_BomKitInfoOldId");

            migrationBuilder.RenameIndex(
                name: "IX_SetupVerificationDChange_SetupVerificationDetailsNewId",
                table: "SetupVerificationDChange",
                newName: "IX_SetupVerificationDChange_BomKitInfoNewId");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "015535c3-8ec9-47ad-80e4-9677e3a34a6b", "192ac70e-4308-4239-bd29-66668e2b0b51", "depo", "DEPO" },
                    { "0e49a4be-f655-44ba-8a13-4d10ba7b7228", "fc6a8408-cfd0-4f16-84c5-e353aa696f06", "admin", "ADMİN" },
                    { "17bc0978-7260-45db-a2d8-27d5a9c0ad0d", "63581dc2-c6e0-4e8a-bd94-a24c96ce3c48", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(570), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1020), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1660), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(1940), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("74415327-0ac1-46bc-8b06-243ca5fc33a7"), 0, "Hakan", "4bce4445-4a96-4e07-a030-05bdbb540da3", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("92ca5be1-6a37-45ae-8d3f-3157b1936fa3"), 0, "Hakki", "dda08710-0c6a-4003-8242-36d10081e0d4", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("a050bd39-a275-4b72-ba05-1803d5a916c7"), 0, "Seref", "426e22d1-c26d-4255-b5c8-d8db060e303f", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("ddc0b085-8c04-4a78-906b-c5c9403f0f85"), 0, "Tolga", "828505e7-6247-4557-8586-3ee8acc774de", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 14, 13, 42, 679, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, 3, 0, 0, 0)));

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
    }
}
