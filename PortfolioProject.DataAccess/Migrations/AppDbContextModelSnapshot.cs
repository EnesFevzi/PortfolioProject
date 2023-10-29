﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioProject.DataAccess.Context;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PortfolioProject.Entity.Entities.About", b =>
                {
                    b.Property<Guid>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.HasIndex("ImageID");

                    b.HasIndex("UserID");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            AboutID = new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                            Address = "Çorlu/TEKİRDAĞ",
                            Age = 25,
                            CreatedBy = "Enes Fevzi",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5169),
                            DeletedBy = "Enes Fevzi",
                            Description = "Üniversite eğitimim sırasında yazılım alanına olan ilgim, aldığım yazılım dersleriyle başladı. Bu süre zarfında, kendimi sürekli olarak geliştirmek ve yeni beceriler kazanmak için Türkiye'nin önde gelen teknoloji yarışmalarına katıldım ve bir dizi derece elde ettim. Mezuniyetimin ardından, Bilge Adam Akademi'nin Boost Yıldız Yazılımcı Yetiştirme programına katıldım.",
                            ImageID = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            IsDeleted = false,
                            Mail = "enesfevzicicekli@gmail.com",
                            ModifiedBy = "Enes Fevzi",
                            Title = "Junıor Software Developer",
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            Website = "enesfevzicicekli.com.tr"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                            ConcurrencyStamp = "b8376b1b-0277-4264-b6a7-50a15db13fcb",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                            ConcurrencyStamp = "af4ab029-af7b-4f60-bc35-3969c3dfa1d6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
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

                    b.HasIndex("ImageID");

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
                            Id = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "736fc84a-f4dc-4c23-9828-f9daa9681034",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Cem",
                            ImageID = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            LastName = "Keskin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFctqzMsiQfnA9nsEvnsDsdVB6EDoknF8k5VZnM0K84isu4o2q40uYiulzSaTs4I3Q==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "3de13840-2c19-4190-a08b-ad2f4b24d48c",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "939eb743-c55b-4372-9905-08d4ea52fdda",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageID = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENXr1uNuzAeg+MVjmrvpYXxAhGJAM5L+Wdemq+ejg2VrDhT6l6JIG6fCKTE+yUlN+w==",
                            PhoneNumber = "+905439999988",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "43b0a1d4-3623-4640-8330-67d7560af70d",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            RoleId = new Guid("343f8370-28d4-4ade-91df-7965041b98f1")
                        },
                        new
                        {
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            RoleId = new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d")
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Education", b =>
                {
                    b.Property<Guid>("EducationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EducationID");

                    b.HasIndex("UserID");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            EducationID = new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                            Content = "Mekatronik Mühendisliği bölümünü 3.22 akademik ortalama ile bitirdim.",
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5911),
                            DeletedBy = "Enes Fevzi",
                            EndTime = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Name = "Pamukkale Üniversitesi",
                            StartTime = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        },
                        new
                        {
                            EducationID = new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                            Content = "Elektrik-Elektronik Teknolojisi Bölümünü Okul Birinciliği ile tamamladım.",
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5914),
                            DeletedBy = "Enes Fevzi",
                            EndTime = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Name = "Mehmet Rüştü Uzel Mesleki ve Teknik Anadolu Lisesi",
                            StartTime = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Experience", b =>
                {
                    b.Property<Guid>("ExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExperienceID");

                    b.HasIndex("UserID");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            ExperienceID = new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                            Content = "Son teknolojiyle entegre edilmiş eğitim içeriği ve gerçek dünya uygulamaları ve\r\nsimülasyonlarını bir araya getiren, 8 ay süren yazılımcı yetiştirme programıdır.",
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5984),
                            DeletedBy = "Enes Fevzi",
                            EndTime = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Name = "Bilge Adam Boost Yıldız Yazılımcı Yetiştirme Programı",
                            StartTime = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        },
                        new
                        {
                            ExperienceID = new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                            Content = "Mekatronik Mühendisi olarak çalıştığım Brülör Teknik Servis Şirketi",
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5988),
                            DeletedBy = "Enes Fevzi",
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Name = "Eren Brulor",
                            StartTime = new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c")
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageID = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(6051),
                            DeletedBy = "Enes Fevzi",
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi"
                        },
                        new
                        {
                            ImageID = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(6053),
                            DeletedBy = "Enes Fevzi",
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Message", b =>
                {
                    b.Property<Guid>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Portfolio", b =>
                {
                    b.Property<Guid>("PortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PortfolioID");

                    b.HasIndex("ImageID");

                    b.HasIndex("UserID");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Skill", b =>
                {
                    b.Property<Guid>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("SkillID");

                    b.HasIndex("UserID");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillID = new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(8721),
                            DeletedBy = "Enes Fevzi",
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Title = "C#",
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            Value = 90
                        },
                        new
                        {
                            SkillID = new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                            CreatedBy = "SuperAdmin",
                            CreatedDate = new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(8726),
                            DeletedBy = "Enes Fevzi",
                            IsDeleted = false,
                            ModifiedBy = "Enes Fevzi",
                            Title = "Microsoft SQL Server",
                            UserID = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            Value = 90
                        });
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaID"), 1L, 1);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GitHub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stackoverflow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaID");

                    b.HasIndex("AppUserId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.About", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.Image", "Image")
                        .WithMany("Abouts")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", "User")
                        .WithMany("Abouts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Education", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Experience", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Portfolio", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");

                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Skill", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.SocialMedia", b =>
                {
                    b.HasOne("PortfolioProject.Entity.Entities.AppUser", null)
                        .WithMany("SocialMedias")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Abouts");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Projects");

                    b.Navigation("Skills");

                    b.Navigation("SocialMedias");
                });

            modelBuilder.Entity("PortfolioProject.Entity.Entities.Image", b =>
                {
                    b.Navigation("Abouts");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
