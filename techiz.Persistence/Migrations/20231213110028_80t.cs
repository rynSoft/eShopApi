using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class _80t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3aeffa84-67a5-4b90-959d-fa14b3189e9d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "88044167-a53b-4ac3-8ee4-fc65524074dd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ba6e1454-8310-40d4-b3c9-fc0200b35e44");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("464f251c-6ac8-4abd-8795-0ce9c936839c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca861c68-1812-41b7-95e4-06dd39e6a46c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f3e06e45-66f7-4b70-a279-75a6b1d7026a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa937b69-624b-4a38-b1f5-c63d41341ffc"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8edf3009-24a2-433f-a3e6-e3792f4cce27", "903faea9-0343-44f1-9036-b529a24cac1a", "admin", "ADMİN" },
                    { "c0d57f49-1fa7-4615-a55f-5e3f7defbb53", "97085bc6-3b21-4324-b9cb-a865f3a964aa", "depo", "DEPO" },
                    { "ef4f0886-fcb2-4b2a-9f0a-35608543bfc8", "77b1438d-4db9-47c7-98ba-35d293de861d", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(2382), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(2414), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(2417), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(2708), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(3311), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(5989), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(7805), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(8429), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(9023), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 104, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(237), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 35, true, new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Sil" },
                    { 36, true, new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KullaniciGrup All" },
                    { 37, true, new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(3639), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2c973215-b533-4f1e-9436-68a3ac3eb5cf"), 0, "Hakki", "a7e2af1c-4144-4c4d-8869-8b65cb4577fc", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("a31a3905-6b62-458a-8294-cdaad5f47be2"), 0, "Hakan", "0dd70055-c6ee-441b-9861-49440d2f294a", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("c0826aa7-3a4d-4bf0-9c3d-72483dd1a3e3"), 0, "Tolga", "0735e994-0d44-4342-b605-a9329201b326", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("c6fe2c79-919b-458f-a207-258ccea8c66a"), 0, "Seref", "982a31f4-2986-44a9-9c6c-cad2cc0aa200", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(4020), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 13, 14, 0, 28, 105, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8edf3009-24a2-433f-a3e6-e3792f4cce27");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c0d57f49-1fa7-4615-a55f-5e3f7defbb53");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ef4f0886-fcb2-4b2a-9f0a-35608543bfc8");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2c973215-b533-4f1e-9436-68a3ac3eb5cf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a31a3905-6b62-458a-8294-cdaad5f47be2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c0826aa7-3a4d-4bf0-9c3d-72483dd1a3e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6fe2c79-919b-458f-a207-258ccea8c66a"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3aeffa84-67a5-4b90-959d-fa14b3189e9d", "be64a3c9-8ab8-47d9-823c-958fa380e718", "sistemadmin", "SİSTEMADMİN" },
                    { "88044167-a53b-4ac3-8ee4-fc65524074dd", "c063a8f0-bdc7-4811-b703-d1fed4ab4fb7", "admin", "ADMİN" },
                    { "ba6e1454-8310-40d4-b3c9-fc0200b35e44", "af676fa8-8224-481a-8cb2-6c5ee9486230", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(8698), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(9533), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 127, DateTimeKind.Unspecified).AddTicks(9940), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(302), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(2916), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(3217), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(4473), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(4776), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(6626), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 128, DateTimeKind.Unspecified).AddTicks(9738), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 3, 0, 0, 0)), "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("464f251c-6ac8-4abd-8795-0ce9c936839c"), 0, "Seref", "e000bcc9-fa1c-4bb1-aaba-d84732da747c", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("ca861c68-1812-41b7-95e4-06dd39e6a46c"), 0, "Hakki", "3b6a6b5a-7a4c-44c1-ae8c-7df87610a244", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("f3e06e45-66f7-4b70-a279-75a6b1d7026a"), 0, "Tolga", "fada8142-6a96-4a7a-a989-42a0e18dec9d", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("fa937b69-624b-4a38-b1f5-c63d41341ffc"), 0, "Hakan", "26bd32ee-0efc-4e56-a253-f464959474e5", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(471), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 12, 11, 22, 41, 23, 129, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
