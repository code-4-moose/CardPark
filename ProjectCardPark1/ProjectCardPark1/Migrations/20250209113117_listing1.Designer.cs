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
    [Migration("20250209113117_listing1")]
    partial class listing1
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
                        },
                        new
                        {
                            UserId = "4181efe7-66dc-47f0-860f-e506d04102e5",
                            RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb"
                        },
                        new
                        {
                            UserId = "5181efe8-31de-47f0-860f-e514d04102e5",
                            RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb"
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
                            ConcurrencyStamp = "e8800528-1484-48b6-8f3e-4e6f44a718d2",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDBLKN17PjfePz6Jb3TaAxU46BugjF/7TTDMW/2ibiNnyIQqk0ISVr6U93uDjNDwsQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5de35c5c-5afd-439f-8928-8ceb2bb2b030",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "4181efe7-66dc-47f0-860f-e506d04102e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3beee462-c58e-415f-8c45-bde25c3e366f",
                            Email = "amostan@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Amos",
                            LastName = "Tan",
                            LockoutEnabled = false,
                            NormalizedEmail = "AMOSTAN@GMAIL.COM",
                            NormalizedUserName = "AMOSTAN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEX6yeyt+bpaBEwnQ7+NeSdDy4zWfnCV5pCQdfggAT9ZuBI2gOAj+k0vOt11U5C/1w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f11ffb5c-cab4-4f78-80f7-4e2392757107",
                            TwoFactorEnabled = false,
                            UserName = "amostan@gmail.com"
                        },
                        new
                        {
                            Id = "5181efe8-31de-47f0-860f-e514d04102e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "df7e45ee-6bca-4594-94f1-eff2d73d0fb2",
                            Email = "davidlee@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "David",
                            LastName = "Lee",
                            LockoutEnabled = false,
                            NormalizedEmail = "DAVIDLEE@GMAIL.COM",
                            NormalizedUserName = "DAVIDLEE@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED5Idp2mGZizt3A7Yul3LOQp5ncSk4HbSRpKR7CDK/T2mVRkvcNYWABhkaW1N5rEtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ee37fab2-88db-47a7-b08b-3f40b76940c0",
                            TwoFactorEnabled = false,
                            UserName = "davidlee@gmail.com"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4168),
                            DateUpdated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4182),
                            Name = "Vanguard",
                            Type = "unknown",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4185),
                            DateUpdated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4186),
                            Name = "Pokemon",
                            Type = "unknown",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4187),
                            DateUpdated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4188),
                            Name = "Hololive",
                            Type = "WhoKnows",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4202),
                            DateUpdated = new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4202),
                            Name = "Others",
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

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Listing");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1,
                            CategoryId = 3,
                            CategoryName = "Hololive",
                            CreatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
                            DateCreated = new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4740),
                            DateUpdated = new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4760),
                            Description = "Suisei Oshi Card",
                            ListingId = 3,
                            Name = "Suisei OSR",
                            Price = 3.0,
                            UpdatedBy = "5181efe8-31de-47f0-860f-e514d04102e5",
                            UserId = 3,
                            UserName = "David Lee"
                        });
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuyerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Payment");
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

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Stars")
                        .HasColumnType("float");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Report", b =>
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Report");
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
                            NoRatings = 0,
                            RatingId = 3,
                            Stars = 0.0,
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Nil",
                            Contact = 889988124,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Name = "Amos",
                            NoRatings = 0,
                            RatingId = 4,
                            Stars = 0.0,
                            UserId = "4181efe7-66dc-47f0-860f-e506d04102e5"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Nil",
                            Contact = 889988125,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 3,
                            Name = "David",
                            NoRatings = 0,
                            RatingId = 5,
                            Stars = 0.0,
                            UserId = "5181efe8-31de-47f0-860f-e514d04102e5"
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

            modelBuilder.Entity("ProjectCardPark1.Domain.Listing", b =>
                {
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

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Payment", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.Listing", "Listing")
                        .WithOne("Payment")
                        .HasForeignKey("ProjectCardPark1.Domain.Payment", "ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectCardPark1.Domain.User", "User")
                        .WithOne("Payment")
                        .HasForeignKey("ProjectCardPark1.Domain.Payment", "UserId");

                    b.Navigation("Listing");

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

            modelBuilder.Entity("ProjectCardPark1.Domain.Report", b =>
                {
                    b.HasOne("ProjectCardPark1.Domain.Listing", "Listing")
                        .WithMany("Report")
                        .HasForeignKey("ListingId");

                    b.HasOne("ProjectCardPark1.Domain.User", "User")
                        .WithMany("Report")
                        .HasForeignKey("UserId");

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Category", b =>
                {
                    b.Navigation("Listing");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.Listing", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("Report");
                });

            modelBuilder.Entity("ProjectCardPark1.Domain.User", b =>
                {
                    b.Navigation("Listing");

                    b.Navigation("Payment");

                    b.Navigation("Rating");

                    b.Navigation("Report");
                });
#pragma warning restore 612, 618
        }
    }
}
