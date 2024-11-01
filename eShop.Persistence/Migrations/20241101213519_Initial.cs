using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PartyNumber = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: true),
                    RemainQuantity = table.Column<double>(type: "double precision", nullable: true),
                    DecreaseQuantity = table.Column<double>(type: "double precision", nullable: true),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    IsDone = table.Column<bool>(type: "boolean", nullable: false),
                    NextWPRId = table.Column<int>(type: "integer", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    RouteLink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ParentMenuId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrjinalNr = table.Column<string>(type: "text", nullable: true),
                    NameTR = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameDe = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<string>(type: "text", nullable: true),
                    Length = table.Column<string>(type: "text", nullable: true),
                    Width = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<string>(type: "text", nullable: true),
                    Wieght = table.Column<string>(type: "text", nullable: true),
                    CustomsNr = table.Column<string>(type: "text", nullable: true),
                    BuyingPrice = table.Column<string>(type: "text", nullable: true),
                    InvoiceNr = table.Column<string>(type: "text", nullable: true),
                    Supplier = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Soyad = table.Column<string>(type: "text", nullable: true),
                    Eposta = table.Column<string>(type: "text", nullable: true),
                    TelefonGSM = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.UserId, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.Value });
                });

            migrationBuilder.CreateTable(
                name: "MenuPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    PermissionId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_MenuPermission",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(type: "text", nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedByIp = table.Column<string>(type: "text", nullable: true),
                    Revoked = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RevokedByIp = table.Column<string>(type: "text", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
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
                    { "02a199d9-be66-4988-8eb3-37b9fe96a95d", null, "depo", "DEPO" },
                    { "aea0cebf-e106-4de9-8b24-ff043e4b5b17", null, "admin", "ADMIN" },
                    { "ccd8dac9-1d84-4ba2-ad73-0621b8ddd4ab", null, "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "Icon", "IsDeleted", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-globe", false, "Panel", null, "/" },
                    { 2, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-gavel", false, "Kullanıcı", null, "/kullanıcı" },
                    { 3, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-balance-scale", false, "Kullanıcı Grup", null, "/kullanicigrup" },
                    { 5, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-id-card", false, "Tanımlar", null, "/tanimlar" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3479), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Genel.All" },
                    { 2, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Bandı" },
                    { 3, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Etiketleme" },
                    { 4, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Display Montajı" },
                    { 5, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4537), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Programlama" },
                    { 6, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Panelden Ayırma" },
                    { 7, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5091), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Test" },
                    { 8, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Süreçler" },
                    { 9, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5632), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Onaylar" },
                    { 10, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(5888), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Operasyonlar" },
                    { 11, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6185), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Depo Tanımları" },
                    { 12, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Hat Tanımları" },
                    { 13, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Makine Tanımları" },
                    { 14, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Vardiya Tanımları" },
                    { 15, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Oee Gösterim" },
                    { 16, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Vardiya - Hat Hedef Miktar Tanımları" },
                    { 17, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Mola Tanımları" },
                    { 18, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Tamamlanan Kalite Operasyonları" },
                    { 19, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama" },
                    { 20, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Görüntüle" },
                    { 21, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(8968), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Kaydet" },
                    { 22, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9228), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Sil" },
                    { 23, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kit Hazırlama" },
                    { 24, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 870, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kit Doğrulama" },
                    { 25, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Setup Verification" },
                    { 26, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Ayarlar" },
                    { 27, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Credential" },
                    { 28, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite" },
                    { 29, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(1766), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Dashboard" },
                    { 30, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Görüntüle" },
                    { 31, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Kaydet" },
                    { 32, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Sil" },
                    { 33, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Görüntüle" },
                    { 34, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Kaydet" },
                    { 35, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Sil" },
                    { 36, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KullaniciGrup All" },
                    { 37, true, new DateTimeOffset(new DateTime(2024, 11, 2, 0, 35, 18, 871, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("48af3a8e-cb3d-49a0-8bba-97580c8df050"), 0, "Tolga", "152ab07c-29b2-496f-b6ec-2300c35c725a", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("5a77d16f-7897-47c3-bf75-608b28649d2a"), 0, "eShop", "2f2ec740-5fdd-4fe8-981f-f1e3f84e8324", "eShop@sentytech.com", true, "eShop@sentytech.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "eShop", null, false, "eShop" },
                    { new Guid("65217fea-4a15-4154-928b-4cbfef53f80d"), 0, "Hakan", "f07e197a-c71f-4e42-a5a1-29ec44dec85f", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("8e2ed5bf-afc4-4b75-8116-b2419b373a5e"), 0, "Salih", "56695399-1ef2-4f0c-bc25-d80965f5f741", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" },
                    { new Guid("cfd11b99-dde3-474a-aad0-cd2015f9d747"), 0, "Cagan", "cf4981d2-2f0b-4189-b0bf-c8133155e012", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_MenuId",
                table: "MenuPermission",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_PermissionId",
                table: "MenuPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
