using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig49h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "3c27f150-f5f9-475a-abd0-9deedaa39538");

            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "cb92feff-c75f-49ed-9dde-667bd4bea18a");

            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "ccacb377-d8f4-4f46-b333-2e8892adb81b");

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("0238f37c-26ce-452b-8a3e-55e4ce00e260"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("03435aac-bfbb-47d8-ba77-0fa0958e11ea"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("330920c8-384a-49e5-bf61-8768ee73ca8f"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("ad5ce058-b498-4062-b7de-afac2614428c"));

            migrationBuilder.AddColumn<double>(
                name: "NewPanelQty",
                table: "SetupVerificationDChange",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OldPanelQty",
                table: "SetupVerificationDChange",
                type: "double precision",
                nullable: true);

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
                    { "38269ade-27e4-4ff3-967b-ed960c26db73", "8359e824-0a67-4e40-a94b-07399eaa997b", "depo", "DEPO" },
                    { "3d8a6525-9881-489f-92b5-e76591601fe8", "1edb7a9b-6395-455d-b161-625d9ec54645", "sistemadmin", "SİSTEMADMİN" },
                    { "af3557f3-bb38-4f93-8ad6-0031704311d4", "709d2c72-af58-4550-9417-09301f883493", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(1973), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(2377), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(3360), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(3557), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(3916), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(4279), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(4666), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5088), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10da8ab1-0511-4f77-9e97-1495ee33cc06"), 0, "Hakki", "6ff66ba1-5426-4b16-bb16-f237590f2a84", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("33c42893-1718-422e-ade5-eecb8c6f7dd9"), 0, "Tolga", "0d5981ae-2655-4ecd-bbeb-86d01f3e0edf", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("762224c0-485b-418c-9689-2a57cced6667"), 0, "Hakan", "fcbee639-b987-4646-808e-b9c00939f871", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("ea0aa47e-01da-4cd7-bc60-afba331c4489"), 0, "Seref", "61c7f268-2c09-4e14-8a4c-c3c4f94e61d4", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5512), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5524), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 11, 40, 23, 260, DateTimeKind.Unspecified).AddTicks(5533), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "38269ade-27e4-4ff3-967b-ed960c26db73");

            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "3d8a6525-9881-489f-92b5-e76591601fe8");

            //migrationBuilder.DeleteData(
            //    table: "IdentityRole",
            //    keyColumn: "Id",
            //    keyValue: "af3557f3-bb38-4f93-8ad6-0031704311d4");

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("10da8ab1-0511-4f77-9e97-1495ee33cc06"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("33c42893-1718-422e-ade5-eecb8c6f7dd9"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("762224c0-485b-418c-9689-2a57cced6667"));

            //migrationBuilder.DeleteData(
            //    table: "User",
            //    keyColumn: "Id",
            //    keyValue: new Guid("ea0aa47e-01da-4cd7-bc60-afba331c4489"));

            migrationBuilder.DropColumn(
                name: "NewPanelQty",
                table: "SetupVerificationDChange");

            migrationBuilder.DropColumn(
                name: "OldPanelQty",
                table: "SetupVerificationDChange");

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
                    { "3c27f150-f5f9-475a-abd0-9deedaa39538", "74566cb2-a798-450a-ad7b-2f8f8688e95e", "sistemadmin", "SİSTEMADMİN" },
                    { "cb92feff-c75f-49ed-9dde-667bd4bea18a", "9f1eefc6-fa9f-472d-97c0-4dd7010af7e3", "admin", "ADMİN" },
                    { "ccacb377-d8f4-4f46-b333-2e8892adb81b", "c58dc37b-9c54-4a92-be0f-2ca4be3e2ffa", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7150), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0238f37c-26ce-452b-8a3e-55e4ce00e260"), 0, "Tolga", "c165e4f9-da87-4dbe-9cad-493a7665fcf3", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("03435aac-bfbb-47d8-ba77-0fa0958e11ea"), 0, "Seref", "63a06f61-9dd5-455c-9d1f-c54bed239217", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("330920c8-384a-49e5-bf61-8768ee73ca8f"), 0, "Hakki", "16b52901-48ce-480a-905c-f2a01e839da7", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("ad5ce058-b498-4062-b7de-afac2614428c"), 0, "Hakan", "fe90aa22-7ad4-4e5c-ab40-e69e219adbd4", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9500), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 20, 12, 7, 18, 603, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
