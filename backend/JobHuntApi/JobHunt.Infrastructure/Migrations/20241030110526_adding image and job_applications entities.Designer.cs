﻿// <auto-generated />
using System;
using JobHunt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobHunt.Infrastructure.Migrations
{
    [DbContext(typeof(JobHuntDbContext))]
    [Migration("20241030110526_adding image and job_applications entities")]
    partial class addingimageandjob_applicationsentities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JobHunt.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("76e24589-638c-4cb9-9970-675a263a7a43"),
                            City = "New York",
                            Country = "USA ",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Street = "street address 1",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("position");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<string>("Responsibility")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("responsibility");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("WorkFrom")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("work_from");

                    b.Property<DateTime>("WorkTo")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("work_to");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("experiences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b57bd5ce-3717-4dbc-8174-cbbeb4f202cc"),
                            CompanyName = "CompanyName",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location",
                            Position = "Position",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Responsibility = "Responsibility",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkFrom = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5064),
                            WorkTo = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5067)
                        },
                        new
                        {
                            Id = new Guid("d936f619-4c27-4f28-b779-0d97eba172c5"),
                            CompanyName = "CompanyName 2",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 2",
                            Position = "Position 2",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Responsibility = "Responsibility 2",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkFrom = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074),
                            WorkTo = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5074)
                        },
                        new
                        {
                            Id = new Guid("32304f51-ce60-40d9-9231-31ce88262bce"),
                            CompanyName = "CompanyName 3",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Location 3",
                            Position = "Position 3",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Responsibility = "Responsibility 3",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkFrom = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079),
                            WorkTo = new DateTime(2024, 10, 30, 11, 5, 26, 368, DateTimeKind.Utc).AddTicks(5079)
                        });
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("JobId")
                        .IsUnique();

                    b.ToTable("images", (string)null);
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("address_id");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("contract_type");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("JobLevel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("job_level");

                    b.Property<string>("OperationMode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("operation_mode");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("requirements");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("responsibilities");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("technology");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("Title", "JobLevel", "Technology", "Type")
                        .HasAnnotation("Npgsql:TsVectorConfig", "english");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Title", "JobLevel", "Technology", "Type"), "GIN");

                    b.ToTable("jobs", (string)null);
                });

            modelBuilder.Entity("JobHunt.Domain.Models.JobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AboutInformation")
                        .HasColumnType("text")
                        .HasColumnName("about_information");

                    b.Property<string>("Cv")
                        .HasColumnType("text")
                        .HasColumnName("cv");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uuid")
                        .HasColumnName("job_id");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("job_applications", (string)null);
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("address_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("createdBy");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("profiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            AddressId = new Guid("76e24589-638c-4cb9-9970-675a263a7a43"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "user",
                            DateOfBirth = new DateTime(2024, 10, 30, 11, 5, 26, 371, DateTimeKind.Utc).AddTicks(9008),
                            Email = "john@doe.com",
                            Lastname = "Doe",
                            Name = "John ",
                            Phone = "123456789",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("JobHunt.Domain.Models.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("education_level");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("field_of_study");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid")
                        .HasColumnName("profile_id");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("specialization");

                    b.Property<DateTime>("StudyFrom")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("study_from");

                    b.Property<DateTime>("StudyTo")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("study_to");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("university_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("universities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2483782-a4a6-44be-b94b-e269027891e0"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EducationLevel = "Bachelor",
                            FieldOfStudy = "Field of Study",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Specialization = "Computer Science",
                            StudyFrom = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4376),
                            StudyTo = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4378),
                            UniversityName = "Vistula",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("2fe4d5ce-6bcd-4443-9577-fe041b3a1b2a"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EducationLevel = "Bachelor 2",
                            FieldOfStudy = "Field of Study 2",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Specialization = "Computer Science 2",
                            StudyFrom = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4386),
                            StudyTo = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4387),
                            UniversityName = "Vistula 2",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("6e6cdb3e-b4d5-41ad-94ed-03e280d520dd"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EducationLevel = "Bachelor 3",
                            FieldOfStudy = "Field of Study 3",
                            ProfileId = new Guid("a51bd4f1-8501-405e-a634-bdb1d8bd8511"),
                            Specialization = "Computer Science 3",
                            StudyFrom = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4391),
                            StudyTo = new DateTime(2024, 10, 30, 11, 5, 26, 372, DateTimeKind.Utc).AddTicks(4392),
                            UniversityName = "Vistula 3",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("JobHunt.Infrastructure.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Employer",
                            NormalizedName = "EMPLOYER"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Experience", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Profile", null)
                        .WithMany("Experiences")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Image", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Job", null)
                        .WithOne("Image")
                        .HasForeignKey("JobHunt.Domain.Models.Image", "JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Job", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("JobHunt.Domain.Models.Job", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("JobHunt.Domain.Models.JobApplication", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Job", null)
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Profile", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("JobHunt.Domain.Models.Profile", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("JobHunt.Domain.Models.University", b =>
                {
                    b.HasOne("JobHunt.Domain.Models.Profile", null)
                        .WithMany("Universities")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Job", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("JobHunt.Domain.Models.Profile", b =>
                {
                    b.Navigation("Experiences");

                    b.Navigation("Universities");
                });
#pragma warning restore 612, 618
        }
    }
}
