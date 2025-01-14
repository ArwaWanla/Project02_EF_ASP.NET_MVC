﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewcastleUniversity.Data;

namespace NewcastleUniversity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605193833_CreatingANDSeedingInstructorTable")]
    partial class CreatingANDSeedingInstructorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NewcastleUniversity.Models.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fee = 1000f,
                            Name = "Digital Economy"
                        },
                        new
                        {
                            Id = 2,
                            Fee = 1900f,
                            Name = "Foundation of Business Analysis"
                        },
                        new
                        {
                            Id = 3,
                            Fee = 2600f,
                            Name = "Game Design"
                        },
                        new
                        {
                            Id = 4,
                            Fee = 1800f,
                            Name = "Process Analysis"
                        });
                });

            modelBuilder.Entity("NewcastleUniversity.Models.InstructorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "david@uon.edu.au",
                            FullName = "David Jack",
                            PhoneNum = "243212",
                            password = "1258vvfdvdf"
                        },
                        new
                        {
                            Id = 2,
                            Email = "peter@uon.edu.au",
                            FullName = "Peter ",
                            PhoneNum = "245929",
                            password = "ghghgs556"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mark@uon.edu.au",
                            FullName = "Mark",
                            PhoneNum = "243956",
                            password = "1258vvfdvdf"
                        });
                });

            modelBuilder.Entity("NewcastleUniversity.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "arwa@uon.edu.au",
                            FullName = "Arwa Wan La",
                            password = "123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "rahaf@uon.edu.au",
                            FullName = "Rahaf Alqahtany",
                            password = "wee"
                        },
                        new
                        {
                            Id = 3,
                            Email = "rawabi@uon.edu.au",
                            FullName = "Rawabi Alshodukhy",
                            password = "qq1122ss"
                        },
                        new
                        {
                            Id = 4,
                            Email = "samerah@uon.edu.au",
                            FullName = "Samerah Alhusainy",
                            password = "ggg775"
                        },
                        new
                        {
                            Id = 5,
                            Email = "thuraya@uon.edu.au",
                            FullName = "Thuraya Alzahrany",
                            password = "ggd5223nnf"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
