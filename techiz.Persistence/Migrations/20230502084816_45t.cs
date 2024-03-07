using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class _45t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "47fa324e-f581-4a24-9c33-0c49c953ba2a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7e484085-f128-4101-8738-dca3cdabe669");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aab60108-6f8d-434c-a0a7-ba8bfcf28be7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("21203893-18b8-46fc-9f6a-847d8bd58e4a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6bfdb348-d187-4a08-a186-e09f7f3ce0ca"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6f82ff8f-9779-4090-9ac1-f9b856aaff8b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7851fcd8-1e3a-41da-85a1-b92e8d967fe1"));

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
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7824), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.UretimPlanlama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitHazirlama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitDogrulama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.SetupVerification.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Ayarlar.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Credential.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Kalite.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Dashboard.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 3, 0, 0, 0)), "Role.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 3, 0, 0, 0)), "Role.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, 3, 0, 0, 0)), "Role.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9346), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Kaydet" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 16, true, new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı.Sil" },
                    { 17, true, new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.KullaniciGrup.All" },
                    { 18, true, new DateTimeOffset(new DateTime(2023, 5, 2, 11, 48, 15, 958, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Log.All" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18);

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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47fa324e-f581-4a24-9c33-0c49c953ba2a", "869b59e3-e0ce-4df5-b0cf-be8be264f6af", "sistemadmin", "SİSTEMADMİN" },
                    { "7e484085-f128-4101-8738-dca3cdabe669", "b0539700-cebe-4d50-a5f2-4ac1eae567bf", "depo", "DEPO" },
                    { "aab60108-6f8d-434c-a0a7-ba8bfcf28be7", "321673ef-81e9-4f0d-8c7d-6da9cbce3c13", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8485), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8523), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8524), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitHazirlama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KitDogrulama.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9244), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.SetupVerification.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9360), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Ayarlar.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9467), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Credential.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9582), new TimeSpan(0, 3, 0, 0, 0)), "Role.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9691), new TimeSpan(0, 3, 0, 0, 0)), "Role.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 3, 0, 0, 0)), "Role.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 198, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KullaniciGrup.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Log.All" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("21203893-18b8-46fc-9f6a-847d8bd58e4a"), 0, "Hakki", "b0f0b04a-4dee-4507-924f-9420db42adf0", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("6bfdb348-d187-4a08-a186-e09f7f3ce0ca"), 0, "Tolga", "be6e4c72-4e2e-48bf-82c5-cf88b9a4d8ec", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("6f82ff8f-9779-4090-9ac1-f9b856aaff8b"), 0, "Seref", "1bcd4760-b153-4f2e-9570-389d0512784f", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("7851fcd8-1e3a-41da-85a1-b92e8d967fe1"), 0, "Hakan", "31b24821-3402-4782-b33d-9da5b48526ba", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(518), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 3, 21, 20, 54, 57, 199, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
