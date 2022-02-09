using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedObject.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CTTNDbContext : IdentityDbContext
    {


        public CTTNDbContext(DbContextOptions<CTTNDbContext> options)
           : base(options)
        {

        }

        #region DbSet
        public virtual DbSet<CttnCategories> CttnCategories { get; set; }
        public virtual DbSet<CttnProducts> CttnProducts { get; set; }
        public virtual DbSet<ImicBlogCategories> ImicBlogCategories { get; set; }
        public virtual DbSet<ImicBlogs> ImicBlogs { get; set; }
        public virtual DbSet<ImicKeyCodes> ImicKeyCodes { get; set; }
        public virtual DbSet<ImicBlogDetails> ImicBlogDetails { get; set; }
        public virtual DbSet<ImicInformations> ImicInfomations { get; set; }
        public virtual DbSet<CttnBillDetails> CttnBillDetails { get; set; }
        public virtual DbSet<CttnBills> CttnBills { get; set; }


        #endregion

        #region DbQuery
        public virtual DbQuery<VProduct> VProduct { get; set; } 
        public virtual DbQuery<VInformation> VInformation { get; set; } 
       
        public virtual DbQuery<VBlog> VBlog { get; set; } 
        public virtual DbQuery<VBlogCategory> VBlogCategory { get; set; } 
        public virtual DbQuery<VCategory> VCategory { get; set; } 
        public virtual DbQuery<VBlogDetail> VBlogDetail { get; set; } 
        public virtual DbQuery<VKeyCode> VKeyCode { get; set; }
        public virtual DbQuery<VBill> VBill { get; set; }
        public virtual DbQuery<VBillDetail> VBillDetail { get; set; }
      
        #endregion

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<CttnBillDetails>(entity =>
            {
                entity.HasKey(e => e.BillDetailId);

                entity.ToTable("cttnBillDetails");

                entity.Property(e => e.BillDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.TotalMoney).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.CttnBillDetails)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_cttnBillDetails_cttnBills");
            });

            modelbuilder.Entity<CttnBills>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("cttnBills");

                entity.Property(e => e.BillId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
            });

            modelbuilder.Entity<CttnCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("cttnCategories");

                entity.Property(e => e.CategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoTittle).HasMaxLength(100);
            });

            modelbuilder.Entity<CttnProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("cttnProducts");

                entity.Property(e => e.ProductId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("ntext");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoTittle).HasMaxLength(100);

                entity.Property(e => e.Summary).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CttnProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_cttnProducts_cttnCategories");
            });

            modelbuilder.Entity<ImicBlogCategories>(entity =>
            {
                entity.HasKey(e => e.BlogCateId);

                entity.Property(e => e.BlogCateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BlogCateName).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoTittle).HasMaxLength(50);
            });

            modelbuilder.Entity<ImicBlogDetails>(entity =>
            {
                entity.HasKey(e => e.BlogDetailId);

                entity.Property(e => e.BlogDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Tittle).HasMaxLength(200);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.ImicBlogDetails)
                    .HasForeignKey(d => d.BlogId)
                    .HasConstraintName("FK_ImicBlogDetails_ImicBlogs");
            });

            modelbuilder.Entity<ImicBlogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.Property(e => e.BlogId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BackGround).HasMaxLength(500);

                entity.Property(e => e.BlogImage).HasMaxLength(500);

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoTittle).HasMaxLength(50);

                entity.Property(e => e.Summary).HasMaxLength(500);

                entity.Property(e => e.Tittle).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.BlogCate)
                    .WithMany(p => p.ImicBlogs)
                    .HasForeignKey(d => d.BlogCateId)
                    .HasConstraintName("FK_ImicBlogs_ImicBlogCategories");
            });

        

            modelbuilder.Entity<ImicInformations>(entity =>
            {
                entity.HasKey(e => e.InformationId);

                entity.Property(e => e.InformationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.OfficeName).HasMaxLength(100);
            });

            modelbuilder.Entity<ImicKeyCodes>(entity =>
            {
                entity.HasKey(e => e.KeyCodeId);

                entity.Property(e => e.KeyCodeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });
         
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8CIII70;Initial Catalog=CTTN;User Id=sa;Password=123456;MultipleActiveResultSets=true;");
            }
        }
    }
}
