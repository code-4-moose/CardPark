﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectCardPark1.Data;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    [DbContext(typeof(ProjectCardPark1Context))]
    [Migration("20250130081507_AdminUser")]
    partial class AdminUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectCardPark1.Data.ProjectCardPark1User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f7e59fe-2b20-4f36-98dd-5e080948cd34",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEH39NcTxnuEhyz0PjtjqMYrEn0g22FTDDHGb8aLLYRwrK5swA9zPC4CoyzI/g6TrLw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d0d6edee-2790-4fae-90ea-71642607889f",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            Contact = 12345678,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(2221),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(2247),
                            Name = "SuperBoss",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("Card");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            Condition = "New",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3042),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3045),
                            ListingId = 1,
                            Name = "Pokemon",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CardId = 2,
                            Condition = "Old",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3047),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3048),
                            ListingId = 1,
                            Name = "Ultraman",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CardId = 3,
                            Condition = "Broken",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3050),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3051),
                            ListingId = 2,
                            Name = "Wonderwoman",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            CardId = 4,
                            Condition = "New",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3053),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3054),
                            ListingId = 3,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            CardId = 5,
                            Condition = "Stolen",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3056),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3056),
                            ListingId = 3,
                            Name = "Aquaman",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 1,
                            CategoryId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3251),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3257),
                            Name = "PG",
                            Type = "unknown",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 1,
                            CategoryId = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3260),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3260),
                            Name = "PG",
                            Type = "unknown",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 1,
                            CategoryId = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3263),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3263),
                            Name = "R18",
                            Type = "WhoKnows",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ListingImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ListingImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool?>("Sold")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<double>("Stars")
                        .HasColumnType("float");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3463),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3464),
                            Description = "Beautify Card!",
                            RatingId = 1,
                            Stars = 9.5,
                            UpdatedBy = "System",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3470),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3471),
                            Description = "Cards are damaged! Dishonesty!",
                            RatingId = 2,
                            Stars = 3.0,
                            UpdatedBy = "System",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3473),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3474),
                            Description = "Will Trade again!",
                            RatingId = 3,
                            Stars = 8.0,
                            UpdatedBy = "System",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3476),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3477),
                            Description = "Will NOT Trade again! Shame!",
                            RatingId = 4,
                            Stars = 1.0,
                            UpdatedBy = "System",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3480),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3480),
                            Description = "Great! Never been so good!",
                            RatingId = 5,
                            Stars = 8.9000000000000004,
                            UpdatedBy = "System",
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3482),
                            DateUpdated = new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3483),
                            Description = "Scary Trader!",
                            RatingId = 6,
                            Stars = 0.0,
                            UpdatedBy = "System",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoRatings")
                        .HasColumnType("int");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<double>("Stars")
                        .HasColumnType("float");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Nil",
                            Contact = 889988123,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Name = "Admin",
                            RatingId = 3,
                            Stars = 0.0,
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                        });
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
                    b.HasOne("ProjectCardPark1.Data.ProjectCardPark1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectCardPark1.Data.ProjectCardPark1User", null)
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

                    b.HasOne("ProjectCardPark1.Data.ProjectCardPark1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectCardPark1.Data.ProjectCardPark1User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Card", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.Listing", "Listing")
                        .WithMany("Card")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Category", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.Admin", "Admin")
                        .WithMany("Category")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Listing", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.Admin", "Admin")
                        .WithMany("Listing")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProjectCardPark1.Domain.Category", "Category")
                        .WithMany("Listing")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProjectCardPark1.Domain.User", "User")
                        .WithMany("Listing")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Rating", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.User", "User")
                        .WithMany("Rating")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Admin", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Category", b =>
                {
                    b.Navigation("Listing");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Listing", b =>
                {
                    b.Navigation("Card");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.User", b =>
                {
                    b.Navigation("Listing");

                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}
