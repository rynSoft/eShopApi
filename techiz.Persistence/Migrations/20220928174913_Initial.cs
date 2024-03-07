using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace techiz.Persistence.Migrations
{
    public partial class Initial : Migration
    {
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
                name: "Line",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_Line", x => x.Id);
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
                name: "Production",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderNo = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    EstimatedTime = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestCause",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_RestCause", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
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
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.Value });
                });

            migrationBuilder.CreateTable(
                name: "WareHouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkCentre",
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
                    table.PrimaryKey("PK_WorkCentre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LineId = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MachineType = table.Column<int>(type: "integer", nullable: false),
                    LedNumber = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machine_Line_LineId",
                        column: x => x.LineId,
                        principalTable: "Line",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ProductionLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionLog_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionLog_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionTimeProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    RestCauseId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductionTimeStatus = table.Column<int>(type: "integer", nullable: false),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ElapsedTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Definition = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionTimeProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionTimeProcess_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionTimeProcess_RestCause_RestCauseId",
                        column: x => x.RestCauseId,
                        principalTable: "RestCause",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionTimeProcess_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    OpenState = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionUser_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionUserRelation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUserRelation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionUserRelation_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionUserRelation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByIp = table.Column<string>(type: "text", nullable: true),
                    Revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "BomKitInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    WareHouseId = table.Column<int>(type: "integer", nullable: true),
                    Material = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PartyNumber = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    SoureProductPlace = table.Column<string>(type: "text", nullable: true),
                    IsKitProvided = table.Column<int>(type: "integer", nullable: false),
                    IsKitPreperated = table.Column<int>(type: "integer", nullable: false),
                    IsSetupVerification = table.Column<bool>(type: "boolean", nullable: false),
                    IsProductionProcess = table.Column<bool>(type: "boolean", nullable: false),
                    SetNo = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomKitInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BomKitInfo_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BomKitInfo_WareHouse_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "WareHouse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RouteInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Operation = table.Column<int>(type: "integer", nullable: true),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    WorkCentreId = table.Column<int>(type: "integer", nullable: false),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    RouteStatus = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteInfo_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteInfo_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RouteInfo_WorkCentre_WorkCentreId",
                        column: x => x.WorkCentreId,
                        principalTable: "WorkCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetupVerification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetupVerification_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerification_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetupVerificationInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    Decrease = table.Column<double>(type: "double precision", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    SetNo = table.Column<int>(type: "integer", nullable: false),
                    IsVerificated = table.Column<bool>(type: "boolean", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupVerificationInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetupVerificationInfo_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationInfo_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QrCode = table.Column<string>(type: "text", nullable: true),
                    GecenSure = table.Column<int>(type: "integer", nullable: false),
                    FeedlerData = table.Column<string>(type: "jsonb", nullable: true),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    OperationDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    OperationProcess = table.Column<int>(type: "integer", nullable: false),
                    SetupVerificationId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOperations_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOperations_SetupVerification_SetupVerificationId",
                        column: x => x.SetupVerificationId,
                        principalTable: "SetupVerification",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SetupVerificationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SetupVerificationId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FinishingQuantity = table.Column<double>(type: "double precision", nullable: true),
                    AddedQuantity = table.Column<double>(type: "double precision", nullable: true),
                    UsingQuantity = table.Column<double>(type: "double precision", nullable: true),
                    State = table.Column<bool>(type: "boolean", nullable: true),
                    BomKitInfoId = table.Column<int>(type: "integer", nullable: false),
                    SetNo = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupVerificationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDetails_BomKitInfo_BomKitInfoId",
                        column: x => x.BomKitInfoId,
                        principalTable: "BomKitInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDetails_SetupVerification_SetupVerificatio~",
                        column: x => x.SetupVerificationId,
                        principalTable: "SetupVerification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36edcbc6-c2c8-48ec-9509-2a9f42003904", "a45ded7e-fc58-4143-9450-23599460a3b2", "admin", "ADMİN" },
                    { "48440ee0-3fab-456b-9810-efdae2edddff", "8c976eb4-db2a-4478-9625-c9d3ba3a1ebf", "sistemadmin", "SİSTEMADMİN" },
                    { "d85fd170-e20d-4fa2-b84d-c3887f79a6f6", "53751a5a-9366-4b24-b76c-867b89a6da56", "depo", "DEPO" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "Icon", "IsDeleted", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-globe", false, "Panel", null, "/" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-gavel", false, "Kullanıcı", null, "/kullanıcı" },
                    { 3, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-balance-scale", false, "Kullanıcı Grup", null, "/kullanicigrup" },
                    { 5, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-id-card", false, "Tanımlar", null, "/tanimlar" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Genel.All" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Uretim.All" },
                    { 3, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.KitHazirlama.All" },
                    { 4, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.KitDogrulama.All" },
                    { 5, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.SetupVerification.All" },
                    { 6, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Ayarlar.All" },
                    { 7, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7470), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Credential.All" },
                    { 8, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Grup.All" },
                    { 9, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Il.All" },
                    { 10, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Ilce.All" },
                    { 11, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Kullanici.All" },
                    { 12, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.KullaniciGrup.All" },
                    { 13, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Log.All" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c99e30e1-8cdf-469f-b809-113865d7addb"), 0, "Seref", "63e307a4-bcad-4974-99e1-a2437f364b3d", "seref@oxit.com", false, "seref@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Seref" },
                    { new Guid("e26ab6f1-c440-4505-9297-a33502511ebc"), 0, "Tolga", "4965651a-0a9e-4200-8c67-16bbd6aa66a0", "tolga@oxit.com", true, "tolga@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("f989ca2a-d106-48c3-8455-254d0a5103a6"), 0, "Hakki", "d4aa9245-18ad-4134-830d-6d7fcb47011f", "hakki@oxit.com", false, "hakki@oxit.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Şimşek", null, false, "Hakki" },
                    { new Guid("fa8b3e89-1e5a-4693-b989-a9b662f6ee76"), 0, "Hakan", "3b1e24e1-e685-4111-a017-ac49fffa1e30", "hakan@oxit.com", false, "hakan@oxit.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" }
                });

            migrationBuilder.InsertData(
                table: "WorkCentre",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8290), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "DEPO" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "SMT DZG" },
                    { 3, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "THT DZG" },
                    { 4, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KLT" },
                    { 5, true, new DateTimeOffset(new DateTime(2022, 9, 28, 20, 49, 12, 700, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KMYSL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BomKitInfo_ProductionId",
                table: "BomKitInfo",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_BomKitInfo_WareHouseId",
                table: "BomKitInfo",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_LineId",
                table: "Machine",
                column: "LineId");

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
                name: "IX_ProductionLog_ProductionId",
                table: "ProductionLog",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLog_UserId",
                table: "ProductionLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_ProductionId",
                table: "ProductionOperations",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_SetupVerificationId",
                table: "ProductionOperations",
                column: "SetupVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_ProductionId",
                table: "ProductionTimeProcess",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_RestCauseId",
                table: "ProductionTimeProcess",
                column: "RestCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_UserId",
                table: "ProductionTimeProcess",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUser_ProductionId",
                table: "ProductionUser",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUser_UserId",
                table: "ProductionUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUserRelation_ProductionId",
                table: "ProductionUserRelation",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUserRelation_UserId",
                table: "ProductionUserRelation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteInfo_ProductionId",
                table: "RouteInfo",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteInfo_UserId",
                table: "RouteInfo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteInfo_WorkCentreId",
                table: "RouteInfo",
                column: "WorkCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerification_MachineId",
                table: "SetupVerification",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerification_ProductionId",
                table: "SetupVerification",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDetails_BomKitInfoId",
                table: "SetupVerificationDetails",
                column: "BomKitInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDetails_SetupVerificationId",
                table: "SetupVerificationDetails",
                column: "SetupVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationInfo_MachineId",
                table: "SetupVerificationInfo",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationInfo_ProductionId",
                table: "SetupVerificationInfo",
                column: "ProductionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "ProductionLog");

            migrationBuilder.DropTable(
                name: "ProductionOperations");

            migrationBuilder.DropTable(
                name: "ProductionTimeProcess");

            migrationBuilder.DropTable(
                name: "ProductionUser");

            migrationBuilder.DropTable(
                name: "ProductionUserRelation");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "RouteInfo");

            migrationBuilder.DropTable(
                name: "SetupVerificationDetails");

            migrationBuilder.DropTable(
                name: "SetupVerificationInfo");

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
                name: "RestCause");

            migrationBuilder.DropTable(
                name: "WorkCentre");

            migrationBuilder.DropTable(
                name: "BomKitInfo");

            migrationBuilder.DropTable(
                name: "SetupVerification");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WareHouse");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Production");

            migrationBuilder.DropTable(
                name: "Line");
        }
    }
}
