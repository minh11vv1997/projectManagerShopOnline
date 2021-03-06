// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(CTTNDbContext))]
    [Migration("20201228141020_insect")]
    partial class insect
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebAPI.Models.CttnBillDetails", b =>
                {
                    b.Property<Guid>("BillDetailId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("BillId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<int?>("Quantity");

                    b.Property<byte?>("Status");

                    b.Property<decimal?>("TotalMoney")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId");

                    b.ToTable("cttnBillDetails");
                });

            modelBuilder.Entity("WebAPI.Models.CttnBills", b =>
                {
                    b.Property<Guid>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FullName")
                        .HasMaxLength(100);

                    b.Property<string>("Mobile")
                        .HasMaxLength(100);

                    b.Property<byte?>("Status");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("BillId");

                    b.ToTable("cttnBills");
                });

            modelBuilder.Entity("WebAPI.Models.CttnCategories", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasMaxLength(500);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTittle")
                        .HasMaxLength(100);

                    b.Property<byte?>("Status");

                    b.HasKey("CategoryId");

                    b.ToTable("cttnCategories");
                });

            modelBuilder.Entity("WebAPI.Models.CttnProducts", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("CategoryId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("Detail")
                        .HasColumnType("ntext");

                    b.Property<string>("Image")
                        .HasMaxLength(500);

                    b.Property<int?>("KeyCode");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTittle")
                        .HasMaxLength(100);

                    b.Property<byte?>("Status");

                    b.Property<string>("Summary")
                        .HasMaxLength(200);

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("cttnProducts");
                });

            modelBuilder.Entity("WebAPI.Models.ImicBlogCategories", b =>
                {
                    b.Property<Guid>("BlogCateId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("BlogCateName")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTittle")
                        .HasMaxLength(50);

                    b.Property<byte?>("Status");

                    b.HasKey("BlogCateId");

                    b.ToTable("ImicBlogCategories");
                });

            modelBuilder.Entity("WebAPI.Models.ImicBlogDetails", b =>
                {
                    b.Property<Guid>("BlogDetailId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("BlogId");

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<int?>("Number");

                    b.Property<byte?>("Status");

                    b.Property<string>("Tittle")
                        .HasMaxLength(200);

                    b.HasKey("BlogDetailId");

                    b.HasIndex("BlogId");

                    b.ToTable("ImicBlogDetails");
                });

            modelBuilder.Entity("WebAPI.Models.ImicBlogs", b =>
                {
                    b.Property<Guid>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("BackGround")
                        .HasMaxLength(500);

                    b.Property<Guid?>("BlogCateId");

                    b.Property<string>("BlogImage")
                        .HasMaxLength(500);

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<int?>("KeyCode");

                    b.Property<int?>("Seen");

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTittle")
                        .HasMaxLength(50);

                    b.Property<byte?>("Status");

                    b.Property<string>("Summary")
                        .HasMaxLength(500);

                    b.Property<string>("Tittle")
                        .HasMaxLength(100);

                    b.Property<string>("UserId")
                        .HasMaxLength(450);

                    b.HasKey("BlogId");

                    b.HasIndex("BlogCateId");

                    b.ToTable("ImicBlogs");
                });

            modelBuilder.Entity("WebAPI.Models.ImicInformations", b =>
                {
                    b.Property<Guid>("InformationId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Mobile")
                        .HasMaxLength(100);

                    b.Property<string>("OfficeName")
                        .HasMaxLength(100);

                    b.Property<int?>("Position");

                    b.Property<byte?>("Status");

                    b.HasKey("InformationId");

                    b.ToTable("ImicInfomations");
                });

            modelBuilder.Entity("WebAPI.Models.ImicKeyCodes", b =>
                {
                    b.Property<Guid>("KeyCodeId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("Number");

                    b.HasKey("KeyCodeId");

                    b.ToTable("ImicKeyCodes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.CttnBillDetails", b =>
                {
                    b.HasOne("WebAPI.Models.CttnBills", "Bill")
                        .WithMany("CttnBillDetails")
                        .HasForeignKey("BillId")
                        .HasConstraintName("FK_cttnBillDetails_cttnBills");
                });

            modelBuilder.Entity("WebAPI.Models.CttnProducts", b =>
                {
                    b.HasOne("WebAPI.Models.CttnCategories", "Category")
                        .WithMany("CttnProducts")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_cttnProducts_cttnCategories");
                });

            modelBuilder.Entity("WebAPI.Models.ImicBlogDetails", b =>
                {
                    b.HasOne("WebAPI.Models.ImicBlogs", "Blog")
                        .WithMany("ImicBlogDetails")
                        .HasForeignKey("BlogId")
                        .HasConstraintName("FK_ImicBlogDetails_ImicBlogs");
                });

            modelBuilder.Entity("WebAPI.Models.ImicBlogs", b =>
                {
                    b.HasOne("WebAPI.Models.ImicBlogCategories", "BlogCate")
                        .WithMany("ImicBlogs")
                        .HasForeignKey("BlogCateId")
                        .HasConstraintName("FK_ImicBlogs_ImicBlogCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
