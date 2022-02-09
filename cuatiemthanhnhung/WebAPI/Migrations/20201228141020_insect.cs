using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class insect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cttnBills",
                columns: table => new
                {
                    BillId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cttnBills", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "cttnCategories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: true),
                    SeoTittle = table.Column<string>(maxLength: 100, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cttnCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ImicBlogCategories",
                columns: table => new
                {
                    BlogCateId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    BlogCateName = table.Column<string>(maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    SeoTittle = table.Column<string>(maxLength: 50, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImicBlogCategories", x => x.BlogCateId);
                });

            migrationBuilder.CreateTable(
                name: "ImicInfomations",
                columns: table => new
                {
                    InformationId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    OfficeName = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    Position = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImicInfomations", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "ImicKeyCodes",
                columns: table => new
                {
                    KeyCodeId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImicKeyCodes", x => x.KeyCodeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "cttnBillDetails",
                columns: table => new
                {
                    BillDetailId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ProductName = table.Column<string>(maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    TotalMoney = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    BillId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cttnBillDetails", x => x.BillDetailId);
                    table.ForeignKey(
                        name: "FK_cttnBillDetails_cttnBills",
                        column: x => x.BillId,
                        principalTable: "cttnBills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cttnProducts",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ProductName = table.Column<string>(maxLength: 100, nullable: true),
                    Summary = table.Column<string>(maxLength: 200, nullable: true),
                    Detail = table.Column<string>(type: "ntext", nullable: true),
                    SeoTittle = table.Column<string>(maxLength: 100, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CategoryId = table.Column<Guid>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Image = table.Column<string>(maxLength: 500, nullable: true),
                    KeyCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cttnProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_cttnProducts_cttnCategories",
                        column: x => x.CategoryId,
                        principalTable: "cttnCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImicBlogs",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    Seen = table.Column<int>(nullable: true),
                    SeoTittle = table.Column<string>(maxLength: 50, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Tittle = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    BlogImage = table.Column<string>(maxLength: 500, nullable: true),
                    BlogCateId = table.Column<Guid>(nullable: true),
                    BackGround = table.Column<string>(maxLength: 500, nullable: true),
                    Summary = table.Column<string>(maxLength: 500, nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: true),
                    KeyCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImicBlogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_ImicBlogs_ImicBlogCategories",
                        column: x => x.BlogCateId,
                        principalTable: "ImicBlogCategories",
                        principalColumn: "BlogCateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImicBlogDetails",
                columns: table => new
                {
                    BlogDetailId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    BlogId = table.Column<Guid>(nullable: true),
                    Tittle = table.Column<string>(maxLength: 200, nullable: true),
                    Number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImicBlogDetails", x => x.BlogDetailId);
                    table.ForeignKey(
                        name: "FK_ImicBlogDetails_ImicBlogs",
                        column: x => x.BlogId,
                        principalTable: "ImicBlogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_cttnBillDetails_BillId",
                table: "cttnBillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_cttnProducts_CategoryId",
                table: "cttnProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ImicBlogDetails_BlogId",
                table: "ImicBlogDetails",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_ImicBlogs_BlogCateId",
                table: "ImicBlogs",
                column: "BlogCateId");
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
                name: "cttnBillDetails");

            migrationBuilder.DropTable(
                name: "cttnProducts");

            migrationBuilder.DropTable(
                name: "ImicBlogDetails");

            migrationBuilder.DropTable(
                name: "ImicInfomations");

            migrationBuilder.DropTable(
                name: "ImicKeyCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "cttnBills");

            migrationBuilder.DropTable(
                name: "cttnCategories");

            migrationBuilder.DropTable(
                name: "ImicBlogs");

            migrationBuilder.DropTable(
                name: "ImicBlogCategories");
        }
    }
}
