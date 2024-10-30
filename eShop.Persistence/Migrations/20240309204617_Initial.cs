using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace eShop.Persistence.Migrations
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
                name: "MY_Viewsa",
                columns: table => new
                {
                    Dates = table.Column<string>(type: "text", nullable: true),
                    OrderNo = table.Column<string>(type: "text", nullable: true),
                    Ids = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EndDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Break = table.Column<string>(type: "text", nullable: true),
                    SumStartWorkNoCountable = table.Column<string>(type: "text", nullable: true),
                    SumStartWork = table.Column<string>(type: "text", nullable: true),
                    SumStopWork = table.Column<string>(type: "text", nullable: true),
                    UseAbleTime = table.Column<string>(type: "text", nullable: true),
                    UseAbleMinute = table.Column<double>(type: "double precision", nullable: true),
                    LoadingLevel = table.Column<double>(type: "double precision", nullable: true),
                    TheoricSpeed = table.Column<double>(type: "double precision", nullable: true),
                    ShiftTarget = table.Column<int>(type: "integer", nullable: true),
                    ProductionTarget = table.Column<int>(type: "integer", nullable: true),
                    PerformanceLevel = table.Column<double>(type: "double precision", nullable: true),
                    SolidCardCount = table.Column<int>(type: "integer", nullable: true),
                    QualityLevel = table.Column<int>(type: "integer", nullable: true),
                    Oee = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NonComplianceCode",
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
                    table.PrimaryKey("PK_NonComplianceCode", x => x.Id);
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
                    PanelCardCount = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UretimAdi = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
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
                name: "Quality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkOrderNumber = table.Column<string>(type: "text", nullable: true),
                    ProductionCode = table.Column<string>(type: "text", nullable: true),
                    SerialCode = table.Column<string>(type: "text", nullable: true),
                    Piece = table.Column<double>(type: "double precision", nullable: false),
                    State = table.Column<bool>(type: "boolean", nullable: false),
                    NonComplianceCode = table.Column<string>(type: "text", nullable: true),
                    QualityType = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestCause",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Hanging = table.Column<bool>(type: "boolean", nullable: false),
                    UseOee = table.Column<bool>(type: "boolean", nullable: false),
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
                name: "ShiftDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EndDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftDefinition", x => x.Id);
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
                    BarcodeReaderId = table.Column<string>(type: "text", nullable: true),
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
                name: "ProductionProcessManual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: true),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    LabelingBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LabelingEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LabelingElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    LabelingUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DisplayAssemblyBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DisplayAssemblyEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DisplayAssemblyElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    DisplayAssemblyLotNo = table.Column<string>(type: "text", nullable: true),
                    DisplayUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProgrammingBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ProgrammingEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ProgrammingElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    ProgrammingUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DetachFromPanelBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DetachFromPanelEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DetachFromPanelElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    DetachFromPanelUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionProcessManual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_DetachFromPanelUserId",
                        column: x => x.DetachFromPanelUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_DisplayUserId",
                        column: x => x.DisplayUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_LabelingUserId",
                        column: x => x.LabelingUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionProcessManual_User_ProgrammingUserId",
                        column: x => x.ProgrammingUserId,
                        principalTable: "User",
                        principalColumn: "Id");
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
                name: "QualityOperation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserLiableId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserApprovingId = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorizedPersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartOperationDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    StartOperation = table.Column<bool>(type: "boolean", nullable: false),
                    EndOperationDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EndOperation = table.Column<bool>(type: "boolean", nullable: true),
                    Operation = table.Column<string>(type: "text", nullable: true),
                    Confirmation = table.Column<bool>(type: "boolean", nullable: false),
                    QualityId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityOperation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityOperation_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QualityOperation_User_AuthorizedPersonId",
                        column: x => x.AuthorizedPersonId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QualityUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QualityId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    QualityProcess = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_QualityUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityUser_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QualityUser_User_UserId",
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
                name: "ShiftDefinitionProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftDefinitionId = table.Column<int>(type: "integer", nullable: false),
                    LineId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    TargetQuantity = table.Column<int>(type: "integer", nullable: true),
                    TeoricSpeed = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftDefinitionProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_Line_LineId",
                        column: x => x.LineId,
                        principalTable: "Line",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_ShiftDefinition_ShiftDefinitionId",
                        column: x => x.ShiftDefinitionId,
                        principalTable: "ShiftDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftDefinitionProcess_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShiftTargetParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftDefinitionId = table.Column<int>(type: "integer", nullable: false),
                    TheoreticalSpeed = table.Column<double>(type: "double precision", nullable: false),
                    NumberOfCard = table.Column<int>(type: "integer", nullable: false),
                    IsFinished = table.Column<bool>(type: "boolean", nullable: false),
                    DelayTime = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DifferanceDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    RestCauseId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LineId = table.Column<int>(type: "integer", nullable: false),
                    TargetCardCount = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTargetParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftTargetParameters_Line_LineId",
                        column: x => x.LineId,
                        principalTable: "Line",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftTargetParameters_RestCause_RestCauseId",
                        column: x => x.RestCauseId,
                        principalTable: "RestCause",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShiftTargetParameters_ShiftDefinition_ShiftDefinitionId",
                        column: x => x.ShiftDefinitionId,
                        principalTable: "ShiftDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftTargetParameters_User_UserId",
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
                    WareHouseName = table.Column<string>(type: "text", nullable: true),
                    Material = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PartyNumber = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    RollerQuantity = table.Column<double>(type: "double precision", nullable: true),
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
                    State = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    WorkCentreId = table.Column<int>(type: "integer", nullable: false),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    RouteStatus = table.Column<string>(type: "text", nullable: false),
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
                name: "ProductionLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_ProductionLog_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id");
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
                name: "ProductionMachineMatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    ElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    State = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionMachineMatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionMachineMatch_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionMachineMatch_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
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
                name: "QualityInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QualityProcessType = table.Column<int>(type: "integer", nullable: false),
                    ProductionCode = table.Column<string>(type: "text", nullable: true),
                    LotInformation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Piece = table.Column<double>(type: "double precision", nullable: false),
                    QualityId = table.Column<int>(type: "integer", nullable: false),
                    QualityOperationId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityInfo_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QualityInfo_QualityOperation_QualityOperationId",
                        column: x => x.QualityOperationId,
                        principalTable: "QualityOperation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QualityOperationDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QualityOperationId = table.Column<int>(type: "integer", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: true),
                    DataType = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_QualityOperationDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityOperationDocument_QualityOperation_QualityOperationId",
                        column: x => x.QualityOperationId,
                        principalTable: "QualityOperation",
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
                    ShiftTargetParametersId = table.Column<int>(type: "integer", nullable: true),
                    MachineId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_ProductionTimeProcess_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id");
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
                        name: "FK_ProductionTimeProcess_ShiftTargetParameters_ShiftTargetPara~",
                        column: x => x.ShiftTargetParametersId,
                        principalTable: "ShiftTargetParameters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionTimeProcess_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                    BomKitInfoId = table.Column<int>(type: "integer", nullable: true),
                    Decrease = table.Column<double>(type: "double precision", nullable: true),
                    RollerQuantity = table.Column<double>(type: "double precision", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    JobName = table.Column<string>(type: "text", nullable: true),
                    SetNo = table.Column<int>(type: "integer", nullable: false),
                    IsVerificated = table.Column<bool>(type: "boolean", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: true),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: true),
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
                        name: "FK_SetupVerificationInfo_BomKitInfo_BomKitInfoId",
                        column: x => x.BomKitInfoId,
                        principalTable: "BomKitInfo",
                        principalColumn: "Id");
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
                name: "RouteInfoUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteInfoId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteInfoUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteInfoUser_RouteInfo_RouteInfoId",
                        column: x => x.RouteInfoId,
                        principalTable: "RouteInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteInfoUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
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
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    ShiftTargetParametersId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_ProductionOperations_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_ProductionOperations_ShiftTargetParameters_ShiftTargetParam~",
                        column: x => x.ShiftTargetParametersId,
                        principalTable: "ShiftTargetParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SetupVerificationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Material = table.Column<string>(type: "text", nullable: true),
                    PartyNumber = table.Column<string>(type: "text", nullable: true),
                    SetupVerificationId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    FinishingQuantity = table.Column<double>(type: "double precision", nullable: true),
                    RollerQuantity = table.Column<double>(type: "double precision", nullable: true),
                    UsingQuantity = table.Column<double>(type: "double precision", nullable: true),
                    State = table.Column<bool>(type: "boolean", nullable: true),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: true),
                    ChangingBomKitInfoId = table.Column<int>(type: "integer", nullable: false),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_SetupVerificationDetails_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SetupVerificationDetails_SetupVerification_SetupVerificatio~",
                        column: x => x.SetupVerificationId,
                        principalTable: "SetupVerification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOperationsTimeLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    ProductionOperationsId = table.Column<int>(type: "integer", nullable: false),
                    LastTime = table.Column<int>(type: "integer", nullable: false),
                    CurrentTime = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_ProductionOperationsTimeLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOperationsTimeLog_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOperationsTimeLog_ProductionOperations_Production~",
                        column: x => x.ProductionOperationsId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionProcessManualTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: true),
                    ProductionProcess = table.Column<int>(type: "integer", nullable: false),
                    TestBeginDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TestEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    TestElapsedTime = table.Column<int>(type: "integer", nullable: true),
                    TestUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductionOperationsId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionProcessManualTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_ProductionOperations_Production~",
                        column: x => x.ProductionOperationsId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductionProcessManualTest_User_TestUserId",
                        column: x => x.TestUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SetupVerificationDChange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductionId = table.Column<int>(type: "integer", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    SetupVerificationDetailsOldId = table.Column<int>(type: "integer", nullable: false),
                    SetupVerificationDetailsNewId = table.Column<int>(type: "integer", nullable: false),
                    OldPanelId = table.Column<int>(type: "integer", nullable: false),
                    NewPanelId = table.Column<int>(type: "integer", nullable: false),
                    OldPanelQty = table.Column<double>(type: "double precision", nullable: true),
                    NewPanelQty = table.Column<double>(type: "double precision", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EditorId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupVerificationDChange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_ProductionOperations_NewPanelId",
                        column: x => x.NewPanelId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_ProductionOperations_OldPanelId",
                        column: x => x.OldPanelId,
                        principalTable: "ProductionOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVer~1",
                        column: x => x.SetupVerificationDetailsOldId,
                        principalTable: "SetupVerificationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetupVerificationDChange_SetupVerificationDetails_SetupVeri~",
                        column: x => x.SetupVerificationDetailsNewId,
                        principalTable: "SetupVerificationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87ef6e85-2cd7-49b8-bb2d-9a8bff1b0d2c", "b07246b4-3ae2-4be0-98e5-136083d27f9b", "depo", "DEPO" },
                    { "8f20c2c9-467c-44ce-8874-9e7bcab397a7", "804d9017-e979-428f-ab58-5b3f38704d72", "sistemadmin", "SİSTEMADMİN" },
                    { "f820446d-b1bc-4e7a-a405-b3f3ab8e667a", "2c391d86-eee3-497e-96de-0ae1550d52f5", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "Icon", "IsDeleted", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3042), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-globe", false, "Panel", null, "/" },
                    { 2, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-gavel", false, "Kullanıcı", null, "/kullanıcı" },
                    { 3, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3090), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "fa fa-balance-scale", false, "Kullanıcı Grup", null, "/kullanicigrup" },
                    { 5, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3092), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, "pi pi-fw pi-id-card", false, "Tanımlar", null, "/tanimlar" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Permissions.Genel.All" },
                    { 2, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(3943), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Bandı" },
                    { 3, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Etiketleme" },
                    { 4, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Display Montajı" },
                    { 5, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Programlama" },
                    { 6, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Panelden Ayırma" },
                    { 7, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Test" },
                    { 8, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Süreçler" },
                    { 9, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Onaylar" },
                    { 10, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite Operasyonlar" },
                    { 11, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Depo Tanımları" },
                    { 12, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Hat Tanımları" },
                    { 13, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(8184), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Makine Tanımları" },
                    { 14, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(8555), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Vardiya Tanımları" },
                    { 15, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Oee Gösterim" },
                    { 16, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(9314), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Vardiya - Hat Hedef Miktar Tanımları" },
                    { 17, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 313, DateTimeKind.Unspecified).AddTicks(9725), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Mola Tanımları" },
                    { 18, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Tamamlanan Kalite Operasyonları" },
                    { 19, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama" },
                    { 20, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(897), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Görüntüle" },
                    { 21, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Kaydet" },
                    { 22, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(1639), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Üretim Planlama Sil" },
                    { 23, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kit Hazırlama" },
                    { 24, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kit Doğrulama" },
                    { 25, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(2742), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Setup Verification" },
                    { 26, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Ayarlar" },
                    { 27, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Credential" },
                    { 28, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kalite" },
                    { 29, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Dashboard" },
                    { 30, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Görüntüle" },
                    { 31, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(5145), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Kaydet" },
                    { 32, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Rol Sil" },
                    { 33, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Görüntüle" },
                    { 34, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Kaydet" },
                    { 35, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "Kullanıcı Sil" },
                    { 36, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7053), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KullaniciGrup All" },
                    { 37, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7421), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "LogAll" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("ae220a72-93e5-485f-a86e-857a57a87b68"), 0, "Hakan", "c33b4d66-6886-40ff-a6df-2a706915ecc4", "hakan@.com", false, "hakan@.com", null, true, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "YILDIRIM", null, false, "hakanyildirim" },
                    { new Guid("c5098408-08bd-4611-ad72-a8e8f5eb6f63"), 0, "Tolga", "cc05b850-bf95-4236-9e57-31f2f9acba90", "tolga@.com", true, "tolga@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Bagin", null, false, "Tolga" },
                    { new Guid("f7e26b5d-f761-4e0e-b470-c29f530aae90"), 0, "Cagan", "e857c007-024c-4adf-a45a-205b89e7bed4", "cagan@.com", true, "cagan@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Turhan", null, false, "cagan" },
                    { new Guid("fd55c758-e295-47e2-aba5-1525385fc9ca"), 0, "Salih", "e4fd3d61-6e9a-4ac7-b069-620ca4d6479d", "salih@.com", true, "salih@.com", null, true, false, null, "BASICUSER@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, null, "Dürüs", null, false, "Salih" }
                });

            migrationBuilder.InsertData(
                table: "WorkCentre",
                columns: new[] { "Id", "Active", "CreateDate", "CreatorId", "EditDate", "EditorId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7886), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "DEPO" },
                    { 2, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "SMT DZG" },
                    { 3, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "THT DZG" },
                    { 4, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KLT" },
                    { 5, true, new DateTimeOffset(new DateTime(2024, 3, 9, 23, 46, 17, 314, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 3, 0, 0, 0)), null, null, null, false, "KMYSL" }
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
                name: "IX_ProductionLog_MachineId",
                table: "ProductionLog",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLog_ProductionId",
                table: "ProductionLog",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLog_UserId",
                table: "ProductionLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionMachineMatch_MachineId",
                table: "ProductionMachineMatch",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionMachineMatch_ProductionId",
                table: "ProductionMachineMatch",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_MachineId",
                table: "ProductionOperations",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_ProductionId",
                table: "ProductionOperations",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_SetupVerificationId",
                table: "ProductionOperations",
                column: "SetupVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperations_ShiftTargetParametersId",
                table: "ProductionOperations",
                column: "ShiftTargetParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperationsTimeLog_ProductionId",
                table: "ProductionOperationsTimeLog",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOperationsTimeLog_ProductionOperationsId",
                table: "ProductionOperationsTimeLog",
                column: "ProductionOperationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_DetachFromPanelUserId",
                table: "ProductionProcessManual",
                column: "DetachFromPanelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_DisplayUserId",
                table: "ProductionProcessManual",
                column: "DisplayUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_LabelingUserId",
                table: "ProductionProcessManual",
                column: "LabelingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_ProductionId",
                table: "ProductionProcessManual",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManual_ProgrammingUserId",
                table: "ProductionProcessManual",
                column: "ProgrammingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_ProductionId",
                table: "ProductionProcessManualTest",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_ProductionOperationsId",
                table: "ProductionProcessManualTest",
                column: "ProductionOperationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionProcessManualTest_TestUserId",
                table: "ProductionProcessManualTest",
                column: "TestUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_MachineId",
                table: "ProductionTimeProcess",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_ProductionId",
                table: "ProductionTimeProcess",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_RestCauseId",
                table: "ProductionTimeProcess",
                column: "RestCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTimeProcess_ShiftTargetParametersId",
                table: "ProductionTimeProcess",
                column: "ShiftTargetParametersId");

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
                name: "IX_QualityInfo_QualityId",
                table: "QualityInfo",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityInfo_QualityOperationId",
                table: "QualityInfo",
                column: "QualityOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperation_AuthorizedPersonId",
                table: "QualityOperation",
                column: "AuthorizedPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperation_QualityId",
                table: "QualityOperation",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityOperationDocument_QualityOperationId",
                table: "QualityOperationDocument",
                column: "QualityOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityUser_QualityId",
                table: "QualityUser",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_QualityUser_UserId",
                table: "QualityUser",
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
                name: "IX_RouteInfoUser_RouteInfoId",
                table: "RouteInfoUser",
                column: "RouteInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteInfoUser_UserId",
                table: "RouteInfoUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerification_MachineId",
                table: "SetupVerification",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerification_ProductionId",
                table: "SetupVerification",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_MachineId",
                table: "SetupVerificationDChange",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_NewPanelId",
                table: "SetupVerificationDChange",
                column: "NewPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_OldPanelId",
                table: "SetupVerificationDChange",
                column: "OldPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_ProductionId",
                table: "SetupVerificationDChange",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_SetupVerificationDetailsNewId",
                table: "SetupVerificationDChange",
                column: "SetupVerificationDetailsNewId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDChange_SetupVerificationDetailsOldId",
                table: "SetupVerificationDChange",
                column: "SetupVerificationDetailsOldId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDetails_BomKitInfoId",
                table: "SetupVerificationDetails",
                column: "BomKitInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDetails_MachineId",
                table: "SetupVerificationDetails",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationDetails_SetupVerificationId",
                table: "SetupVerificationDetails",
                column: "SetupVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationInfo_BomKitInfoId",
                table: "SetupVerificationInfo",
                column: "BomKitInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationInfo_MachineId",
                table: "SetupVerificationInfo",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SetupVerificationInfo_ProductionId",
                table: "SetupVerificationInfo",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_LineId",
                table: "ShiftDefinitionProcess",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_ShiftDefinitionId",
                table: "ShiftDefinitionProcess",
                column: "ShiftDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftDefinitionProcess_UserId",
                table: "ShiftDefinitionProcess",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTargetParameters_LineId",
                table: "ShiftTargetParameters",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTargetParameters_RestCauseId",
                table: "ShiftTargetParameters",
                column: "RestCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTargetParameters_ShiftDefinitionId",
                table: "ShiftTargetParameters",
                column: "ShiftDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTargetParameters_UserId",
                table: "ShiftTargetParameters",
                column: "UserId");

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "MY_Viewsa");

            migrationBuilder.DropTable(
                name: "NonComplianceCode");

            migrationBuilder.DropTable(
                name: "ProductionLog");

            migrationBuilder.DropTable(
                name: "ProductionMachineMatch");

            migrationBuilder.DropTable(
                name: "ProductionOperationsTimeLog");

            migrationBuilder.DropTable(
                name: "ProductionProcessManual");

            migrationBuilder.DropTable(
                name: "ProductionProcessManualTest");

            migrationBuilder.DropTable(
                name: "ProductionTimeProcess");

            migrationBuilder.DropTable(
                name: "ProductionUser");

            migrationBuilder.DropTable(
                name: "ProductionUserRelation");

            migrationBuilder.DropTable(
                name: "QualityInfo");

            migrationBuilder.DropTable(
                name: "QualityOperationDocument");

            migrationBuilder.DropTable(
                name: "QualityUser");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "RouteInfoUser");

            migrationBuilder.DropTable(
                name: "SetupVerificationDChange");

            migrationBuilder.DropTable(
                name: "SetupVerificationInfo");

            migrationBuilder.DropTable(
                name: "ShiftDefinitionProcess");

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
                name: "QualityOperation");

            migrationBuilder.DropTable(
                name: "RouteInfo");

            migrationBuilder.DropTable(
                name: "ProductionOperations");

            migrationBuilder.DropTable(
                name: "SetupVerificationDetails");



            migrationBuilder.DropTable(
                name: "Quality");

            migrationBuilder.DropTable(
                name: "WorkCentre");

            migrationBuilder.DropTable(
                name: "ShiftTargetParameters");

            migrationBuilder.DropTable(
                name: "BomKitInfo");

            migrationBuilder.DropTable(
                name: "SetupVerification");

            migrationBuilder.DropTable(
                name: "RestCause");

            migrationBuilder.DropTable(
                name: "ShiftDefinition");

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
