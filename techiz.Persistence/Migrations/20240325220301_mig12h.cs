using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig12h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_WorkProcessRoute_WorkProcessRouteId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_WorkProcessRouteId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4fae586c-dd70-46c1-97a4-a71f2c979132");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a484877c-8b6d-43de-adf4-18a7465da88a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d68e3581-8bc5-45fa-88ea-bb04f1412f8f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("33607edd-8d51-41c2-a452-21f8713015e4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("37254259-0d73-4937-b714-7ba640e6f133"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("42a2c681-5058-4d84-9959-70d3e2967c75"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d1e28eac-5de8-4a92-8a90-06670cbe97df"));

            migrationBuilder.DropColumn(
                name: "WorkProcessRouteId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CurrentWPRId",
                table: "Product",
                newName: "Order");

            migrationBuilder.AddColumn<int>(
                name: "NextWPRId",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50e3a770-89da-4f70-be35-4b9eea646b82", "db539550-7631-4f1c-8a30-4744cc3539f8", "sistemadmin", "SİSTEMADMİN" },
                    { "543c8e49-274b-4dce-b85c-46d5bd33c3e8", "6bc7b760-4085-430d-9454-c2273a2ac9af", "admin", "ADMİN" },
                    { "5fc1b47e-2999-43c9-8aea-350529df6daf", "a0a1de23-b2f2-4bf5-b7af-1905c9ca1261", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(1543), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(6452), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(6889), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(7308), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(8601), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 567, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(349), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(1235), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(4704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(5119), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(5534), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3f4ec8dc-b51b-4093-9146-464f2bd1cf50"), 0, "Cagan", "1e3fb7db-486f-4017-85b3-21d5e6424fb8", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("86dc0588-50ea-4576-926e-1fca2a3d36c7"), 0, "Salih", "743905d0-038f-472f-9379-0f5863610182", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("c8837177-eb1e-4031-8c1b-c09f10bc08d1"), 0, "Hakan", "9c144b7b-2f86-46da-941c-b551ad0b0dc1", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("cf2691d1-70ce-4d0c-865b-f071d7fe330e"), 0, "Tolga", "682356c9-8395-41ed-be5f-7ea486e5d34b", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(8307), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 26, 1, 3, 0, 568, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Product_NextWPRId",
                table: "Product",
                column: "NextWPRId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_WorkProcessRoute_NextWPRId",
                table: "Product",
                column: "NextWPRId",
                principalTable: "WorkProcessRoute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_WorkProcessRoute_NextWPRId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_NextWPRId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "50e3a770-89da-4f70-be35-4b9eea646b82");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "543c8e49-274b-4dce-b85c-46d5bd33c3e8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5fc1b47e-2999-43c9-8aea-350529df6daf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3f4ec8dc-b51b-4093-9146-464f2bd1cf50"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86dc0588-50ea-4576-926e-1fca2a3d36c7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c8837177-eb1e-4031-8c1b-c09f10bc08d1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cf2691d1-70ce-4d0c-865b-f071d7fe330e"));

            migrationBuilder.DropColumn(
                name: "NextWPRId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Product",
                newName: "CurrentWPRId");

            migrationBuilder.AddColumn<int>(
                name: "WorkProcessRouteId",
                table: "Product",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4fae586c-dd70-46c1-97a4-a71f2c979132", "c18df9e9-7792-4178-8a3d-1a5e72cdbf0b", "admin", "ADMİN" },
                    { "a484877c-8b6d-43de-adf4-18a7465da88a", "4d213e14-7fc7-43ba-abdc-9aede9881987", "depo", "DEPO" },
                    { "d68e3581-8bc5-45fa-88ea-bb04f1412f8f", "c23bb6c8-bb2c-4138-831a-bd5fe6520831", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(6394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(6849), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(8391), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(9112), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(9428), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 82, DateTimeKind.Unspecified).AddTicks(9741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(57), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(702), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(1009), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(1699), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(2031), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(2346), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(2656), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(4235), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(5569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(5905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(6532), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(6843), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(7251), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(8724), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33607edd-8d51-41c2-a452-21f8713015e4"), 0, "Salih", "53bc4afb-1d61-49f7-86ca-170c38f4a06c", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("37254259-0d73-4937-b714-7ba640e6f133"), 0, "Cagan", "5a1b23fb-8aef-412e-a855-687fa4e3f500", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("42a2c681-5058-4d84-9959-70d3e2967c75"), 0, "Hakan", "1aa22210-d578-40a8-85a5-f7c86eb42a93", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("d1e28eac-5de8-4a92-8a90-06670cbe97df"), 0, "Tolga", "1d9d6893-5652-4f1c-81c0-ab1cd867286d", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9461), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9464), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9466), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 24, 21, 21, 28, 83, DateTimeKind.Unspecified).AddTicks(9467), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Product_WorkProcessRouteId",
                table: "Product",
                column: "WorkProcessRouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_WorkProcessRoute_WorkProcessRouteId",
                table: "Product",
                column: "WorkProcessRouteId",
                principalTable: "WorkProcessRoute",
                principalColumn: "Id");
        }
    }
}
