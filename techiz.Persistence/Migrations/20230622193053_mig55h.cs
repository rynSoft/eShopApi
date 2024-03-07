using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig55h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8249540b-2a9f-442e-afc6-5b8bf5be284b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c21e2989-b015-4e6e-a712-3f7a503d26c9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ebed8976-70a2-4399-95d6-ac3f797e443f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b82a0a8-aff8-4ca0-9eaa-6ba1d96a7cbd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8611c627-7e14-488e-82fb-4e2b9d08347f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b07d90fb-1d4c-4925-b37a-d2e9616d0f61"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c794d537-43e3-407e-9276-661bf8ddd675"));

            migrationBuilder.CreateTable(
                name: "ShiftDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftDefinition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftDefinitionProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftDefinitionId = table.Column<int>(type: "integer", nullable: false),
                    LineId = table.Column<Guid>(type: "uuid", nullable: false),
                    LineId1 = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetQuantity = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftDefinitionProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_Line_LineId1",
                        column: x => x.LineId1,
                        principalTable: "Line",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_ShiftDefinition_ShiftDefinitionId",
                        column: x => x.ShiftDefinitionId,
                        principalTable: "ShiftDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 3, 0, 0, 0)), "Vardiya Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4406), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(7944), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 86, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[] { 32, true, new DateTimeOffset(new DateTime(2023, 6, 22, 22, 30, 52, 87, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_LineId1",
                table: "ShiftDefinitionProcess",
                column: "LineId1");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_ShiftDefinitionId",
                table: "ShiftDefinitionProcess",
                column: "ShiftDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_UserId",
                table: "ShiftDefinitionProcess",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftDefinitionProcess");

            migrationBuilder.DropTable(
                name: "ShiftDefinition");

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
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32);

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8249540b-2a9f-442e-afc6-5b8bf5be284b", "a6aa5e9c-299b-4ba5-96a0-94e97894b341", "sistemadmin", "SİSTEMADMİN" },
                    { "c21e2989-b015-4e6e-a712-3f7a503d26c9", "ccbc6c30-6713-4ca8-b25e-cdfc477975f4", "depo", "DEPO" },
                    { "ebed8976-70a2-4399-95d6-ac3f797e443f", "63a513e3-c1ad-4cf6-9843-8591d18d114e", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(6475), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(6913), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(7869), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(8179), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(8487), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 123, DateTimeKind.Unspecified).AddTicks(9979), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(1542), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(1847), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(2464), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(3947), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(4564), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(5845), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6155), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 3, 0, 0, 0)), "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6b82a0a8-aff8-4ca0-9eaa-6ba1d96a7cbd"), 0, "Tolga", "595822f9-0acc-477a-9143-592ca3082904", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("8611c627-7e14-488e-82fb-4e2b9d08347f"), 0, "Hakki", "40037ad4-f02e-4462-9ced-162f3a7b2da1", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("b07d90fb-1d4c-4925-b37a-d2e9616d0f61"), 0, "Seref", "fc4c08f3-a7ac-44b2-9915-7edc1e8baf8d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("c794d537-43e3-407e-9276-661bf8ddd675"), 0, "Hakan", "51af1a0e-4cba-402a-a26c-d0130c99d717", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6909), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6913), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 18, 16, 13, 23, 124, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
