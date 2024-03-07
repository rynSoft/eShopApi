using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelsId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelsId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_SetupVerificationDChange_NewPanelsId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_SetupVerificationDChange_OldPanelsId",
                table: "SetupVerificationDChange");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "166be60b-4a95-4370-9c5a-2225bde52b7d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4e6e361c-9e77-4e8c-bba4-67eda2ab0bc5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b568e33a-081c-421a-946f-9c278ca8db23");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("11bfaca6-37c9-4df4-8ee9-5aa3a23286b7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("21e60db7-5c58-40ca-bfcf-bcb8aff803c4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4d1b7e69-2de5-45c2-8410-e76b414ebbd4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8b70cc8e-b198-4005-922c-31e2b40927ad"));

            migrationBuilder.DropColumn(
                name: "NewPanelsId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropColumn(
                name: "OldPanelsId",
                table: "SetupVerificationDChange");

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

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_NewPanelId",
                table: "SetupVerificationDChange",
                column: "NewPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_OldPanelId",
                table: "SetupVerificationDChange",
                column: "OldPanelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelId",
                table: "SetupVerificationDChange",
                column: "NewPanelId",
                principalTable: "ProductionOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelId",
                table: "SetupVerificationDChange",
                column: "OldPanelId",
                principalTable: "ProductionOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_SetupVerificationDChange_NewPanelId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_SetupVerificationDChange_OldPanelId",
                table: "SetupVerificationDChange");

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

            migrationBuilder.AddColumn<int>(
                name: "NewPanelsId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OldPanelsId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "166be60b-4a95-4370-9c5a-2225bde52b7d", "15454738-fa83-411f-bc50-0fffde073e6e", "sistemadmin", "SİSTEMADMİN" },
                    { "4e6e361c-9e77-4e8c-bba4-67eda2ab0bc5", "6e3beecc-dda7-4093-a40f-c3e6394ebf33", "depo", "DEPO" },
                    { "b568e33a-081c-421a-946f-9c278ca8db23", "2a6125f4-9964-474a-a936-85322e6283c5", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7270), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(7950), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8450), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("11bfaca6-37c9-4df4-8ee9-5aa3a23286b7"), 0, "Hakki", "f30e2743-60bc-48c9-8790-a1fd9d260b6f", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("21e60db7-5c58-40ca-bfcf-bcb8aff803c4"), 0, "Seref", "14c99d45-a12a-4b84-bed4-8ab0f997bf55", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("4d1b7e69-2de5-45c2-8410-e76b414ebbd4"), 0, "Hakan", "98cc8be7-8bb8-43b2-84f7-5e4f37356fad", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("8b70cc8e-b198-4005-922c-31e2b40927ad"), 0, "Tolga", "814160de-56c3-41cc-a987-9b7f85419f18", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 2, 16, 48, 25, 496, DateTimeKind.Unspecified).AddTicks(9400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_NewPanelsId",
                table: "SetupVerificationDChange",
                column: "NewPanelsId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_OldPanelsId",
                table: "SetupVerificationDChange",
                column: "OldPanelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelsId",
                table: "SetupVerificationDChange",
                column: "NewPanelsId",
                principalTable: "ProductionOperations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelsId",
                table: "SetupVerificationDChange",
                column: "OldPanelsId",
                principalTable: "ProductionOperations",
                principalColumn: "Id");
        }
    }
}
