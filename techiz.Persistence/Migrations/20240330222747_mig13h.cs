using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig13h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<double>(
                name: "ElapsedTime",
                table: "ProductHistories",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "848893e6-40c5-4c49-b119-02205812cf9e", "118edb63-a38b-4f89-b20f-da6246c6c285", "depo", "DEPO" },
                    { "9ba8132c-3a11-42d5-8d72-07182d5b96f7", "9936bb20-0914-41b4-9ac5-cbfd7887c866", "sistemadmin", "SİSTEMADMİN" },
                    { "e8788e2a-164f-417b-9c4a-05a2ceba6ee2", "c1daa5f0-31ff-4fcf-9b2c-24a020d28cd2", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(1981), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(3325), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(6229), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(7173), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 754, DateTimeKind.Unspecified).AddTicks(9636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(2362), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(2742), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(5589), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(6378), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(7136), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(7521), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ddd3c29-e37e-4690-83a9-08ef142d7c30"), 0, "Cagan", "d91d2580-af5f-4371-a860-91079e31b38e", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("7ad05650-5537-4bfe-8c64-323db8f7e59f"), 0, "Hakan", "50981519-767e-472f-a637-c20c4cb7325c", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("d4eb6b01-7f76-4d3f-84ba-3dca744658be"), 0, "Salih", "8f9f270f-4215-451b-8bbd-4a4bf6a82aeb", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("f5846084-5ea0-414b-912a-1634bd7a881a"), 0, "Tolga", "f48dd138-3f80-4cb3-bb3b-2f07f2813253", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(8184), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 31, 1, 27, 46, 755, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "848893e6-40c5-4c49-b119-02205812cf9e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9ba8132c-3a11-42d5-8d72-07182d5b96f7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e8788e2a-164f-417b-9c4a-05a2ceba6ee2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1ddd3c29-e37e-4690-83a9-08ef142d7c30"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7ad05650-5537-4bfe-8c64-323db8f7e59f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d4eb6b01-7f76-4d3f-84ba-3dca744658be"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f5846084-5ea0-414b-912a-1634bd7a881a"));

            migrationBuilder.AlterColumn<int>(
                name: "ElapsedTime",
                table: "ProductHistories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

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
        }
    }
}
