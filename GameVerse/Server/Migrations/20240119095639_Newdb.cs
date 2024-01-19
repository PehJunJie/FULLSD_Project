using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameVerse.Server.Migrations
{
    /// <inheritdoc />
    public partial class Newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberCount = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverallRating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    CommunityId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Games = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendations_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewRating = table.Column<double>(type: "float", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalPrice = table.Column<double>(type: "float", nullable: false),
                    DiscountedPrice = table.Column<double>(type: "float", nullable: false),
                    Subscription = table.Column<bool>(type: "bit", nullable: false),
                    AvailabilityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderedGames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPaid = table.Column<double>(type: "float", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52791369-72d2-4745-aafa-77a4128b3b61", null, "User", "USER" },
                    { "b2e72033-bcd7-4862-8f4b-e529252b0201", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8f4089e-a9a4-440c-bdec-9a615bd72cbd", 0, "a3d82623-348b-4577-a7b0-7316e93c4ed0", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMIdf3DgQz8Ro3kJhHzgKHWdC7QWoS0VXJsaYLI5DgpcMktUFFCU+2v+PIe0zWSrHg==", null, false, "6a4cd631-f765-4080-940a-b1220e6a6e20", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "MemberCount", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(355), "Join us for all things Star Rail!", 1530524, "Star Rail Official", "System" },
                    { 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(358), "Discuss all things Overwatch.", 127402, "Overwatch Community", "System" }
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "Age", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "Name", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, 25, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(664), "johnsmith@gmail.com", "John Smith", "System", "jsmithy" },
                    { 2, 22, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(668), "marryjones@gmail.com", "Marry Jones", "System", "joneygirl" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ContentRating", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Developer", "Genre", "OverallRating", "Platform", "Publisher", "ReleaseDate", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "E10+", "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(962), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(964), "A sequel to The Legend of Zelda: Breath of the Wild. The game lets you explore a large and diverse world of Hyrule and its mysterious islands. You can choose your own adventure and use Link’s new abilities to fight back against the malevolent forces.", "Nintendo", "Open-World Action", 8.4000000000000004, "Nintendo Switch", "Nintendo", new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Tears of the Kingdom", "System" },
                    { 2, "T", "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(969), "A space sci-fi role-playing game that combines myths and legends with exploration and combat. Players will board the Astral Express and visit different worlds, meet companions, and resolving [Stellaron]-related conflicts. The game has a simple and strategic combat system and large maps with puzzles and surprises.", "Cognosphere", "Role-Playing", 6.5, "PC, iOS, Android, PlayStation 5", "miHoYo", new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honkai: Star Rail", "System" },
                    { 3, "E", "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(972), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(973), "Out-build the competition in the all-new career. Race your friends in adjudicated multiplayer events. Compete in over 500 cars on world-famous tracks with cutting edge AI, advanced physics, and tire and fuel strategy.", "Turn 10", "Racing Sim", 7.5, "PC, Xbox Series X", "Xbox Game Studios", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forza Motorsport Standard Edition", "System" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Method", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1632), "DBS/POSB", "System" },
                    { 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1635), "OCBC", "System" },
                    { 3, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1637), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1637), "UOB", "System" },
                    { 4, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1639), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1640), "Citybank", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2e72033-bcd7-4862-8f4b-e529252b0201", "f8f4089e-a9a4-440c-bdec-9a615bd72cbd" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentDate", "CommunityId", "ConsumerId", "CreatedBy", "DateCreated", "DateUpdated", "Text", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 165, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 1, 19, 17, 56, 39, 165, DateTimeKind.Local).AddTicks(9711), "I love playing Honkai: Star Rail!", "System" },
                    { 2, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 165, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 1, 19, 17, 56, 39, 165, DateTimeKind.Local).AddTicks(9717), "LE SSERAFIM x Overwatch2 collab is sick!", "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AmountPaid", "ConsumerId", "CreatedBy", "DateCreated", "DateUpdated", "OrderDate", "OrderedGames", "PaymentId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 100.5, 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1317), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forza Horizon 5, NBA 2K24", 1, "System" },
                    { 2, 16.300000000000001, 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1323), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borderslands 3, BOKURA", 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "GameId", "Rank", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1921), 1, 1, "System" },
                    { 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1925), 2, 2, "System" },
                    { 3, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(1927), 3, 3, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ConsumerId", "CreatedBy", "DateCreated", "DateUpdated", "GameId", "ReviewDate", "ReviewRating", "Text", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2215), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2217), 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, "The game provides a lot of freebies, leveling up every quickly without spending money.", "System" },
                    { 2, 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2222), 2, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5, "I the game turns out to be pretty bad with frequent bugs.", "System" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AvailabilityStatus", "CreatedBy", "DateCreated", "DateUpdated", "DiscountedPrice", "GameId", "OriginalPrice", "Subscription", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Not Available", "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2590), 57.0, 1, 69.989999999999995, true, "System" },
                    { 2, "Available", "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2595), 85.900000000000006, 3, 99.900000000000006, false, "System" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "ConsumerId", "CreatedBy", "DateCreated", "DateUpdated", "Games", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2902), "Mario vs. Donkey Kong, Open Roads", "System" },
                    { 2, 2, "System", new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 1, 19, 17, 56, 39, 166, DateTimeKind.Local).AddTicks(2905), "Hyper Light Breaker", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommunityId",
                table: "Comments",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ConsumerId",
                table: "Comments",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_GameId",
                table: "Recommendations",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ConsumerId",
                table: "Reviews",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_GameId",
                table: "Stores",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ConsumerId",
                table: "Wishlists",
                column: "ConsumerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Consumers");
        }
    }
}
