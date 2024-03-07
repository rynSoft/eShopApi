using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig65h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "10db9ce0-3055-4f7f-b693-1655d224dcb8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d6d9f4f-1240-4175-badf-3ff890e2fb52");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e3e19fe7-3d48-49f4-8319-51449bea44d2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3dd0faf1-f17c-4674-88d4-96ac5faba1bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("758a70c4-247f-447b-a410-844a879224f0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8840663d-58f6-4e90-860b-163e4cee2524"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a335881a-e6bd-4385-92dc-871bfa99e577"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f200c42-866b-4141-abb8-6dc676c725a6", "84dbee96-dfa0-4ba0-8ff5-e153c1d829d6", "depo", "DEPO" },
                    { "3935bcb8-3ed2-4d5c-ad0e-4144e1c4ac9a", "245d35e2-7033-405d-b5c6-873652e4e493", "admin", "ADMİN" },
                    { "86cf2ee9-5f0c-43f6-be48-bedc29b116b0", "792ae80e-0662-4965-9201-7c027f5eca99", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 607, DateTimeKind.Unspecified).AddTicks(9741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 607, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 607, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 607, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(423), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(1236), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(3249), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(3595), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(3942), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(4683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 3, 0, 0, 0)), "Vardiya - Hat Hedef Miktar Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(7193), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(7547), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(9023), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(9369), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 608, DateTimeKind.Unspecified).AddTicks(9730), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(1201), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[] { 33, true, new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0ae49c94-c50b-456a-9022-2f3b408021b0"), 0, "Seref", "4c10bee3-e54d-4594-bab6-782fe84d550a", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("155775d8-85dd-4e32-a6a2-6a3496d3e889"), 0, "Hakki", "44cdb74a-3e7c-4af4-85e5-aebca02b8afd", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("7c893380-b742-4f26-83f5-6c653ff01d85"), 0, "Tolga", "f8671465-033f-4786-96ea-865af479d38d", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("e98e0006-fabd-4a7c-a8c7-6e1ad169bf3a"), 0, "Hakan", "a3b444f9-d803-49c0-ab11-f8af19409157", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(3195), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 22, 1, 44, 609, DateTimeKind.Unspecified).AddTicks(3197), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2f200c42-866b-4141-abb8-6dc676c725a6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3935bcb8-3ed2-4d5c-ad0e-4144e1c4ac9a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "86cf2ee9-5f0c-43f6-be48-bedc29b116b0");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0ae49c94-c50b-456a-9022-2f3b408021b0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("155775d8-85dd-4e32-a6a2-6a3496d3e889"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7c893380-b742-4f26-83f5-6c653ff01d85"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e98e0006-fabd-4a7c-a8c7-6e1ad169bf3a"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10db9ce0-3055-4f7f-b693-1655d224dcb8", "6371feb3-24ae-4dfb-9406-e73ed693a6df", "admin", "ADMİN" },
                    { "9d6d9f4f-1240-4175-badf-3ff890e2fb52", "eee02c6a-e1d5-401b-aaeb-ee605fcc1a2c", "depo", "DEPO" },
                    { "e3e19fe7-3d48-49f4-8319-51449bea44d2", "0679a846-be69-49d0-9c59-d4c70186333f", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(6603), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(7966), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(8262), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(9213), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 463, DateTimeKind.Unspecified).AddTicks(9769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3816), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5949), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 3, 0, 0, 0)), "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3dd0faf1-f17c-4674-88d4-96ac5faba1bc"), 0, "Hakan", "740e4f8f-c0b7-481d-a5a2-1dd1253b8425", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("758a70c4-247f-447b-a410-844a879224f0"), 0, "Hakki", "905a62f1-a4bd-4c37-bf98-879dd4eb57b8", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("8840663d-58f6-4e90-860b-163e4cee2524"), 0, "Tolga", "f01de2b7-9433-4079-aa89-ada4620108e1", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("a335881a-e6bd-4385-92dc-871bfa99e577"), 0, "Seref", "e26a4479-26aa-4950-860f-0fd510030248", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
