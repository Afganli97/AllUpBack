﻿// <auto-generated />
using System;
using AllUpBack.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllUpBack.Migrations
{
    [DbContext(typeof(DataBase))]
    partial class DataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("AllUpBack.Models.Advantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Advantages");
                });

            modelBuilder.Entity("AllUpBack.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSubscribed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AllUpBack.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("AllUpBack.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("AllUpBack.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("AllUpBack.Models.BlogTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("AllUpBack.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AllUpBack.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AllUpBack.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("AllUpBack.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AllUpBack.Models.Composition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Compositions");
                });

            modelBuilder.Entity("AllUpBack.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("CloseTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("HotlineNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpenTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("AllUpBack.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdvantageId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BannerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PartnerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SliderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdvantageId")
                        .IsUnique();

                    b.HasIndex("BannerId")
                        .IsUnique();

                    b.HasIndex("BioId")
                        .IsUnique();

                    b.HasIndex("BlogId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("PartnerId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("SliderId")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("AllUpBack.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("AllUpBack.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductComposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompositionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompositionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCompositions");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("AllUpBack.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SizeName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("AllUpBack.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductDesc")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("AllUpBack.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AllUpBack.Models.Banner", b =>
                {
                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithOne("Banner")
                        .HasForeignKey("AllUpBack.Models.Banner", "ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AllUpBack.Models.BlogTag", b =>
                {
                    b.HasOne("AllUpBack.Models.Blog", "Blog")
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogId");

                    b.HasOne("AllUpBack.Models.Tag", "Tag")
                        .WithMany("BlogTags")
                        .HasForeignKey("TagId");

                    b.Navigation("Blog");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("AllUpBack.Models.Category", b =>
                {
                    b.HasOne("AllUpBack.Models.Category", "Parent")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("AllUpBack.Models.Image", b =>
                {
                    b.HasOne("AllUpBack.Models.Advantage", "Advantage")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "AdvantageId");

                    b.HasOne("AllUpBack.Models.Banner", "Banner")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "BannerId");

                    b.HasOne("AllUpBack.Models.Bio", "Bio")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "BioId");

                    b.HasOne("AllUpBack.Models.Blog", "Blog")
                        .WithMany("Images")
                        .HasForeignKey("BlogId");

                    b.HasOne("AllUpBack.Models.Category", "Category")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "CategoryId");

                    b.HasOne("AllUpBack.Models.Partner", "Partner")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "PartnerId");

                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId");

                    b.HasOne("AllUpBack.Models.Slider", "Slider")
                        .WithOne("Image")
                        .HasForeignKey("AllUpBack.Models.Image", "SliderId");

                    b.Navigation("Advantage");

                    b.Navigation("Banner");

                    b.Navigation("Bio");

                    b.Navigation("Blog");

                    b.Navigation("Category");

                    b.Navigation("Partner");

                    b.Navigation("Product");

                    b.Navigation("Slider");
                });

            modelBuilder.Entity("AllUpBack.Models.Product", b =>
                {
                    b.HasOne("AllUpBack.Models.Brand", null)
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("AllUpBack.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductColor", b =>
                {
                    b.HasOne("AllUpBack.Models.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId");

                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithMany("ProductColors")
                        .HasForeignKey("ProductId");

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductComposition", b =>
                {
                    b.HasOne("AllUpBack.Models.Composition", "Composition")
                        .WithMany("ProductCompositions")
                        .HasForeignKey("CompositionId");

                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithMany("ProductCompositions")
                        .HasForeignKey("ProductId");

                    b.Navigation("Composition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductSize", b =>
                {
                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProductId");

                    b.HasOne("AllUpBack.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("AllUpBack.Models.ProductTag", b =>
                {
                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId");

                    b.HasOne("AllUpBack.Models.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId");

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("AllUpBack.Models.Slider", b =>
                {
                    b.HasOne("AllUpBack.Models.Product", "Product")
                        .WithOne("Slider")
                        .HasForeignKey("AllUpBack.Models.Slider", "ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AllUpBack.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AllUpBack.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllUpBack.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AllUpBack.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllUpBack.Models.Advantage", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("AllUpBack.Models.Banner", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("AllUpBack.Models.Bio", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("AllUpBack.Models.Blog", b =>
                {
                    b.Navigation("BlogTags");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("AllUpBack.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AllUpBack.Models.Category", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("AllUpBack.Models.Color", b =>
                {
                    b.Navigation("ProductColors");
                });

            modelBuilder.Entity("AllUpBack.Models.Composition", b =>
                {
                    b.Navigation("ProductCompositions");
                });

            modelBuilder.Entity("AllUpBack.Models.Partner", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("AllUpBack.Models.Product", b =>
                {
                    b.Navigation("Banner");

                    b.Navigation("Images");

                    b.Navigation("ProductColors");

                    b.Navigation("ProductCompositions");

                    b.Navigation("ProductSizes");

                    b.Navigation("ProductTags");

                    b.Navigation("Slider");
                });

            modelBuilder.Entity("AllUpBack.Models.Size", b =>
                {
                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("AllUpBack.Models.Slider", b =>
                {
                    b.Navigation("Image");
                });

            modelBuilder.Entity("AllUpBack.Models.Tag", b =>
                {
                    b.Navigation("BlogTags");

                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
