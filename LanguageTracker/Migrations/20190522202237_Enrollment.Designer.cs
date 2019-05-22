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
    [Migration("20190522202237_Enrollment")]
    partial class Enrollment
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

            modelBuilder.Entity("LanguageTracker.Models.Class", b =>
                {
                    b.Property<string>("ClassID")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("InstructorName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ItemNumber");

                    b.Property<string>("YearQuarterID")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ClassID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("LanguageTracker.Models.Enrollment", b =>
                {
                    b.Property<string>("SID")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("ClassID")
                        .HasColumnType("varchar(4)");

                    b.Property<string>("YearQuarterID")
                        .HasColumnType("varchar(4)");

                    b.HasKey("SID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("LanguageTracker.Models.Student", b =>
                {
                    b.Property<string>("SID")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(22)");

                    b.HasKey("SID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}