using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig56h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "56d15365-f951-4365-ba32-2edc4325eeac");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6df8e3b-1b05-4a56-8a06-d1505061641c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f833bb48-6bec-46f6-8362-5162097acba7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2c318c17-a8f6-4c61-98cb-5dff1be6a5f1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b0037051-7504-4294-8c6f-9ca6b632a188"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cc34d159-a8b9-4835-a147-5d5ad0ba6c7d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("db7ab1f1-df0d-45d7-83f5-a56c0d8d7fed"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LabelingBeginDate",
                table: "ProductionProcessManual",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3cbba816-f5b0-4064-badd-de3057f5a1fe", "7a0398f6-c6c0-4fa0-ac7d-c17763bc7630", "depo", "DEPO" },
                    { "685307ea-a006-4a68-b231-1b30aa1401b5", "237539d5-1aa1-46ed-84ea-f1b6c5d4ad8d", "admin", "ADMİN" },
                    { "7398e605-83f4-481d-bfe5-5f38f104a0fe", "0a50ad0e-1239-4d83-b974-68b0740406c7", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9145), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9147), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9567), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 363, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(276), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(946), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(1278), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(2946), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(3287), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(3616), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(3946), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(4275), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(5628), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(5956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(6967), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(7296), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(7584), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(8289), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(9624), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 364, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("30d24234-a67f-40b6-9f51-e6d8bd86ade3"), 0, "Tolga", "748de475-4f00-4cbb-acde-35cad128ecad", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("55bc2747-2987-4d11-94dc-114214ca79f1"), 0, "Hakan", "830fa972-4da3-4b46-90f1-367bb3676499", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("7e6278fe-24af-4729-954d-72f3ef39f237"), 0, "Seref", "4818a349-2fd1-4f41-ba78-94e000352424", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("e28c09aa-6277-4138-8e41-0e891fad5a70"), 0, "Hakki", "13987668-9d24-49ab-b60f-c2f5fe91ffe6", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 365, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 365, DateTimeKind.Unspecified).AddTicks(380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 365, DateTimeKind.Unspecified).AddTicks(382), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 365, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 23, 0, 12, 30, 365, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3cbba816-f5b0-4064-badd-de3057f5a1fe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "685307ea-a006-4a68-b231-1b30aa1401b5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7398e605-83f4-481d-bfe5-5f38f104a0fe");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("30d24234-a67f-40b6-9f51-e6d8bd86ade3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("55bc2747-2987-4d11-94dc-114214ca79f1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7e6278fe-24af-4729-954d-72f3ef39f237"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e28c09aa-6277-4138-8e41-0e891fad5a70"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LabelingBeginDate",
                table: "ProductionProcessManual",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56d15365-f951-4365-ba32-2edc4325eeac", "c6bae44a-3960-4496-b26e-79a29a03ddd8", "admin", "ADMİN" },
                    { "b6df8e3b-1b05-4a56-8a06-d1505061641c", "a8896ff9-bad6-4865-b986-be6faab4a6ef", "depo", "DEPO" },
                    { "f833bb48-6bec-46f6-8362-5162097acba7", "4c5746aa-1bb7-49c1-be65-ff44da1ad211", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 85, DateTimeKind.Unspecified).AddTicks(9332), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 85, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 85, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 85, DateTimeKind.Unspecified).AddTicks(9383), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 85, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(1744), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(2068), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(2388), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4406), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7944), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2c318c17-a8f6-4c61-98cb-5dff1be6a5f1"), 0, "Hakki", "d3ddc8ca-2407-4484-8dbf-8c06d1079fd3", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("b0037051-7504-4294-8c6f-9ca6b632a188"), 0, "Tolga", "af8553a8-0457-46ff-a743-db84cecf2091", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("cc34d159-a8b9-4835-a147-5d5ad0ba6c7d"), 0, "Seref", "233e9841-4dc5-4f9e-91ee-32ae90393513", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("db7ab1f1-df0d-45d7-83f5-a56c0d8d7fed"), 0, "Hakan", "542a8a5e-0909-4dfc-9898-bdefcc7e6433", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(803), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(807), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(809), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
