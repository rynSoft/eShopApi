using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class _46t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3dfce9de-632d-4fb6-b630-e42ae63f1efd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "909304c4-753c-46e5-afc2-b29d3f3f5645");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0a9ecd7-b96e-422f-bbfb-f3ca4b00ad03");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("37da79c3-e6c7-46fa-a7e0-ffe80c600d82"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5539cf61-7cef-43b3-927f-97282ccbca22"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("abe9a48b-b4a8-45c6-9d18-1af3cfa80b9f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cfd29dce-28e3-4874-87c9-81655fafd63c"));

            migrationBuilder.CreateTable(
                name: "ProductionProcessManual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: true),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    LabelingBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LabelingEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LabelingElapsedTime = table.Column<int>(type: "integer", nullable: false),
                    LabelingUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayAssemblyBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DisplayAssemblyEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DisplayAssemblyElapsedTime = table.Column<int>(type: "integer", nullable: false),
                    DisplayAssemblyLotNo = table.Column<string>(type: "text", nullable: true),
                    DisplayUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgrammingBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ProgrammingEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ProgrammingElapsedTime = table.Column<int>(type: "integer", nullable: false),
                    ProgrammingUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DetachFromPanelBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DetachFromPanelEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DetachFromPanelElapsedTime = table.Column<int>(type: "integer", nullable: false),
                    DetachFromPanelUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TestBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TestEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TestElapsedTime = table.Column<int>(type: "integer", nullable: false),
                    TestUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionProcessManual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_DetachFromPanelUserId",
                        column: x => x.DetachFromPanelUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_DisplayUserId",
                        column: x => x.DisplayUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_LabelingUserId",
                        column: x => x.LabelingUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_ProgrammingUserId",
                        column: x => x.ProgrammingUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_TestUserId",
                        column: x => x.TestUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "111fb2c5-4174-48fd-a6fb-98e15de053b8", "9bd112b3-7a99-43e8-bcd7-4ccb5afcb848", "admin", "ADMİN" },
                    { "e817ee4f-5b13-442e-888e-3c22ab75f31b", "11d9f3c6-de9f-4288-b34f-f768384a215a", "depo", "DEPO" },
                    { "ead7710b-dfcc-4c84-baf2-e7cb9233030d", "e4d2a929-274b-4578-8b7d-af3a1a21cb7a", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8385), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8646), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9681), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4076cae5-f028-41d1-816c-50f260aa076c"), 0, "Tolga", "068ec39c-39c9-41a5-a759-4199700de85d", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("485a2997-f80d-423d-8c0e-6c14f29ecf5e"), 0, "Seref", "f3a140a5-0969-4de4-bfd8-a1f274de8041", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("746ec574-d10b-4fb2-8f95-6fb7f8cac3ee"), 0, "Hakki", "8cee99d4-5e0a-4b26-bdba-99acea4f33ab", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("7b1f79d4-15a5-4d02-b0d3-f64eff1fac98"), 0, "Hakan", "053786fd-b26f-4fb8-b328-30d17d96445d", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9972), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 19, 12, 15, 8, 246, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_DetachFromPanelUserId",
                table: "ProductionProcessManual",
                column: "DetachFromPanelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_DisplayUserId",
                table: "ProductionProcessManual",
                column: "DisplayUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_LabelingUserId",
                table: "ProductionProcessManual",
                column: "LabelingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_ProductionId",
                table: "ProductionProcessManual",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_ProgrammingUserId",
                table: "ProductionProcessManual",
                column: "ProgrammingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_TestUserId",
                table: "ProductionProcessManual",
                column: "TestUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionProcessManual");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "111fb2c5-4174-48fd-a6fb-98e15de053b8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e817ee4f-5b13-442e-888e-3c22ab75f31b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ead7710b-dfcc-4c84-baf2-e7cb9233030d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4076cae5-f028-41d1-816c-50f260aa076c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("485a2997-f80d-423d-8c0e-6c14f29ecf5e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("746ec574-d10b-4fb2-8f95-6fb7f8cac3ee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7b1f79d4-15a5-4d02-b0d3-f64eff1fac98"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dfce9de-632d-4fb6-b630-e42ae63f1efd", "9f37c4d3-e2d6-4af8-9bb6-ca813bc62133", "admin", "ADMİN" },
                    { "909304c4-753c-46e5-afc2-b29d3f3f5645", "b1a91fe1-d938-4a7f-b9eb-67b03dd6807b", "depo", "DEPO" },
                    { "f0a9ecd7-b96e-422f-bbfb-f3ca4b00ad03", "77e4afd2-021d-4d9e-8936-04e65f71c2f8", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7251), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7694), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7824), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9346), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("37da79c3-e6c7-46fa-a7e0-ffe80c600d82"), 0, "Tolga", "b03130a7-2591-438d-b269-164a4312048c", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("5539cf61-7cef-43b3-927f-97282ccbca22"), 0, "Hakan", "5036e273-5789-4586-9b46-9d3b4b82d770", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("abe9a48b-b4a8-45c6-9d18-1af3cfa80b9f"), 0, "Seref", "f186b068-1f45-4d65-a99e-6ce46136226b", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("cfd29dce-28e3-4874-87c9-81655fafd63c"), 0, "Hakki", "c6ed776d-ec67-461e-82d0-64f2295946d8", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9887), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9896), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
