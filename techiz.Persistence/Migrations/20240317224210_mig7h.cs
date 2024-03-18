using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig7h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6f7fd7f7-c48d-4f4b-babc-f238d61e846f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b8d5351e-825f-4105-b993-c769008687a7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0db8edb-fd43-4172-922e-51efa5dc6ce3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("17365ce5-3c4b-44b8-9345-104a3060de7a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6f92b113-a542-4116-ae24-5934efe5bcbc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("99163da1-4f1e-466b-89a9-174c0a973e83"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3b3f9ec-b8af-46f5-aafb-d4cf2bbf4e9b"));

            migrationBuilder.RenameColumn(
                name: "EndWorkProcessRouteId",
                table: "Product",
                newName: "CurrentWorkProcessRouteId");

            migrationBuilder.AddColumn<Guid>(
                name: "OperatorId",
                table: "Product",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Product",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ecd3795-dc0d-48d6-a8ea-dbd548abda82", "9dfca94b-460a-4a6c-9358-ec56d8d64db1", "sistemadmin", "SİSTEMADMİN" },
                    { "6ccea2d2-bc93-40ff-b820-60c0452e8956", "44a4f469-ffbb-4e9e-81d4-6be49b3df42c", "depo", "DEPO" },
                    { "c3f3d14d-fd9b-40fe-8f7f-d1119f6cc4d9", "8d0dcdf6-70b8-420a-a7ac-488caf70cd50", "admin", "ADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(2542), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(3049), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(3459), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(5047), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(6185), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(8199), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(8620), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(9441), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 655, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(593), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(1889), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(6016), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(7709), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 656, DateTimeKind.Unspecified).AddTicks(9513), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("432b370a-04d9-42ed-bdca-a3c3417679cd"), 0, "Hakan", "d58c583c-7691-4f8b-8ba4-e3a199739bd8", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("558fa09a-60c2-4763-9ab6-cb7c462ba99c"), 0, "Tolga", "c110b354-53fd-4ba0-ac23-2dc905ff177a", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("90bd7bb2-1aaa-4fe4-b602-6b3fbecbb37e"), 0, "Cagan", "8d37568c-00ae-449d-af3a-8f0494490545", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("96941ba9-d803-4d35-9ab4-456ec061fe7a"), 0, "Salih", "b19a3807-dc92-4730-846a-1db36a520212", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1569), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1588), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 18, 1, 42, 9, 657, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5ecd3795-dc0d-48d6-a8ea-dbd548abda82");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ccea2d2-bc93-40ff-b820-60c0452e8956");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c3f3d14d-fd9b-40fe-8f7f-d1119f6cc4d9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("432b370a-04d9-42ed-bdca-a3c3417679cd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("558fa09a-60c2-4763-9ab6-cb7c462ba99c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("90bd7bb2-1aaa-4fe4-b602-6b3fbecbb37e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96941ba9-d803-4d35-9ab4-456ec061fe7a"));

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CurrentWorkProcessRouteId",
                table: "Product",
                newName: "EndWorkProcessRouteId");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f7fd7f7-c48d-4f4b-babc-f238d61e846f", "18c50f10-8805-4bf1-b0d0-18cac919bfc0", "admin", "ADMİN" },
                    { "b8d5351e-825f-4105-b993-c769008687a7", "7ed210fd-a97f-4b4b-88b5-9ca181f3f779", "depo", "DEPO" },
                    { "f0db8edb-fd43-4172-922e-51efa5dc6ce3", "ba26bb02-8eaa-49d3-b415-fca689d8d9c4", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(9156), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(9477), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 307, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(844), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(5616), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(6647), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("17365ce5-3c4b-44b8-9345-104a3060de7a"), 0, "Tolga", "b7ed05b1-1d56-45a0-a2bd-e604c97cd32f", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("6f92b113-a542-4116-ae24-5934efe5bcbc"), 0, "Hakan", "255601ea-f11c-4148-9bec-8e1e2d317d7d", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("99163da1-4f1e-466b-89a9-174c0a973e83"), 0, "Salih", "f020a0ff-2d71-4240-b5da-e964ea53bcc6", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("e3b3f9ec-b8af-46f5-aafb-d4cf2bbf4e9b"), 0, "Cagan", "6b580350-502d-46b6-978f-a80b1af38d41", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(7382), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 17, 13, 57, 54, 308, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
