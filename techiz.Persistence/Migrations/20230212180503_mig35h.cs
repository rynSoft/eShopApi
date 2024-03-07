using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig35h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "828bf22c-d28f-4974-b89a-77a0e9392871");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2df0dcd-8802-4ffc-baa6-ad68f74b51f9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c3b75a25-8d59-4911-b78f-2dd14aa4da78");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("30309092-4e4d-4670-af8e-9edf02905c2e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("31b089c6-be6d-4997-b562-8c12ece2299f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("500d0e82-84b3-44c4-9395-b6d586a746fd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bef3c7ce-8a63-4251-bfe7-ddfc2f5a9d56"));

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "SetupVerificationDChange",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2edf30a8-912d-425e-9df3-16428694eb9d", "38279ce1-fa7c-47a2-93da-8841765bed37", "depo", "DEPO" },
                    { "30ba9806-77bc-4ca1-b4b3-17bac746d0df", "68ddae5d-e301-4153-b2b0-e53192ba3bd7", "sistemadmin", "SİSTEMADMİN" },
                    { "deba96f2-dbfb-4af3-ad68-49e9d1b13310", "b040a5d9-130a-4c8c-bbe8-b4df6fc577c5", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 537, DateTimeKind.Unspecified).AddTicks(9470), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 537, DateTimeKind.Unspecified).AddTicks(9520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 537, DateTimeKind.Unspecified).AddTicks(9520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 537, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(30), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1da67c2a-78f5-4298-b952-51986054e2e3"), 0, "Hakan", "bf153543-33bc-4760-b4d5-4c7b022c97fb", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("4a283619-384c-4e7d-b436-a33bf58947e2"), 0, "Tolga", "a2403573-fdff-4911-9fd3-c1d163016aa7", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("626667a8-db9a-4e1f-bf23-c160de084101"), 0, "Seref", "00c99d84-cedb-4feb-8343-4970f5539711", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("80fe8754-71c3-405c-81da-80e53c0680ad"), 0, "Hakki", "f0b8c5e5-19c3-4ce1-af7b-b257e70f3103", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 21, 5, 2, 538, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_MachineId",
                table: "SetupVerificationDChange",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_MachineId",
                table: "ProductionOperations",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionOperations_Machine_MachineId",
                table: "ProductionOperations",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SetupVerificationDChange_Machine_MachineId",
                table: "SetupVerificationDChange",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionOperations_Machine_MachineId",
                table: "ProductionOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_SetupVerificationDChange_Machine_MachineId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_SetupVerificationDChange_MachineId",
                table: "SetupVerificationDChange");

            migrationBuilder.DropIndex(
                name: "IX_ProductionOperations_MachineId",
                table: "ProductionOperations");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2edf30a8-912d-425e-9df3-16428694eb9d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30ba9806-77bc-4ca1-b4b3-17bac746d0df");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "deba96f2-dbfb-4af3-ad68-49e9d1b13310");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1da67c2a-78f5-4298-b952-51986054e2e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4a283619-384c-4e7d-b436-a33bf58947e2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("626667a8-db9a-4e1f-bf23-c160de084101"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("80fe8754-71c3-405c-81da-80e53c0680ad"));

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "SetupVerificationDChange");

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "828bf22c-d28f-4974-b89a-77a0e9392871", "601ebf42-fd0b-4d1e-a8c9-bd44f6dd9e6d", "sistemadmin", "SİSTEMADMİN" },
                    { "c2df0dcd-8802-4ffc-baa6-ad68f74b51f9", "272cccc1-2e29-44a5-8f71-41ad4bd0e611", "depo", "DEPO" },
                    { "c3b75a25-8d59-4911-b78f-2dd14aa4da78", "61574c75-29a6-4b53-8e20-86b00fa902b4", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(7850), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8592), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(8913), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9440), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9653), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("30309092-4e4d-4670-af8e-9edf02905c2e"), 0, "Seref", "a1308534-cfd5-4511-8827-e067ede1a446", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("31b089c6-be6d-4997-b562-8c12ece2299f"), 0, "Tolga", "4fa394cf-de19-4576-80d3-d2afb9fd7d00", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("500d0e82-84b3-44c4-9395-b6d586a746fd"), 0, "Hakki", "731fcbdd-0d46-4276-aac0-be92ecc62752", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("bef3c7ce-8a63-4251-bfe7-ddfc2f5a9d56"), 0, "Hakan", "c90de50f-d12a-4bd5-98fd-c67e78f896b5", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9789), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 13, 6, 58, 900, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
