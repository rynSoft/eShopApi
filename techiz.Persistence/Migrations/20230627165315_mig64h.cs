using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class mig64h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8b8bd730-c878-4953-9620-c3210d8df8a5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c65eceba-b161-4039-829d-c4228233fcb7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e3106b4e-bf95-49f6-940b-233028c625f8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3201f96d-a879-42ee-89cd-766b4d07b0dd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("558510fd-0f43-4d2b-954b-c917c9e777cf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8c28e7c6-49e9-45c6-8b9a-af0f665b4c80"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1228c82-054c-481c-b71b-c17d26ae244a"));

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "ShiftDefinitionProcess",
                type: "text",
                nullable: true);

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
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(3816), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(5949), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 27, 19, 53, 14, 464, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 3, 0, 0, 0)));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "ShiftDefinitionProcess");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b8bd730-c878-4953-9620-c3210d8df8a5", "1505e114-b993-406d-a2de-dd0729324338", "depo", "DEPO" },
                    { "c65eceba-b161-4039-829d-c4228233fcb7", "8a57fcdb-9434-4c43-af70-a814b709db20", "admin", "ADMİN" },
                    { "e3106b4e-bf95-49f6-940b-233028c625f8", "d44237c7-3fb4-4fda-a651-044ece28a578", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(5492), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(5968), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(6447), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(7390), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(8105), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(8341), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(8817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(9337), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 388, DateTimeKind.Unspecified).AddTicks(9811), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(282), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(988), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(1224), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3201f96d-a879-42ee-89cd-766b4d07b0dd"), 0, "Hakan", "4ece237f-92e9-4cfa-a30b-bd9c9e2cebf4", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("558510fd-0f43-4d2b-954b-c917c9e777cf"), 0, "Hakki", "099bd65c-d9dc-4fcb-aaf1-3dfcc2e19d40", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("8c28e7c6-49e9-45c6-8b9a-af0f665b4c80"), 0, "Tolga", "15fb1a6c-f899-4058-89ba-3efca03096b3", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("f1228c82-054c-481c-b71b-c17d26ae244a"), 0, "Seref", "ad0ca5df-f2ee-492a-b77e-b08923f5cb0d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" }
                });

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(2209), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "WorkCentre",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTimeOffset(new DateTime(2023, 6, 26, 8, 50, 48, 389, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
