using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig61h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "101c7cbb-0f54-4ff2-a287-312ec26bab4a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6d4931fe-6a53-40c0-babc-edadd5fb0858");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8d6ef8d2-bb08-4ab3-861b-d74d6f94ba85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2a423c23-4981-4951-b305-e351cedecc04"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4eb068d5-2dfb-4837-83ce-2a4441302be5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5ddb2ee2-1d9d-4f54-80c6-7f27432c5f7b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d3f88553-8f21-4a4a-b996-407e5f2f9efd"));

            migrationBuilder.AddColumn<int>(
                name: "LineIds",
                table: "ShiftDefinitionProcess",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03e57a4e-1377-4ab8-a276-058348123877", "626b2e53-395e-4b1b-9090-12a8bb6494f9", "admin", "ADMİN" },
                    { "6c2fc051-7154-4817-b60f-52d753b341af", "1b04a5e3-dfe5-4f47-8c75-1e52e4ea6e8f", "sistemadmin", "SİSTEMADMİN" },
                    { "e0f0daaa-043b-4975-9d3e-3f5feebbb878", "70802bc4-4eab-45a7-8016-5eb9ee68813b", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(2917), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(2961), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(2963), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(4482), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(6526), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(7225), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(7597), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(7938), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(8275), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 943, DateTimeKind.Unspecified).AddTicks(9504), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(1395), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(2353), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(3429), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(3769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(4792), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("301ad9f4-3023-4496-bf38-76fca4cf4949"), 0, "Hakan", "64692cdd-51cd-4694-81c4-cd9d56a6037c", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("614f4f80-b4a9-4b2d-9a83-4ba10dc1abb4"), 0, "Tolga", "b972107a-daf3-451f-868c-4c9240dfb323", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("7b5c4cf1-09da-4ba0-9a98-b0310bc4b635"), 0, "Seref", "f09746b4-55ee-424f-8d91-b35dba6461c7", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("dec926db-c535-4cc3-be2f-3a18c65925ad"), 0, "Hakki", "a1336aec-7008-4e7e-b03e-913b40fb5a43", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(5414), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 6, 37, 944, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "03e57a4e-1377-4ab8-a276-058348123877");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6c2fc051-7154-4817-b60f-52d753b341af");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e0f0daaa-043b-4975-9d3e-3f5feebbb878");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("301ad9f4-3023-4496-bf38-76fca4cf4949"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("614f4f80-b4a9-4b2d-9a83-4ba10dc1abb4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7b5c4cf1-09da-4ba0-9a98-b0310bc4b635"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dec926db-c535-4cc3-be2f-3a18c65925ad"));

            migrationBuilder.DropColumn(
                name: "LineIds",
                table: "ShiftDefinitionProcess");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "101c7cbb-0f54-4ff2-a287-312ec26bab4a", "7f5db870-58af-410b-8ae2-26cb637549b7", "depo", "DEPO" },
                    { "6d4931fe-6a53-40c0-babc-edadd5fb0858", "62477880-4336-41c7-9888-b85d3d2f52c4", "sistemadmin", "SİSTEMADMİN" },
                    { "8d6ef8d2-bb08-4ab3-861b-d74d6f94ba85", "8d687b89-1032-45fc-a407-b076ac8f6eb3", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(6404), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(6451), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(8427), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 995, DateTimeKind.Unspecified).AddTicks(9899), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(915), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(1962), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(3028), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(3330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(3667), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(4598), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(4939), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(7434), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8111), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2a423c23-4981-4951-b305-e351cedecc04"), 0, "Tolga", "8d76a338-fae4-4b52-b0f3-cbf746721c65", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("4eb068d5-2dfb-4837-83ce-2a4441302be5"), 0, "Hakki", "75bf1021-4b01-425f-81eb-979c58c8f793", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("5ddb2ee2-1d9d-4f54-80c6-7f27432c5f7b"), 0, "Hakan", "674cc51b-febe-4d02-8005-696bc91241b9", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("d3f88553-8f21-4a4a-b996-407e5f2f9efd"), 0, "Seref", "2cbb62c8-d7af-4a2f-8e70-1a4d56525b97", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 12, 3, 15, 996, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
