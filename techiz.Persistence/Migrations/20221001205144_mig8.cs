using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "667a0f8a-2a36-42cd-a664-80448ba09521");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e6291d38-3c99-4b10-b894-a82143da3b46");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ea2d1351-30e4-4c1c-bfa5-6ee302001819");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0cb20331-caab-4284-a6ee-7bb02e4e592c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7750d857-33c4-49bd-8e2d-4337cea138b5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96814869-b038-4fef-b55d-9c6add97bb1c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("db264e27-176f-42b9-ae10-2d71f933091e"));

            migrationBuilder.CreateTable(
                name: "SetupVerificationDChange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    OldBomKitInfoId = table.Column<int>(type: "integer", nullable: false),
                    BomKitInfoOldId = table.Column<int>(type: "integer", nullable: true),
                    NewBomKitInfoId = table.Column<int>(type: "integer", nullable: false),
                    BomKitInfoNewId = table.Column<int>(type: "integer", nullable: true),
                    OldPanelId = table.Column<int>(type: "integer", nullable: false),
                    OldPanelsId = table.Column<int>(type: "integer", nullable: true),
                    NewPanelId = table.Column<int>(type: "integer", nullable: false),
                    NewPanelsId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupVerificationDChange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoNewId",
                        column: x => x.BomKitInfoNewId,
                        principalTable: "BomKitInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_BomKitInfo_BomKitInfoOldId",
                        column: x => x.BomKitInfoOldId,
                        principalTable: "BomKitInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelsId",
                        column: x => x.NewPanelsId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelsId",
                        column: x => x.OldPanelsId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81ecab3c-1cef-48c7-8b06-83abcffae864", "8189cba9-a43c-4a12-bc13-dbc5e2e1a7b8", "sistemadmin", "SİSTEMADMİN" },
                    { "95a6ffbb-d08a-4248-8838-6eb5595500f6", "e1c5a80e-f938-4866-be5f-2383c7cb7ec8", "admin", "ADMİN" },
                    { "a6c2e60d-9ff3-45e1-a48e-e4d373352756", "e99e09f7-a282-4e7c-9856-f2b905f499b4", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(9650), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 169, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("51a6c840-e7fe-4424-90ae-82be04405a42"), 0, "Hakan", "ca943061-d004-49eb-8f69-0162c159fe41", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("be1a0a93-a7b5-4029-9abc-1e1a1380813d"), 0, "Seref", "1f6138fa-f6d9-4466-83c6-f29b8cb8f41d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("d95138df-73fc-442d-911d-a67f33a3a2e5"), 0, "Hakki", "536bbdbe-636a-4bff-b7fa-b4e68f789102", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("face4d9d-0fae-4e27-83bf-87b87c03babf"), 0, "Tolga", "9d89e635-4490-4d46-9bef-d80636151def", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(1050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 23, 51, 43, 170, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_BomKitInfoNewId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoNewId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_BomKitInfoOldId",
                table: "SetupVerificationDChange",
                column: "BomKitInfoOldId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_NewPanelsId",
                table: "SetupVerificationDChange",
                column: "NewPanelsId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_OldPanelsId",
                table: "SetupVerificationDChange",
                column: "OldPanelsId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_ProductionId",
                table: "SetupVerificationDChange",
                column: "ProductionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetupVerificationDChange");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "81ecab3c-1cef-48c7-8b06-83abcffae864");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "95a6ffbb-d08a-4248-8838-6eb5595500f6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a6c2e60d-9ff3-45e1-a48e-e4d373352756");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51a6c840-e7fe-4424-90ae-82be04405a42"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("be1a0a93-a7b5-4029-9abc-1e1a1380813d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d95138df-73fc-442d-911d-a67f33a3a2e5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("face4d9d-0fae-4e27-83bf-87b87c03babf"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "667a0f8a-2a36-42cd-a664-80448ba09521", "04b58598-f391-4355-a33d-7fb36a90bd8a", "admin", "ADMİN" },
                    { "e6291d38-3c99-4b10-b894-a82143da3b46", "c3edd69c-0eb9-4eac-9b6e-62f3b54a4cf3", "sistemadmin", "SİSTEMADMİN" },
                    { "ea2d1351-30e4-4c1c-bfa5-6ee302001819", "60f142ef-9b91-445b-afc0-576732840003", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(7310), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(9360), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 575, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0cb20331-caab-4284-a6ee-7bb02e4e592c"), 0, "Hakan", "c2a60d8d-f133-40a4-84ee-dd1695bbffa9", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("7750d857-33c4-49bd-8e2d-4337cea138b5"), 0, "Seref", "dc130937-fe88-4bb1-982a-dec7001c6900", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("96814869-b038-4fef-b55d-9c6add97bb1c"), 0, "Hakki", "3387de62-e812-4e96-986b-9013d2fe639b", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("db264e27-176f-42b9-ae10-2d71f933091e"), 0, "Tolga", "2d27d9bb-fbb5-49ce-924c-52edd7f45a6c", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 1, 21, 59, 11, 576, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
