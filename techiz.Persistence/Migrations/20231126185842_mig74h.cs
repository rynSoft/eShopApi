using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig74h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "270b9d51-ecdc-412c-97dd-6ab044e49a10");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7fdc632d-a360-419b-a66a-50fc2e18c952");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8d962333-0faa-437d-917c-c25a39b33f72");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("33743869-c39b-410f-82bb-ed080ea873da"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("672e9827-cabc-4f7d-80c9-6b4bc590ceff"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ff10426-7eba-4911-abf9-103d634decf5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76af122b-ef0a-4810-a925-430f8da10d4a"));

            migrationBuilder.AddColumn<int>(
                name: "ShiftTargetParametersId",
                table: "ProductionTimeProcess",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4e1a51e-5c19-44d5-b9dc-91185a4d04d4", "75dfe481-9060-485b-b9ef-712aee5b34ab", "sistemadmin", "SİSTEMADMİN" },
                    { "ccdadb7d-d73d-44d1-abab-c084f61a8dac", "da047556-cfe8-48de-bd1d-fee3301207ac", "depo", "DEPO" },
                    { "fe2f7f4f-45a6-4c01-b217-937557427fc1", "7778e7d2-24e9-4bfb-9ad5-005a6eb33c40", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(2235), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(6008), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(6389), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(7116), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(7479), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(7841), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(8204), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 727, DateTimeKind.Unspecified).AddTicks(9680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(2796), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8ee2d7a9-00a3-45a6-9e9c-b311dabcd806"), 0, "Tolga", "2f13409e-7390-41e2-9b66-8a2386621987", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("afa6cd3a-697b-4e88-8759-6899eaec5b10"), 0, "Hakan", "58552169-1c02-4ef5-b71a-d47dabe9911b", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("bf0717e6-b7ef-4aab-86aa-7e0612c16f52"), 0, "Hakki", "a8df47e6-840c-4b3c-84a9-84586ecbad19", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("dadab5f0-8f57-434e-bfdf-42932f5e5369"), 0, "Seref", "0ff10f88-987d-4967-8412-112d45430720", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3619), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 26, 21, 58, 41, 728, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_ShiftTargetParametersId",
                table: "ProductionTimeProcess",
                column: "ShiftTargetParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionTimeProcess_ShiftTargetParameters_ShiftTargetPara~",
                table: "ProductionTimeProcess",
                column: "ShiftTargetParametersId",
                principalTable: "ShiftTargetParameters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionTimeProcess_ShiftTargetParameters_ShiftTargetPara~",
                table: "ProductionTimeProcess");

            migrationBuilder.DropIndex(
                name: "IX_ProductionTimeProcess_ShiftTargetParametersId",
                table: "ProductionTimeProcess");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a4e1a51e-5c19-44d5-b9dc-91185a4d04d4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ccdadb7d-d73d-44d1-abab-c084f61a8dac");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fe2f7f4f-45a6-4c01-b217-937557427fc1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8ee2d7a9-00a3-45a6-9e9c-b311dabcd806"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("afa6cd3a-697b-4e88-8759-6899eaec5b10"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf0717e6-b7ef-4aab-86aa-7e0612c16f52"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dadab5f0-8f57-434e-bfdf-42932f5e5369"));

            migrationBuilder.DropColumn(
                name: "ShiftTargetParametersId",
                table: "ProductionTimeProcess");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "270b9d51-ecdc-412c-97dd-6ab044e49a10", "57b5bc65-1ee2-4ab7-a103-2dd83123485a", "depo", "DEPO" },
                    { "7fdc632d-a360-419b-a66a-50fc2e18c952", "2928d9cb-32ef-43e7-8f59-e7aa35b9ca1b", "sistemadmin", "SİSTEMADMİN" },
                    { "8d962333-0faa-437d-917c-c25a39b33f72", "ab369bef-c232-4f31-89fc-534488fc21af", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(3234), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(3244), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(8503), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(9361), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 171, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(163), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(1018), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(1419), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(1821), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(3176), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(4411), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(7316), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(7718), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(8118), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(8523), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(9322), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 172, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33743869-c39b-410f-82bb-ed080ea873da"), 0, "Seref", "677e2257-f0b7-4e0e-9e3f-8bca4ba9668c", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("672e9827-cabc-4f7d-80c9-6b4bc590ceff"), 0, "Tolga", "c4ea0d85-bd28-4647-96a5-5b0f5797518f", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("6ff10426-7eba-4911-abf9-103d634decf5"), 0, "Hakan", "ef84a992-b649-4ee1-8552-a4c0d5455a20", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("76af122b-ef0a-4810-a925-430f8da10d4a"), 0, "Hakki", "73ae3168-95d2-4cbf-bd90-100916e63d52", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(727), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(744), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 11, 25, 19, 32, 45, 173, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
