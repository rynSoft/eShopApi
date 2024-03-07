using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mt51t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18cd02b6-bab9-497e-8cf2-9407645298dd", "a11d7560-c31d-433f-b039-d8ea8f07488a", "sistemadmin", "SİSTEMADMİN" },
                    { "39d50858-e618-4bf2-ae0c-d0ae9cfce1b2", "58ffa714-8300-4943-b3c8-728b124387db", "admin", "ADMİN" },
                    { "4b7bcbd2-98f8-41b6-bd4f-7214449bd906", "fdc132e5-2360-4ede-8d95-826b1a4f0b0f", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2011), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2037), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Bandı" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2653), new TimeSpan(0, 3, 0, 0, 0)), "Etiketleme" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 3, 0, 0, 0)), "Display Montajı" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(3171), new TimeSpan(0, 3, 0, 0, 0)), "Programlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 3, 0, 0, 0)), "Panelden Ayırma" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(3635), new TimeSpan(0, 3, 0, 0, 0)), "Test" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(3877), new TimeSpan(0, 3, 0, 0, 0)), "Kalite Süreçler" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 3, 0, 0, 0)), "Kalite Onaylar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(4314), new TimeSpan(0, 3, 0, 0, 0)), "Kalite Operasyonlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(4543), new TimeSpan(0, 3, 0, 0, 0)), "Depo Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 3, 0, 0, 0)), "Hat Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(5010), new TimeSpan(0, 3, 0, 0, 0)), "Makine Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 19, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Setup Verification" },
                    { 20, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Ayarlar" },
                    { 21, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Credential" },
                    { 22, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite" },
                    { 23, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Dashboard" },
                    { 24, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(7324), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Görüntüle" },
                    { 25, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(7536), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Kaydet" },
                    { 26, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Sil" },
                    { 27, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Görüntüle" },
                    { 28, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Kaydet" },
                    { 29, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(8372), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Sil" },
                    { 30, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(8583), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KullaniciGrup All" },
                    { 31, true, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("55df8d6b-ec60-45ad-9c7d-32ac761e7e21"), 0, "Tolga", "3ce03828-ba03-4a4c-9829-95c05cd06642", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("bc12dc7f-d838-4a6c-a8a5-6f72d25aed7e"), 0, "Hakki", "9fb4ccf8-621b-41ec-9de0-efe7e64a9179", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("ebafe8af-c8ba-4647-aab9-5d93e8ef225a"), 0, "Hakan", "da7ff646-fe48-4e04-a944-9c8a5b6a7c36", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("ed39f404-922a-47f0-afd0-c6f14cb14ac9"), 0, "Seref", "c7efe8ed-4e36-4532-801c-70a59e37464d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(9046), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(9048), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 22, 53, 932, DateTimeKind.Unspecified).AddTicks(9051), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "18cd02b6-bab9-497e-8cf2-9407645298dd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "39d50858-e618-4bf2-ae0c-d0ae9cfce1b2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4b7bcbd2-98f8-41b6-bd4f-7214449bd906");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("55df8d6b-ec60-45ad-9c7d-32ac761e7e21"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bc12dc7f-d838-4a6c-a8a5-6f72d25aed7e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ebafe8af-c8ba-4647-aab9-5d93e8ef225a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ed39f404-922a-47f0-afd0-c6f14cb14ac9"));

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
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1726), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Uretim.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.UretimPlanlama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2117), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitHazirlama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitDogrulama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.SetupVerification.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Ayarlar.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Credential.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Kalite.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Dashboard.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, 3, 0, 0, 0)), "Role.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 3, 0, 0, 0)), "Role.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 3, 0, 0, 0)), "Role.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4472), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KullaniciGrup.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 16, 19, 33, 91, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Log.All" });

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
        }
    }
}
