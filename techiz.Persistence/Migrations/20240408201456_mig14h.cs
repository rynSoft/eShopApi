using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig14h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Metarialds",
                table: "ProductHistories",
                type: "jsonb",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    WareHouseId = table.Column<int>(type: "integer", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PartyNumber = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: true),
                    RemainQuantity = table.Column<double>(type: "double precision", nullable: true),
                    DecreaseQuantity = table.Column<double>(type: "double precision", nullable: true),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_WareHouse_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "WareHouse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaterialDecreaseHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProcessRouteId = table.Column<int>(type: "integer", nullable: true),
                    MaterialId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDecreaseHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialDecreaseHistory_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MaterialDecreaseHistory_WorkProcessRoute_WorkProcessRouteId",
                        column: x => x.WorkProcessRouteId,
                        principalTable: "WorkProcessRoute",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkProcessRouteMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkProcessRouteId = table.Column<int>(type: "integer", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkProcessRouteMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkProcessRouteMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkProcessRouteMaterial_WorkProcessRoute_WorkProcessRouteId",
                        column: x => x.WorkProcessRouteId,
                        principalTable: "WorkProcessRoute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09e1005d-abd0-4109-acd1-05257c2c12e9", "ac62defe-2596-4337-bf8e-255e1d5a95ef", "sistemadmin", "SİSTEMADMİN" },
                    { "b4b2fe01-5a62-4280-b22b-6e47555f015a", "e724a885-9e90-494b-aa54-43f06d87b5ba", "admin", "ADMİN" },
                    { "d91520be-b7f7-4157-bad1-ec8c38854881", "efbe24c1-6b4f-4c66-ab7c-ea7b745b2578", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(8219), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(9280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(9579), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 701, DateTimeKind.Unspecified).AddTicks(9860), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(992), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(3274), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(4118), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(4391), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(4666), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(4941), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(5491), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(5775), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(6055), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(6925), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(7469), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5265d522-47db-4b6d-aea4-aaee256d89a8"), 0, "Tolga", "499f3cc5-f281-43b3-8b52-b3df4ec61475", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("5b8cb599-ae94-435f-a631-d672cf3f0acf"), 0, "Hakan", "ffa3e514-e6b8-44f5-8c53-6884aed021b6", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("880c326c-590e-49e3-bbc8-16b768d94912"), 0, "Salih", "cbf82a44-71fc-4853-825a-08df9950485e", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("bf3ea00b-5798-4a12-a452-e962fa8bacb3"), 0, "Cagan", "537c47b2-bab2-426a-aac5-7133bb8a2ddb", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("c5279a59-439b-4276-9465-fe8c691080b6"), 0, "Techiz", "eef0574b-3566-4686-a00f-4e69a08e5516", "techiz@sentytech.com", true, "techiz@sentytech.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Techiz", null, false, "Techiz" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 8, 23, 14, 55, 702, DateTimeKind.Unspecified).AddTicks(9801), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Material_ProductionId",
                table: "Material",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_WareHouseId",
                table: "Material",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDecreaseHistory_MaterialId",
                table: "MaterialDecreaseHistory",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDecreaseHistory_WorkProcessRouteId",
                table: "MaterialDecreaseHistory",
                column: "WorkProcessRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkProcessRouteMaterial_MaterialId",
                table: "WorkProcessRouteMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkProcessRouteMaterial_WorkProcessRouteId",
                table: "WorkProcessRouteMaterial",
                column: "WorkProcessRouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialDecreaseHistory");

            migrationBuilder.DropTable(
                name: "WorkProcessRouteMaterial");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "09e1005d-abd0-4109-acd1-05257c2c12e9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b4b2fe01-5a62-4280-b22b-6e47555f015a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d91520be-b7f7-4157-bad1-ec8c38854881");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5265d522-47db-4b6d-aea4-aaee256d89a8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5b8cb599-ae94-435f-a631-d672cf3f0acf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("880c326c-590e-49e3-bbc8-16b768d94912"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea00b-5798-4a12-a452-e962fa8bacb3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5279a59-439b-4276-9465-fe8c691080b6"));

            migrationBuilder.DropColumn(
                name: "Metarialds",
                table: "ProductHistories");

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
    }
}
