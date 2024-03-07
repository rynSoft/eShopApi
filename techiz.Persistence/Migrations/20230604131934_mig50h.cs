using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig50h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionProcessManual_User_TestUserId",
                table: "ProductionProcessManual");

            migrationBuilder.DropIndex(
                name: "IX_ProductionProcessManual_TestUserId",
                table: "ProductionProcessManual");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "38269ade-27e4-4ff3-967b-ed960c26db73");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3d8a6525-9881-489f-92b5-e76591601fe8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "af3557f3-bb38-4f93-8ad6-0031704311d4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10da8ab1-0511-4f77-9e97-1495ee33cc06"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("33c42893-1718-422e-ade5-eecb8c6f7dd9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("762224c0-485b-418c-9689-2a57cced6667"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ea0aa47e-01da-4cd7-bc60-afba331c4489"));

            migrationBuilder.DropColumn(
                name: "TestBeginDate",
                table: "ProductionProcessManual");

            migrationBuilder.DropColumn(
                name: "TestElapsedTime",
                table: "ProductionProcessManual");

            migrationBuilder.DropColumn(
                name: "TestEndDate",
                table: "ProductionProcessManual");

            migrationBuilder.DropColumn(
                name: "TestUserId",
                table: "ProductionProcessManual");

            migrationBuilder.CreateTable(
                name: "ProductionProcessManualTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: true),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    TestBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TestEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    TestElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    TestUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductionOperationsId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionProcessManualTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_ProductionOperations_Production~",
                        column: x => x.ProductionOperationsId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_User_TestUserId",
                        column: x => x.TestUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "117b23af-768e-4fc9-9ffe-63a45285bbd0", "9492493a-2102-4fea-b7dd-af9ff2bc1021", "depo", "DEPO" },
                    { "f13dbcfd-c05d-4623-af0a-a2fe3a5555f3", "2213f3c1-7355-4217-b546-5831f790dd35", "admin", "ADMİN" },
                    { "ffb8c8a3-bca3-46f0-828c-a2b1eab11e33", "096b42b4-282e-478e-8c89-aa68db21de6a", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1098), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1151), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1153), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1726), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4472), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("48f7a1f1-1768-49fc-9e08-2de513f1a417"), 0, "Hakki", "76150c68-2e77-4e5e-9392-8d3f329746c4", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("cac9f81c-085c-4c37-9b3b-6ea0869f2c8c"), 0, "Tolga", "a62bf4c5-4233-4ddb-93e8-8dac163d41be", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("e839a0f0-3e42-46bc-9227-bb9b820d86a4"), 0, "Seref", "010e5e65-2123-4dae-9257-826612100049", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("f04624be-abc5-4974-a356-47a5ff98a7e0"), 0, "Hakan", "626574c4-a86f-4f43-b4fa-82e7b8e00f0f", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4886), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4901), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4907), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_ProductionId",
                table: "ProductionProcessManualTest",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_ProductionOperationsId",
                table: "ProductionProcessManualTest",
                column: "ProductionOperationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_TestUserId",
                table: "ProductionProcessManualTest",
                column: "TestUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionProcessManualTest");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "117b23af-768e-4fc9-9ffe-63a45285bbd0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f13dbcfd-c05d-4623-af0a-a2fe3a5555f3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ffb8c8a3-bca3-46f0-828c-a2b1eab11e33");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("48f7a1f1-1768-49fc-9e08-2de513f1a417"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cac9f81c-085c-4c37-9b3b-6ea0869f2c8c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e839a0f0-3e42-46bc-9227-bb9b820d86a4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f04624be-abc5-4974-a356-47a5ff98a7e0"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TestBeginDate",
                table: "ProductionProcessManual",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestElapsedTime",
                table: "ProductionProcessManual",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TestEndDate",
                table: "ProductionProcessManual",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TestUserId",
                table: "ProductionProcessManual",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_TestUserId",
                table: "ProductionProcessManual",
                column: "TestUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionProcessManual_User_TestUserId",
                table: "ProductionProcessManual",
                column: "TestUserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
