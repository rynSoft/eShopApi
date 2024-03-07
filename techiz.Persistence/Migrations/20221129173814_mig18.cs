using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1a24aa86-db51-48cd-aef5-412ae6c185cc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "33d7f9f6-48c8-47e4-b605-436877b5be1c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "78f724df-47c1-46a7-8fe0-4397ea0e74fd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2372bdfb-529e-412f-8d71-87a4d0d2a091"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("37973a9c-5db6-4f74-9de0-6f94a8924f60"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("86e7e721-e0ab-4dfa-9192-7a7fd8fb1b7b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cda4b3e5-aa0a-4a5e-8a87-f012974912ed"));

            migrationBuilder.AlterColumn<double>(
                name: "Decrease",
                table: "SetupVerificationInfo",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Production",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UretimAdi",
                table: "Production",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1678b383-4d09-48f6-ab16-23b25b69adf0", "55ec48fb-6482-446a-971b-4a7739c48501", "depo", "DEPO" },
                    { "3fe034cc-c494-4560-90d1-112807565e48", "9b28cf7e-6024-4271-9a3e-37e3e4573606", "admin", "ADMİN" },
                    { "71651d97-1132-4c87-80de-a8c2288ed8a3", "403aaac3-23b7-45d9-993d-c9ea9a180413", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 3, 0, 0, 0)), "Role.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 3, 0, 0, 0)), "Role.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 3, 0, 0, 0)), "Role.Sil" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Goruntule" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Kaydet" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 3, 0, 0, 0)), "Kullanıcı.Sil" });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 14, true, new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.KullaniciGrup.All" },
                    { 15, true, new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Log.All" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("375cd6a2-eb13-467a-b957-7ca49d2823d3"), 0, "Seref", "d0194328-73f6-4322-8185-7f1764af7fb8", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("bc9fadfa-31b0-4aed-b48c-50105d5db19d"), 0, "Hakan", "afa42b76-b3c6-4faf-b860-bc30936d6bee", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("bcb33835-9859-423a-baac-9ad48daf14b0"), 0, "Hakki", "8b819009-372c-43fc-8ecc-5be5bf868674", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("d927c925-17c5-4034-b8d6-551e386fb8f9"), 0, "Tolga", "8a7d204e-2069-4ab8-bd87-9d0f90edf67b", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(6060), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 29, 20, 38, 13, 301, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1678b383-4d09-48f6-ab16-23b25b69adf0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3fe034cc-c494-4560-90d1-112807565e48");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "71651d97-1132-4c87-80de-a8c2288ed8a3");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("375cd6a2-eb13-467a-b957-7ca49d2823d3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bc9fadfa-31b0-4aed-b48c-50105d5db19d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bcb33835-9859-423a-baac-9ad48daf14b0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d927c925-17c5-4034-b8d6-551e386fb8f9"));

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "UretimAdi",
                table: "Production");

            migrationBuilder.AlterColumn<double>(
                name: "Decrease",
                table: "SetupVerificationInfo",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a24aa86-db51-48cd-aef5-412ae6c185cc", "12fd7fd5-82eb-46db-ad0f-4941a9eca087", "admin", "ADMİN" },
                    { "33d7f9f6-48c8-47e4-b605-436877b5be1c", "067d0c3b-686d-4aed-90fe-e3fcd0728d1d", "sistemadmin", "SİSTEMADMİN" },
                    { "78f724df-47c1-46a7-8fe0-4397ea0e74fd", "24ea7057-0639-4fd4-baff-09f9f34a69d0", "depo", "DEPO" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Grup.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Il.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Ilce.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Kullanici.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.KullaniciGrup.All" });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 803, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 3, 0, 0, 0)), "Permissions.Log.All" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2372bdfb-529e-412f-8d71-87a4d0d2a091"), 0, "Tolga", "67297079-94ea-4ae5-a3a4-05dbcc6bde90", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("37973a9c-5db6-4f74-9de0-6f94a8924f60"), 0, "Seref", "cc39c312-d8e5-4bdc-b925-8ce9a00465a0", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("86e7e721-e0ab-4dfa-9192-7a7fd8fb1b7b"), 0, "Hakan", "2ed7d1c4-988a-427f-8f7f-d6122fc1e4c4", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("cda4b3e5-aa0a-4a5e-8a87-f012974912ed"), 0, "Hakki", "af9cf908-f531-4cb2-b2c7-9c82319ad3a1", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2022, 11, 6, 19, 27, 24, 804, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
