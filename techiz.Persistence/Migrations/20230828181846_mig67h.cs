using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig67h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "03ee2011-1a38-406a-b043-1925f8d3d1d5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "08513791-b25b-48f6-a703-8f1b962f2e4b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ca9c23e5-a448-4a5a-9faf-d9e1685275a4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2b4c5b80-5121-47aa-a3c6-5ff15388c897"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7560d1df-a138-45bd-b9e7-09ec7af9d865"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("849c1aa8-fcf5-4cc9-8fb4-498a78ef1bb2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("afcdf9a3-b8a4-44db-aa61-3dcd96e4123c"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1381f12d-ff42-4023-8946-6c0b17736258", "8f2c093f-8929-4c63-a69c-210f245cc34a", "sistemadmin", "SİSTEMADMİN" },
                    { "14a18817-51c6-44f2-b629-9e0839cdcdc4", "ba1925b5-0bb0-4c03-b6dd-0ee439064bb8", "admin", "ADMİN" },
                    { "3fb2049d-ee71-435f-b1a2-9ac7699906f3", "ba134c3d-295d-468f-bed7-dae91a3476c1", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(2684), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(3298), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(4535), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(7075), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(8440), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 407, DateTimeKind.Unspecified).AddTicks(9757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(1075), new TimeSpan(0, 3, 0, 0, 0)), "Oee Gösterim" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(1768), new TimeSpan(0, 3, 0, 0, 0)), "Vardiya - Hat Hedef Miktar Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(4298), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(4941), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(7449), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 408, DateTimeKind.Unspecified).AddTicks(9827), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[] { 34, true, new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9ecc64ae-3c82-420f-91e3-38b304d194e3"), 0, "Tolga", "7eee776d-4913-4df2-aec0-30579a837f2f", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("c7aae14d-cce3-4816-a13f-dff0c54db7ac"), 0, "Hakan", "38e5e66a-e376-4ea8-a5e5-a6e5f6cbf546", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("d0fd91cb-544d-4bba-9e0f-0b82973aa347"), 0, "Seref", "f5536f13-b852-4328-aebe-6fab904c5c0a", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("ffaf0acc-be18-4adb-a4e0-d484019c0e19"), 0, "Hakki", "51183e08-2357-44aa-a82f-fb0468893237", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(3692), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 28, 21, 18, 45, 409, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1381f12d-ff42-4023-8946-6c0b17736258");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "14a18817-51c6-44f2-b629-9e0839cdcdc4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3fb2049d-ee71-435f-b1a2-9ac7699906f3");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9ecc64ae-3c82-420f-91e3-38b304d194e3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7aae14d-cce3-4816-a13f-dff0c54db7ac"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d0fd91cb-544d-4bba-9e0f-0b82973aa347"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ffaf0acc-be18-4adb-a4e0-d484019c0e19"));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03ee2011-1a38-406a-b043-1925f8d3d1d5", "6d1962df-6b7a-4200-a4dc-ba11cce3e523", "depo", "DEPO" },
                    { "08513791-b25b-48f6-a703-8f1b962f2e4b", "8bad39f7-8e93-41a3-810d-b4fb713abdb1", "admin", "ADMİN" },
                    { "ca9c23e5-a448-4a5a-9faf-d9e1685275a4", "c3cdc44e-5c14-4904-9b95-d363039e2247", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(7777), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(8756), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(9056), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(9393), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 316, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(313), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(1827), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(2426), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 3, 0, 0, 0)), "Vardiya - Hat Hedef Miktar Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 3, 0, 0, 0)), "Mola Tanımları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 3, 0, 0, 0)), "Tamamlanan Kalite Operasyonları" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 3, 0, 0, 0)), "Üretim Planlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(3961), new TimeSpan(0, 3, 0, 0, 0)), "Kit Hazırlama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 3, 0, 0, 0)), "Kit Doğrulama" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 3, 0, 0, 0)), "Setup Verification" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 3, 0, 0, 0)), "Ayarlar" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 3, 0, 0, 0)), "Credential" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 3, 0, 0, 0)), "Kalite" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 3, 0, 0, 0)), "Dashboard" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 3, 0, 0, 0)), "Rol Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(6519), new TimeSpan(0, 3, 0, 0, 0)), "Rol Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 3, 0, 0, 0)), "Rol Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(7164), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Görüntüle" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(7844), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 3, 0, 0, 0)), "KullaniciGrup All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 3, 0, 0, 0)), "LogAll" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2b4c5b80-5121-47aa-a3c6-5ff15388c897"), 0, "Seref", "d5bd78d3-2bda-4b93-8f8b-69373afa698e", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("7560d1df-a138-45bd-b9e7-09ec7af9d865"), 0, "Tolga", "ed7ddfbd-2b64-413f-95b4-7d8a44ba2f0a", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("849c1aa8-fcf5-4cc9-8fb4-498a78ef1bb2"), 0, "Hakan", "6299ea04-3de9-411d-9401-0b97aa8c6e0a", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("afcdf9a3-b8a4-44db-aa61-3dcd96e4123c"), 0, "Hakki", "37ef6318-c60b-44c9-a398-5928105f94b4", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 8, 11, 23, 33, 2, 317, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
