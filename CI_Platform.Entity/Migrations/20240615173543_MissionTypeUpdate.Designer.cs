﻿// <auto-generated />
using System;
using CI_Platform.Entity.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CI_Platform.Entity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240615173543_MissionTypeUpdate")]
    partial class MissionTypeUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CI_Platform.Entity.Admin", b =>
                {
                    b.Property<long>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("AdminId"));

                    b.Property<string>("AdminAvatar")
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("LastName")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("CI_Platform.Entity.CMSPrivacyPolicy", b =>
                {
                    b.Property<long>("CMSId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CMSId"));

                    b.Property<string>("PageDescription")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("CMSId");

                    b.ToTable("CMSPrivacyPolicy");
                });

            modelBuilder.Entity("CI_Platform.Entity.City", b =>
                {
                    b.Property<long>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("City");

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("CI_Platform.Entity.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CommentId"));

                    b.Property<string>("CommentContent")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("Comment");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MissionTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("CI_Platform.Entity.Country", b =>
                {
                    b.Property<long>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("CI_Platform.Entity.LoginCarousel", b =>
                {
                    b.Property<int>("CarouselId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CarouselId"));

                    b.Property<string>("CarouselHead")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte[]>("CarouselImage")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("CarouselText")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("CarouselId");

                    b.ToTable("LoginCarousel");
                });

            modelBuilder.Entity("CI_Platform.Entity.Mission", b =>
                {
                    b.Property<long>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("MissionId"));

                    b.Property<int>("AchievedGoal")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<long>("CityId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<long>("CountryId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MissionAvailability")
                        .HasColumnType("integer");

                    b.Property<string>("MissionDescription")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<DateOnly>("MissionEndDate")
                        .HasColumnType("date");

                    b.Property<string>("MissionOrganisationDetail")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<string>("MissionOrganisationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("MissionRating")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int?>("MissionRatingCount")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<DateOnly>("MissionRegistrationDeadline")
                        .HasColumnType("date");

                    b.Property<string>("MissionShortDescription")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateOnly>("MissionStartDate")
                        .HasColumnType("date");

                    b.Property<string>("MissionTitle")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int>("MissionType")
                        .HasMaxLength(50)
                        .HasColumnType("integer");

                    b.Property<byte[]>("MissionVideo")
                        .HasColumnType("bytea");

                    b.Property<int>("OccupiedSeats")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("ThemeId")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<int>("TotalGoal")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<int>("TotalSeats")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("MissionId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("ThemeId");

                    b.ToTable("Mission");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionApplication", b =>
                {
                    b.Property<long>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ApplicationId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("ApplicationId");

                    b.HasIndex("MissionId");

                    b.HasIndex("UserId");

                    b.ToTable("MissionApplication");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionMedia", b =>
                {
                    b.Property<long>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("MediaId"));

                    b.Property<byte[]>("Document")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("Image")
                        .HasColumnType("bytea");

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.HasKey("MediaId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionMedia");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionSkill", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MissionId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<int>("SkillId")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.HasIndex("SkillId");

                    b.ToTable("MissionSkills");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionType");
                });

            modelBuilder.Entity("CI_Platform.Entity.RecentVolunteer", b =>
                {
                    b.Property<long>("VolunteerId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("VolunteerId"));

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("VolunteerId");

                    b.HasIndex("MissionId");

                    b.HasIndex("UserId");

                    b.ToTable("RecentVolunteer");
                });

            modelBuilder.Entity("CI_Platform.Entity.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillId"));

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("SkillId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("CI_Platform.Entity.Story", b =>
                {
                    b.Property<long>("StoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("StoryId"));

                    b.Property<string>("MissionTitle")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("StoryDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("StoryTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("StoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Story");
                });

            modelBuilder.Entity("CI_Platform.Entity.StoryMedia", b =>
                {
                    b.Property<long>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("MediaId"));

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.HasKey("MediaId");

                    b.HasIndex("MissionId");

                    b.ToTable("StoryMedia");
                });

            modelBuilder.Entity("CI_Platform.Entity.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ThemeId"));

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Theme");

                    b.HasKey("ThemeId");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("CI_Platform.Entity.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserId"));

                    b.Property<string>("Avatar")
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<long?>("CityId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<long?>("CountryId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Department")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("EmployeeId")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("LastName")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("LinkedInUrl")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<string>("ProfileText")
                        .HasColumnType("text");

                    b.Property<string>("Skills")
                        .HasColumnType("text");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("WhyIVolunteer")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.UserMission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Favourite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Ratings")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<int>("UserStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMissions");
                });

            modelBuilder.Entity("CI_Platform.Entity.VolunteeringTimesheet", b =>
                {
                    b.Property<long>("VolunteeringId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("VolunteeringId"));

                    b.Property<int>("Action")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Hours")
                        .HasColumnType("interval");

                    b.Property<TimeSpan>("Minutes")
                        .HasColumnType("interval");

                    b.Property<long>("MissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("MissionTitle")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("VolunteeringId");

                    b.HasIndex("MissionId");

                    b.ToTable("VolunteeringTimesheet");
                });

            modelBuilder.Entity("CI_Platform.Entity.City", b =>
                {
                    b.HasOne("CI_Platform.Entity.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CI_Platform.Entity.Comment", b =>
                {
                    b.HasOne("CI_Platform.Entity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.Mission", b =>
                {
                    b.HasOne("CI_Platform.Entity.City", "City")
                        .WithMany("Missions")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.Country", "Country")
                        .WithMany("Missions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.Theme", "Theme")
                        .WithMany("Missions")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionApplication", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("MissionApplications")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.User", "User")
                        .WithMany("MissionApplications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionMedia", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("MissionMedias")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionSkill", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("MissionSkills")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.Skill", "Skill")
                        .WithMany("MissionSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("CI_Platform.Entity.MissionType", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("MissionTypes")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("CI_Platform.Entity.RecentVolunteer", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("RecentVolunteers")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.User", "User")
                        .WithMany("RecentVolunteers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.Story", b =>
                {
                    b.HasOne("CI_Platform.Entity.User", "User")
                        .WithMany("Stories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.StoryMedia", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("StoryMedia")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("CI_Platform.Entity.User", b =>
                {
                    b.HasOne("CI_Platform.Entity.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");

                    b.HasOne("CI_Platform.Entity.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId");

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CI_Platform.Entity.UserMission", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("UserMissions")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CI_Platform.Entity.User", "User")
                        .WithMany("UserMissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CI_Platform.Entity.VolunteeringTimesheet", b =>
                {
                    b.HasOne("CI_Platform.Entity.Mission", "Mission")
                        .WithMany("VolunteeringTimesheets")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("CI_Platform.Entity.City", b =>
                {
                    b.Navigation("Missions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CI_Platform.Entity.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Missions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CI_Platform.Entity.Mission", b =>
                {
                    b.Navigation("MissionApplications");

                    b.Navigation("MissionMedias");

                    b.Navigation("MissionSkills");

                    b.Navigation("MissionTypes");

                    b.Navigation("RecentVolunteers");

                    b.Navigation("StoryMedia");

                    b.Navigation("UserMissions");

                    b.Navigation("VolunteeringTimesheets");
                });

            modelBuilder.Entity("CI_Platform.Entity.Skill", b =>
                {
                    b.Navigation("MissionSkills");
                });

            modelBuilder.Entity("CI_Platform.Entity.Theme", b =>
                {
                    b.Navigation("Missions");
                });

            modelBuilder.Entity("CI_Platform.Entity.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("MissionApplications");

                    b.Navigation("RecentVolunteers");

                    b.Navigation("Stories");

                    b.Navigation("UserMissions");
                });
#pragma warning restore 612, 618
        }
    }
}
