﻿// <auto-generated />
using System;
using LanguageTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LanguageTracker.Migrations
{
    [DbContext(typeof(LanguageTrackerContext))]
    [Migration("20190611054705_ACTFL")]
    partial class ACTFL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LanguageTracker.Controllers.Instructors", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.HasKey("id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("LanguageTracker.Controllers.LabActivities", b =>
                {
                    b.Property<int>("sid");

                    b.Property<string>("activity");

                    b.Property<DateTime>("date");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.Property<string>("staff_levels");

                    b.HasKey("sid");

                    b.ToTable("LabActivities");
                });

            modelBuilder.Entity("LanguageTracker.Controllers.LabHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("instructors");

                    b.Property<int>("sid");

                    b.Property<int>("total_days");

                    b.Property<DateTime>("total_hours");

                    b.HasKey("Id");

                    b.ToTable("LabHours");
                });

            modelBuilder.Entity("LanguageTracker.Controllers.Students", b =>
                {
                    b.Property<int>("sid");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.HasKey("sid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LanguageTracker.Models.ACTFL", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemNumber");

                    b.Property<string>("Language");

                    b.Property<string>("Listening");

                    b.Property<string>("Reading");

                    b.Property<string>("SID");

                    b.Property<string>("Speaking");

                    b.Property<string>("Writing");

                    b.Property<string>("YearQuarterID");

                    b.HasKey("ID");

                    b.HasIndex("SID");

                    b.ToTable("ACTFL");
                });

            modelBuilder.Entity("LanguageTracker.Models.Class", b =>
                {
                    b.Property<string>("ClassID")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("InstructorName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ItemNumber")
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("YearQuarterID")
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("ClassID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("LanguageTracker.Models.Enrollment", b =>
                {
                    b.Property<string>("SID")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("ClassID")
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("YearQuarterID")
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("SID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("LanguageTracker.Models.Student", b =>
                {
                    b.Property<string>("SID")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(22)");

                    b.HasKey("SID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("LanguageTracker.Models.ACTFL", b =>
                {
                    b.HasOne("LanguageTracker.Models.Enrollment", "S")
                        .WithMany()
                        .HasForeignKey("SID");
                });
#pragma warning restore 612, 618
        }
    }
}