using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitDB : Migration
    {
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
                    HasApprovedTerms = table.Column<bool>(type: "bit", nullable: true),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PrepTime = table.Column<int>(type: "int", nullable: false),
                    CookTime = table.Column<int>(type: "int", nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DietId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recipes_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteRecipes",
                columns: table => new
                {
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRecipes", x => new { x.RecipeId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "e8e1ee71-51f2-4c60-8066-aa33b5e73658", "Admin", "ADMIN" },
                    { "00000000-0000-0000-0000-000000000002", "ab9f6225-9217-42f8-a57c-2d474567f67a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTerms", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "c8554266-b401-4519-9aeb-a9283053fc58", "admin@imi.be", true, null, false, null, "ADMIN@IMI.BE", "IMIADMIN", "AQAAAAEAACcQAAAAENW++m6CMCfkpe3JWsyyd3wY9jXvr5XqxHBQEg3sFnR1EcjFMigduG9nM23ttJrIdg==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "ImiAdmin" },
                    { "00000000-0000-0000-0000-000000000002", 0, "2b3ba136-4654-49c1-8329-1e266a1f7453", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", "AQAAAAEAACcQAAAAEAggOQ7iRthJ2s8zJqV+1hKVPQEEdozZ5A71WCjnYBzMTkhIY0x46W/1lgqJBUcEOQ==", null, false, "WWPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "ImiUser" },
                    { "00000000-0000-0000-0000-000000000003", 0, "fad66526-654c-4000-b7b3-30349c41f171", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", "AQAAAAEAACcQAAAAECawuqMxRyjEndnJ2l3ocNmmzUYQDGvk+LCqhKgsLL2PDRlajqswC3MmEZY3EuJkmw==", null, false, "YYPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "ImiRefuser" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08819291-50e2-4c2b-b0a1-3a85ffe13ea8"), "snack" },
                    { new Guid("27fa19ac-73ef-453d-a5d7-d7f2f90a5a54"), "beverage" },
                    { new Guid("4168b4e7-b6b8-44de-a64b-7b6bccb1c1aa"), "dinner" },
                    { new Guid("5a42a6dc-79d0-4c3e-99ec-06def96cc5c6"), "dessert" },
                    { new Guid("8f1023cd-0a5a-4e53-b024-76d2c111e4c5"), "breakfast" },
                    { new Guid("da4c0975-41c5-4651-9235-0ff05fcc9e68"), "lunch" },
                    { new Guid("fdfa7823-b3cb-4354-98cd-ae768eb7af0f"), "side dish" }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("705f40d3-fc00-4781-a7b9-8c38dbfd6987"), "keto" },
                    { new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "anything" },
                    { new Guid("7b5b75ce-ea6e-46f5-9ca9-bd6ba7f6d682"), "vegan" },
                    { new Guid("a1b84c43-91db-4295-8d92-3383219599ed"), "paleo" },
                    { new Guid("fbaa5c0a-b224-4ba8-ac7b-1f3b5a4cacd3"), "vegetarian" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("002ddabe-b201-4679-9bfe-f6dca4cc7b53"), "oat milk" },
                    { new Guid("046dce63-063c-4b9e-887e-373efa9d2523"), "lemon" },
                    { new Guid("16caadcd-699e-4a5d-9dc5-f54e41692784"), "heavy cream" },
                    { new Guid("16ecdb26-24ec-48b6-8ffd-45bc188ad234"), "kosher salt" },
                    { new Guid("1c41dcde-22c9-4ae8-a1f5-718aea034da0"), "red onion" },
                    { new Guid("1c5e3925-8ae4-4926-9eac-3628e7920984"), "blackberries" },
                    { new Guid("1cddb371-eaa0-4345-88ea-3a76b8cad449"), "brown rice" },
                    { new Guid("24e47ca1-08cc-4c98-a84e-fb9876d2c39a"), "lean ground beef" },
                    { new Guid("299140ef-1ffe-4c3b-84c9-11b2c3022f62"), "lime" },
                    { new Guid("35ba74dd-b3ad-44e2-9d80-6abb956a0bbd"), "protein powder" },
                    { new Guid("372c5ae2-7acc-48a6-b65f-9de13846c9d3"), "strawberries" },
                    { new Guid("3a1ec623-e070-4912-9fce-4e48bb9aa5e9"), "keto chocolate chips" },
                    { new Guid("3b79e7f5-95f4-44dc-90b3-254f6adc1af2"), "vanilla" },
                    { new Guid("3c43ac55-3080-49b7-89cb-9bf73e1b529c"), "egg" },
                    { new Guid("3fd377b4-7400-4309-820c-15264ff4d7d6"), "unsweetened cacao powder" },
                    { new Guid("43e97756-9852-4be9-8501-e29c10d17c18"), "soy sauce" },
                    { new Guid("47d92972-b628-49a8-a622-484ebd54b9b1"), "green onion" },
                    { new Guid("4f830a38-a506-4c08-acb1-823f79a4cd66"), "bell pepper" },
                    { new Guid("50e92746-f0ca-404f-af02-acc95f20fb7f"), "peas" },
                    { new Guid("516d455e-b9cf-4cbe-b621-e9e3b4eb2efb"), "peanut butter" },
                    { new Guid("53d679c2-afb1-443b-80ea-4fb8dc6d9fd9"), "dried oregano" },
                    { new Guid("5580b4a8-a8ea-4d59-bb74-e2a6d3e0b2e0"), "rapeseed oil" },
                    { new Guid("58090840-b96b-4a9f-a36c-21595d46a455"), "honey" },
                    { new Guid("5a934a61-3346-4fd4-bdc4-325398557bf9"), "raspberries" },
                    { new Guid("5ce56d5f-6c78-487b-9c2f-e24d38d422fc"), "butter" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("64867aa2-8999-460d-9594-1e572cb095d2"), "smoked paprika" },
                    { new Guid("64fb3156-5102-4130-94e7-c3d4bde88b63"), "green beans" },
                    { new Guid("67355bf3-fa20-4ffc-9f61-21f96b8695aa"), "garlic" },
                    { new Guid("6c8e12c8-a6fd-44b5-a47c-2f6026345859"), "turmeric" },
                    { new Guid("6d461018-2399-412f-89fe-48a1d91e1c23"), "salt" },
                    { new Guid("6fa6e3d9-29ed-467f-9237-59ee215af996"), "milk" },
                    { new Guid("729c7745-ad0d-4c4d-bdb3-e3cc88795946"), "firm tofu" },
                    { new Guid("73743b7a-4d22-43c6-9be4-6caf81fe350b"), "chili powder" },
                    { new Guid("74fcb0c7-2714-43d3-8f02-7cc22f8d50a1"), "bacon" },
                    { new Guid("754db697-abf5-47bf-8af3-eccf6cbcf183"), "cherry tomato" },
                    { new Guid("762ec50f-7ce0-4fe5-b8bb-a3e117974909"), "vanilla ice cream" },
                    { new Guid("77cbcee7-7699-464a-af62-cd8529383f63"), "all-purpose flour" },
                    { new Guid("7a34c6ab-9b1f-4da1-8bf5-9c3e06b48d5c"), "carrots" },
                    { new Guid("85d89810-70c9-4331-9b4a-0ff093214292"), "white sugar" },
                    { new Guid("9325f2d5-05f3-4ca5-b9ab-bef617030ceb"), "avocado" },
                    { new Guid("97a1d277-4983-4391-bff2-d5eed6f0b722"), "nutritional yeast" },
                    { new Guid("9d3d6081-f9b0-41f1-8e1b-c3fb2d8815f7"), "sesame oil" },
                    { new Guid("a3477ac7-b564-4312-89e4-e5159c0ca6ee"), "jalapenos" },
                    { new Guid("a4668ff6-a7f7-415a-a702-9949b8bab432"), "sprinkles" },
                    { new Guid("a62e02da-4a65-41d8-be38-b10ed92b6729"), "potatoe" },
                    { new Guid("a7259215-0019-447c-bf29-edb6ec508f6b"), "almond milk" },
                    { new Guid("b0297b6f-c66b-4e25-9dd7-2ea631da0a6d"), "kalamata olive" },
                    { new Guid("b1182f5b-d42a-4180-8353-7d3a92c2a087"), "ground cumin" },
                    { new Guid("b1881084-9338-4f08-b410-fc873cc32b6f"), "pepper" },
                    { new Guid("b323a5e0-1049-4d74-b263-fa8b3ddb274a"), "greek yogurt" },
                    { new Guid("cbdb9581-c465-46e6-a862-3c9d264f02e1"), "whipped topping" },
                    { new Guid("ced0cac2-2ee1-474c-a07e-a8f1b9b77608"), "yellow onion" },
                    { new Guid("ced46de1-3ca6-4e36-8860-c3ea9cbe7818"), "banana" },
                    { new Guid("d044f72e-a406-40c2-bf23-c832b6a80c0c"), "chocolate chips" },
                    { new Guid("d30e3a42-b19f-4d76-9148-0800e00bd667"), "basil" },
                    { new Guid("e67642d0-a2dc-4208-b0a1-ef264c13f4af"), "maple syrup" },
                    { new Guid("e8a0437f-5fe7-4266-ae18-6926ff873e43"), "baking powder" },
                    { new Guid("f2f4799b-cd1b-4b70-85a9-171cc1d130ae"), "celery" },
                    { new Guid("f40bb01d-0ae6-411c-815f-0125f01f1224"), "tuna" },
                    { new Guid("f4786aa0-8fac-4a7e-bc75-9379e4927973"), "romaine lettuce" },
                    { new Guid("f53feeb9-bc74-4211-9772-fd4ba3806b73"), "celery stalks" },
                    { new Guid("f7e1dbe8-7d10-4c81-b546-39755a644c12"), "balsemic vinegar" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("372aea6a-b2a8-4e3d-b3d2-8f88254dd70d"), "garnish" },
                    { new Guid("414fde9f-a33a-40bc-8505-d83ab1ec0ad2"), "block" },
                    { new Guid("438d7974-91a4-49f4-915c-436922af5b63"), "clove" },
                    { new Guid("4f31e663-f774-41b4-bf53-223829168a25"), "cup" },
                    { new Guid("673c3060-bf5a-4090-abd0-b0e9e92c9439"), "ml" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d"), "tbsp" },
                    { new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57"), "piece" },
                    { new Guid("d7e45b8a-3375-4b20-99ee-99686515af31"), "grams" },
                    { new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46"), "tsp" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "sub", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { 2, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "ImiAdmin", "00000000-0000-0000-0000-000000000001" },
                    { 3, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "admin@imi.be", "00000000-0000-0000-0000-000000000001" },
                    { 4, "hasApprovedTerms", "", "00000000-0000-0000-0000-000000000001" },
                    { 5, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "00000000-0000-0000-0000-000000000001" },
                    { 6, "sub", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { 7, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "ImiUser", "00000000-0000-0000-0000-000000000002" },
                    { 8, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "user@imi.be", "00000000-0000-0000-0000-000000000002" },
                    { 9, "hasApprovedTerms", "True", "00000000-0000-0000-0000-000000000002" },
                    { 10, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000002" },
                    { 11, "sub", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" },
                    { 12, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "ImiRefuser", "00000000-0000-0000-0000-000000000003" },
                    { 13, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "refuser@imi.be", "00000000-0000-0000-0000-000000000003" },
                    { 14, "hasApprovedTerms", "False", "00000000-0000-0000-0000-000000000003" },
                    { 15, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "CookTime", "Description", "DietId", "ImgURL", "PrepTime", "Servings", "Title" },
                values: new object[,]
                {
                    { new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), "00000000-0000-0000-0000-000000000002", new Guid("4168b4e7-b6b8-44de-a64b-7b6bccb1c1aa"), 40, "A hearty bowl of chili is the perfect dinner for a blustery winter day.", new Guid("a1b84c43-91db-4295-8d92-3383219599ed"), "https://www.laurafuentes.com/wp-content/uploads/2013/10/Paleo_chili_recipe-card_1-2.jpg", 15, 2, "Paleo Chili" },
                    { new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), "00000000-0000-0000-0000-000000000002", new Guid("8f1023cd-0a5a-4e53-b024-76d2c111e4c5"), 30, "A healthy vegan breakfast", new Guid("7b5b75ce-ea6e-46f5-9ca9-bd6ba7f6d682"), "https://simpleveganblog.com/wp-content/uploads/2022/07/tofu-scramble-1.jpg", 15, 2, "Scrambled Tofu" },
                    { new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), "00000000-0000-0000-0000-000000000003", new Guid("08819291-50e2-4c2b-b0a1-3a85ffe13ea8"), 5, "If you’re still buying protein bars at the store, this quick and simple vegan protein bar recipe might completely change your life…", new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "https://images.unsplash.com/photo-1622484212850-eb596d769edc?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", 5, 10, "Easy Homemade Protein Bars" },
                    { new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), "00000000-0000-0000-0000-000000000003", new Guid("fdfa7823-b3cb-4354-98cd-ae768eb7af0f"), 10, "A vegetarian Niçoise salad, that's packed with goodness - fibre, folate, iron, vitamin c and gluten-free too", new Guid("fbaa5c0a-b224-4ba8-ac7b-1f3b5a4cacd3"), "https://images.unsplash.com/photo-1512621776951-a57141f2eefd?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", 10, 2, "Egg Niçoise salad" },
                    { new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), "00000000-0000-0000-0000-000000000002", new Guid("da4c0975-41c5-4651-9235-0ff05fcc9e68"), 5, "A fast and healthy lunch, packed with protein, for people in a hurry", new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "https://www.wholesomeyum.com/wp-content/uploads/2019/05/wholesomeyum-avocado-tuna-salad-recipe-1.jpg", 5, 2, "Tuna avocado salad" },
                    { new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), "00000000-0000-0000-0000-000000000002", new Guid("27fa19ac-73ef-453d-a5d7-d7f2f90a5a54"), 5, "This easy milkshake recipe gives you the perfect ratio of milk to ice cream and is completely customizable! ", new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "https://images.unsplash.com/photo-1568901839119-631418a3910d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8bWlsa3NoYWtlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", 5, 1, "Easy Vanilla Milkshake" },
                    { new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), "00000000-0000-0000-0000-000000000002", new Guid("5a42a6dc-79d0-4c3e-99ec-06def96cc5c6"), 60, "This keto mousse gets its rich, creamy texture from avocados.", new Guid("705f40d3-fc00-4781-a7b9-8c38dbfd6987"), "https://thebigmansworld.com/wp-content/uploads/2022/07/keto-chocolate-mousse.jpg", 15, 2, "Keto Chocolate Mousse" },
                    { new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), "00000000-0000-0000-0000-000000000002", new Guid("5a42a6dc-79d0-4c3e-99ec-06def96cc5c6"), 15, "I found this pancake recipe in my Grandma's recipe book. Judging from the weathered look of this recipe card, this was a family favorite.", new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "https://images.unsplash.com/photo-1565299543923-37dd37887442?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=781&q=80", 5, 8, "Good Old-Fashioned Pancakes" },
                    { new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), "00000000-0000-0000-0000-000000000002", new Guid("da4c0975-41c5-4651-9235-0ff05fcc9e68"), 60, "Easy, 10-ingredient vegan fried rice that’s loaded with vegetables, crispy baked tofu, and tons of flavor! A healthy, satisfying plant-based side dish or entrée.", new Guid("7b5b75ce-ea6e-46f5-9ca9-bd6ba7f6d682"), "https://shortgirltallorder.com/wp-content/uploads/2020/03/veggie-fried-rice-square-4.jpg", 15, 4, "Easy Vegan Fried Rice" },
                    { new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), "00000000-0000-0000-0000-000000000003", new Guid("27fa19ac-73ef-453d-a5d7-d7f2f90a5a54"), 10, "A smoothie containing 3 types of berries", new Guid("72879d1b-cad1-493d-9b87-cf39b98fa204"), "https://cookingformysoul.com/wp-content/uploads/2022/05/mixed-berry-smoothie-2-min.jpg", 5, 2, "Tripple berry smoothie" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Description", "RecipeId", "StepNumber" },
                values: new object[,]
                {
                    { new Guid("074a2222-26af-4dca-b382-e50516988529"), "While rice and tofu are cooking, prepare sauce by adding all ingredients to a medium-size mixing bowl and whisking to combine. Taste and adjust flavor as needed, adding more tamari or soy sauce for saltiness, peanut butter for creaminess, brown sugar for sweetness, or chili garlic sauce for heat.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 5 },
                    { new Guid("082c7df5-a507-4a18-91f9-3d4a59fdf718"), "Mash the avocado and lime juice together with sea salt.", new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 1 },
                    { new Guid("13712e2e-8fb5-4081-9c77-2d288d3e2eda"), "Push vegetables to one side of the pan and add beef. Cook, stirring occasionally, until no pink remains. Drain fat and return to heat.", new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2 },
                    { new Guid("137243c6-4eb1-4eea-b516-4c26916eecea"), "Add chili powder, cumin, oregano, and paprika and season with salt and pepper. Stir to combine and cook 2 minutes more. Add tomatoes and broth and bring to a simmer. Let cook 10 to 15 more minutes, until chili has thickened slightly. ", new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 3 },
                    { new Guid("15645fe9-9c10-41f2-a2b8-3e33748c40c5"), "Sift flour, baking powder, sugar, and salt together in a large bowl. Make a well in the center and add milk, melted butter, and egg; mix until smooth.", new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1 },
                    { new Guid("206da961-1205-48bb-a5b2-d1ebece3ae61"), "Add the tuna, cilantro, red onion, celery, and jalapeños (if using). Stir everything together, breaking apart any large pieces of tuna as needed.", new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 2 },
                    { new Guid("2ad520d4-cb16-4ac8-b0c8-4d2141de0dc7"), "Meanwhile boil the potatoes for 7 mins, add the beans and boil 5 mins more or until both are just tender, then drain. Boil 2 eggs for 8 minutes then shell and halve.", new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 2 },
                    { new Guid("2ea5b2e8-d385-4cef-9f9a-eb2ec057b2bf"), "To the still hot pan add garlic, green onion, peas and carrots. Sauté for 3-4 minutes, stirring occasionally, and season with 1 Tbsp (15 ml) tamari or soy sauce", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 8 },
                    { new Guid("3027df98-0ca3-4299-8ae8-d193561668f7"), "Add the 1/2 cup of oat milk and stir until the tofu has soaked up most of it.", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 4 },
                    { new Guid("3c36ac51-853e-4e00-94c7-aee576cf5e98"), "Serve with fresh bread.", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 6 },
                    { new Guid("3ffcebe7-a509-43bf-ab1f-47ac6dd7d94f"), "Heat a large metal or cast iron skillet over medium heat. Once hot, use a slotted spoon to scoop the tofu into the pan leaving most of the sauce behind. Cook for 3-4 minutes, stirring occasionally, until deep golden brown on all sides (see photo). Lower heat if browning too quickly. Remove from pan and set aside.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 7 },
                    { new Guid("4a4c2ea3-5b69-455e-8d1f-fd8b42da9f53"), "Scramble the block of tofu with your hands (see picture above) into small and bigger pieces.", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 1 },
                    { new Guid("4f2f299b-0a3e-42ca-be5b-6aea008a1bcc"), "Adjust salt and jalapeños to taste if needed. Serve immediately.", new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 3 },
                    { new Guid("6a50b968-0e52-48bf-870b-1ea9075e30b7"), "In a blender, blend together ice cream and milk.", new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 1 },
                    { new Guid("6b5da959-e032-4359-912d-276c5d5733a4"), "In a blender, combine all ingredients and blend until smooth.", new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 1 },
                    { new Guid("6c41439f-cce7-4ea8-ab5c-9fc94e975596"), "When there is only a small amount of milk remaining, add all of the remaining ingredients and stir for another 3-4 minutes on low to medium heat.", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 5 },
                    { new Guid("72267ce8-e535-403e-8d53-c3adee0c4755"), "For the optional chocolate coating, spread the melted chocolate over the pan before chilling. (I usually stir 2 tsp oil into the melted chocolate for a smoother sauce, but it's not required.) Or you can dip the bars into the chocolate sauce individually and then chill to set.", new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 2 },
                    { new Guid("7dc005eb-f760-4b34-ad9d-916367bd27c7"), "Toss the beans, potatoes and remaining salad ingredients, except the eggs, together in a large bowl with half the dressing. Arrange the eggs on top and drizzle over the remaining dressing.", new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 3 },
                    { new Guid("97298c36-6fd6-4533-aef0-0695cbe3e4bd"), "Transfer to serving glasses and refrigerate 30 minutes and up to 1 hour. Garnish with chocolate curls if using.", new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 2 },
                    { new Guid("a6f2ac69-df2b-4efa-ada0-8cd7d80c0e54"), "Divide between 2 cups and top with blackberries, if desired.", new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 2 },
                    { new Guid("b5d5f784-4b20-4bbc-8e21-598083f04228"), "Once the oven is preheated, dice tofu into 1/4-inch cubes and arrange on baking sheet. Bake for 26-30 minutes. You’re looking for golden brown edges and a texture that’s firm to the touch. The longer it bakes, the firmer and crispier it will become, so if you’re looking for softer tofu remove from the oven around the 26-28 minute mark. I prefer crispy tofu, so I bake mine the full 30 minutes. Set aside.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 3 },
                    { new Guid("b6c3a5a0-c53d-486b-adc5-cca2767491d6"), "Ladle into bowls and top with reserved bacon, jalapeños, cilantro, and avocado.", new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 4 },
                    { new Guid("c17a04d9-5711-42b5-8b1a-0c96e7c0d308"), "In the meantime wrap tofu in a clean, absorbent towel and set something heavy on top (such as a cast iron skillet) to press out the liquid.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 2 },
                    { new Guid("c36a6a86-677a-45ae-a946-30e7c86b3317"), "Heat 1 tablespoon of oil on medium heat in a pan. Caramelize the chopped red onions", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 2 },
                    { new Guid("c4d5c156-e964-47e5-9d7a-1bb9c9520c79"), "Pour into a glass and garnish with whipped topping, sprinkles, cacao powder and a cherry.", new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 2 },
                    { new Guid("c95d7068-cd00-4a07-8743-b7296604c4af"), "Preheat oven to 400 degrees F (204 C) and line a baking sheet with parchment paper (or lightly grease with non-stick spray).", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1 },
                    { new Guid("d1b064a7-9010-445e-a33e-b7c0c22ccbcc"), "While the tofu bakes prepare your rice by bringing 12 cups of water to a boil in a large pot. Once boiling, add rinsed rice and stir. Boil on high uncovered for 30 minutes, then strain for 10 seconds and return to pot removed from the heat. Cover with a lid and let steam for 10 minutes*.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 4 },
                    { new Guid("d5a01bb6-fcc7-449f-a8e1-7fcb27c5a9e5"), "Mix the dressing ingredients together in a small bowl with 1 tbsp water.", new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 1 },
                    { new Guid("d66a39e0-3413-4f65-a27f-0469f0262ec3"), "In a food processor or blender, blend all ingredients except chocolate curls until smooth.", new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 1 },
                    { new Guid("e2a8528e-d1ab-4ff9-93a6-488850e92ca5"), "Heat a lightly oiled griddle or pan over medium-high heat. Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake; cook until bubbles form and the edges are dry, about 2 to 3 minutes. Flip and cook until browned on the other side. Repeat with remaining batter.", new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 2 },
                    { new Guid("e62475e0-71fb-4969-ba8b-fcf05aacfe37"), "Stir all ingredients except optional chips to form a dough. Either shape into bars with your hands or smooth into a lined 8×8 pan, refrigerate until chilled, then cut into bars.", new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 1 },
                    { new Guid("e809364d-5497-4c8b-8967-27c8f2ac52d6"), "Serve immediately with extra chili garlic sauce or sriracha for heat (optional). Crushed salted, roasted peanuts or cashews make a lovely additional garnish. Leftovers keep well in the refrigerator for 3-4 days, though best when fresh. Reheat in a skillet over medium heat or in the microwave.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 10 },
                    { new Guid("ec37c661-0e9e-47b2-921e-ba0e7a2c6ee8"), "Add cooked rice, tofu, and remaining sauce and stir. Cook over medium-high heat for 3-4 minutes, stirring frequently.", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 9 },
                    { new Guid("edc1d587-b322-4135-9fd7-ae683fc15014"), "In a large pot over medium heat, cook bacon. When bacon is crisp, remove from pot with a slotted spoon. Add onion, celery, and peppers to pot and cook until soft, 6 minutes. Add garlic and cook until fragrant, 1 minute more.", new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 1 },
                    { new Guid("f17fc301-2c86-48a6-9dfc-5cd0ddeec594"), "Add the scrambled tofu and stir for 1 minute.", new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 3 },
                    { new Guid("f9f74755-1b60-4ace-b724-b9e5d0226e56"), "Once the tofu is done baking, add directly to the sauce and marinate for 5 minutes, stirring occasionally", new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 6 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "UnitId" },
                values: new object[,]
                {
                    { new Guid("002ddabe-b201-4679-9bfe-f6dca4cc7b53"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 0.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("046dce63-063c-4b9e-887e-373efa9d2523"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 1.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("16caadcd-699e-4a5d-9dc5-f54e41692784"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 0.75, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("16ecdb26-24ec-48b6-8ffd-45bc188ad234"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 0.5, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("1c41dcde-22c9-4ae8-a1f5-718aea034da0"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 0.5, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("1c41dcde-22c9-4ae8-a1f5-718aea034da0"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 3.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "UnitId" },
                values: new object[,]
                {
                    { new Guid("1c5e3925-8ae4-4926-9eac-3628e7920984"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 150.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("1cddb371-eaa0-4345-88ea-3a76b8cad449"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1.0, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("24e47ca1-08cc-4c98-a84e-fb9876d2c39a"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 0.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("299140ef-1ffe-4c3b-84c9-11b2c3022f62"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 2.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("35ba74dd-b3ad-44e2-9d80-6abb956a0bbd"), new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 0.75, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("372c5ae2-7acc-48a6-b65f-9de13846c9d3"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 150.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("3a1ec623-e070-4912-9fce-4e48bb9aa5e9"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 0.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("3b79e7f5-95f4-44dc-90b3-254f6adc1af2"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 1.0, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("3c43ac55-3080-49b7-89cb-9bf73e1b529c"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 2.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("3c43ac55-3080-49b7-89cb-9bf73e1b529c"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("3fd377b4-7400-4309-820c-15264ff4d7d6"), new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 0.5, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("3fd377b4-7400-4309-820c-15264ff4d7d6"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 3.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("43e97756-9852-4be9-8501-e29c10d17c18"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 3.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("47d92972-b628-49a8-a622-484ebd54b9b1"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1.0, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("4f830a38-a506-4c08-acb1-823f79a4cd66"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 0.5, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("50e92746-f0ca-404f-af02-acc95f20fb7f"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 0.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("516d455e-b9cf-4cbe-b621-e9e3b4eb2efb"), new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 1.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("516d455e-b9cf-4cbe-b621-e9e3b4eb2efb"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("53d679c2-afb1-443b-80ea-4fb8dc6d9fd9"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2.0, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("5580b4a8-a8ea-4d59-bb74-e2a6d3e0b2e0"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 2.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("58090840-b96b-4a9f-a36c-21595d46a455"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 0.25, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("5a934a61-3346-4fd4-bdc4-325398557bf9"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 150.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("5ce56d5f-6c78-487b-9c2f-e24d38d422fc"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 3.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("64867aa2-8999-460d-9594-1e572cb095d2"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("64fb3156-5102-4130-94e7-c3d4bde88b63"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 200.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("67355bf3-fa20-4ffc-9f61-21f96b8695aa"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 1.0, new Guid("438d7974-91a4-49f4-915c-436922af5b63") },
                    { new Guid("67355bf3-fa20-4ffc-9f61-21f96b8695aa"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 4.0, new Guid("438d7974-91a4-49f4-915c-436922af5b63") },
                    { new Guid("6c8e12c8-a6fd-44b5-a47c-2f6026345859"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 0.75, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("6d461018-2399-412f-89fe-48a1d91e1c23"), new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 0.5, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("6d461018-2399-412f-89fe-48a1d91e1c23"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 0.5, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("6d461018-2399-412f-89fe-48a1d91e1c23"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 0.25, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("6fa6e3d9-29ed-467f-9237-59ee215af996"), new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 1.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("6fa6e3d9-29ed-467f-9237-59ee215af996"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1.25, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("729c7745-ad0d-4c4d-bdb3-e3cc88795946"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 1.0, new Guid("414fde9f-a33a-40bc-8505-d83ab1ec0ad2") },
                    { new Guid("729c7745-ad0d-4c4d-bdb3-e3cc88795946"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1.0, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("73743b7a-4d22-43c6-9be4-6caf81fe350b"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("74fcb0c7-2714-43d3-8f02-7cc22f8d50a1"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 1.0, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("762ec50f-7ce0-4fe5-b8bb-a3e117974909"), new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 1.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("77cbcee7-7699-464a-af62-cd8529383f63"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("7a34c6ab-9b1f-4da1-8bf5-9c3e06b48d5c"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 0.5, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("85d89810-70c9-4331-9b4a-0ff093214292"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("9325f2d5-05f3-4ca5-b9ab-bef617030ceb"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 2.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "UnitId" },
                values: new object[,]
                {
                    { new Guid("9325f2d5-05f3-4ca5-b9ab-bef617030ceb"), new Guid("a8826730-ee34-42fa-9fdd-357efa440e8f"), 2.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("97a1d277-4983-4391-bff2-d5eed6f0b722"), new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), 1.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("9d3d6081-f9b0-41f1-8e1b-c3fb2d8815f7"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 1.0, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("a3477ac7-b564-4312-89e4-e5159c0ca6ee"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 1.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("a4668ff6-a7f7-415a-a702-9949b8bab432"), new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 0.0, new Guid("372aea6a-b2a8-4e3d-b3d2-8f88254dd70d") },
                    { new Guid("a62e02da-4a65-41d8-be38-b10ed92b6729"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 250.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("a7259215-0019-447c-bf29-edb6ec508f6b"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 250.0, new Guid("673c3060-bf5a-4090-abd0-b0e9e92c9439") },
                    { new Guid("b0297b6f-c66b-4e25-9dd7-2ea631da0a6d"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 6.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("b1182f5b-d42a-4180-8353-7d3a92c2a087"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2.0, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("b323a5e0-1049-4d74-b263-fa8b3ddb274a"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 200.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("cbdb9581-c465-46e6-a862-3c9d264f02e1"), new Guid("6774c795-1374-4968-b8c4-d799c95a99aa"), 0.0, new Guid("372aea6a-b2a8-4e3d-b3d2-8f88254dd70d") },
                    { new Guid("ced0cac2-2ee1-474c-a07e-a8f1b9b77608"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 0.5, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("ced46de1-3ca6-4e36-8860-c3ea9cbe7818"), new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), 1.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("d044f72e-a406-40c2-bf23-c832b6a80c0c"), new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 35.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("d30e3a42-b19f-4d76-9148-0800e00bd667"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 0.0, new Guid("372aea6a-b2a8-4e3d-b3d2-8f88254dd70d") },
                    { new Guid("e67642d0-a2dc-4208-b0a1-ef264c13f4af"), new Guid("38a2b613-d9fd-48d2-b40c-9acb36c51aa6"), 0.25, new Guid("4f31e663-f774-41b4-bf53-223829168a25") },
                    { new Guid("e67642d0-a2dc-4208-b0a1-ef264c13f4af"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 1.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("e67642d0-a2dc-4208-b0a1-ef264c13f4af"), new Guid("ce5db7c4-d085-4c2e-ae6c-8458e21b40fa"), 2.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("e8a0437f-5fe7-4266-ae18-6926ff873e43"), new Guid("c4f5d1d8-8f78-4cb7-a685-eefd074032dd"), 3.5, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") },
                    { new Guid("f2f4799b-cd1b-4b70-85a9-171cc1d130ae"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 3.0, new Guid("7acc646e-c783-45ec-b7e3-0ab8acf60c7d") },
                    { new Guid("f40bb01d-0ae6-411c-815f-0125f01f1224"), new Guid("5ad0e1ba-5b8f-46b8-810f-18bcf88356ff"), 140.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("f4786aa0-8fac-4a7e-bc75-9379e4927973"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 15.0, new Guid("d7e45b8a-3375-4b20-99ee-99686515af31") },
                    { new Guid("f53feeb9-bc74-4211-9772-fd4ba3806b73"), new Guid("1a529ac5-d1ee-48a6-b654-c37bde10202f"), 2.0, new Guid("9aebd1dc-5543-4161-95e8-a6627d02cf57") },
                    { new Guid("f7e1dbe8-7d10-4c81-b546-39755a644c12"), new Guid("4445995c-bcc7-4e7a-b791-8cd8609bab42"), 1.0, new Guid("e472535e-c831-4133-8c4c-b7d2a070ea46") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "CreationDate", "Rating", "RecipeId", "UpdateTimeStamp" },
                values: new object[,]
                {
                    { new Guid("44beb3de-e0cc-4073-ab32-b5254f8c6803"), "00000000-0000-0000-0000-000000000002", "Definitely will eat this again!", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a649a0b5-4c2b-4625-a328-9933992ab162"), "00000000-0000-0000-0000-000000000003", "Great recipe!", new DateTime(2023, 6, 18, 13, 9, 18, 76, DateTimeKind.Local).AddTicks(8870), 4, new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), new DateTime(2023, 6, 18, 13, 9, 18, 76, DateTimeKind.Local).AddTicks(8907) },
                    { new Guid("e8abb212-ee94-4214-a0d9-73ce43a55a86"), "00000000-0000-0000-0000-000000000003", "Didn't taste good", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("350c87a1-ffdc-473c-8af9-83edf8db8c31"), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fdadde2c-57c9-4b12-a96c-5769733b13d2"), "00000000-0000-0000-0000-000000000002", null, new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("e59cb9cd-e770-4c15-b3fa-82e153bf8546"), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_FavoriteRecipes_ApplicationUserId",
                table: "FavoriteRecipes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_UnitId",
                table: "RecipeIngredients",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ApplicationUserId",
                table: "Recipes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DietId",
                table: "Recipes",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RecipeId",
                table: "Reviews",
                column: "RecipeId");
        }

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
                name: "FavoriteRecipes");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Diets");
        }
    }
}
