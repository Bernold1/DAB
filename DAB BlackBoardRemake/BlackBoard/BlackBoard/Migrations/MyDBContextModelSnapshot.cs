﻿// <auto-generated />
using System;
using BlackBoard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlackBoard.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlackBoard.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignmentName")
                        .IsRequired();

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("Deadline");

                    b.Property<int>("RedoCounter");

                    b.HasKey("AssignmentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignment");

                    b.HasData(
                        new
                        {
                            AssignmentId = 1,
                            AssignmentName = "EF core",
                            CourseId = "DAB",
                            Deadline = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RedoCounter = 1
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ClassDateTime");

                    b.Property<string>("CourseName")
                        .IsRequired();

                    b.Property<int>("TeacherAuId");

                    b.HasKey("CourseId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = "DAB",
                            ClassDateTime = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseName = "Databases",
                            TeacherAuId = 1
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.CourseContent", b =>
                {
                    b.Property<string>("CourseContentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentName")
                        .IsRequired();

                    b.Property<string>("CourseId");

                    b.HasKey("CourseContentId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseContents");

                    b.HasData(
                        new
                        {
                            CourseContentId = "L1",
                            ContentName = "Intro",
                            CourseId = "DAB"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Enroll", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<int>("StudentAuId");

                    b.HasKey("CourseId", "StudentAuId");

                    b.HasIndex("StudentAuId");

                    b.ToTable("Enrolls");

                    b.HasData(
                        new
                        {
                            CourseId = "DAB",
                            StudentAuId = 350
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.GroupHandin", b =>
                {
                    b.Property<int>("GroupHandinId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentId");

                    b.Property<int>("GroupInfoId");

                    b.Property<int>("TeacherAuId");

                    b.HasKey("GroupHandinId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("GroupInfoId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("GroupHandins");

                    b.HasData(
                        new
                        {
                            GroupHandinId = 1,
                            AssignmentId = 1,
                            GroupInfoId = 1,
                            TeacherAuId = 1
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupSize");

                    b.Property<int>("StudentAuId");

                    b.Property<int?>("TeacherAuId");

                    b.HasKey("GroupInfoId");

                    b.HasIndex("StudentAuId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("GroupsInfo");

                    b.HasData(
                        new
                        {
                            GroupInfoId = 1,
                            GroupSize = 3,
                            StudentAuId = 350
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Student", b =>
                {
                    b.Property<int>("StudentAuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnrolledDate");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<double>("Grade");

                    b.Property<DateTime>("GradulationDate");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("StudentAuId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentAuId = 350,
                            EnrolledDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Chris",
                            Grade = 8.3000000000000007,
                            GradulationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Bernold"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherAuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsAssistant");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("TeacherAuId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherAuId = 1,
                            Birthday = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lars",
                            IsAssistant = false,
                            LastName = "Jensen"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Assignment", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("BlackBoard.Models.Course", b =>
                {
                    b.HasOne("BlackBoard.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherAuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlackBoard.Models.CourseContent", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("CourseContents")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("BlackBoard.Models.Enroll", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("Enrolls")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlackBoard.Models.Student", "Student")
                        .WithMany("Enrolls")
                        .HasForeignKey("StudentAuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlackBoard.Models.GroupHandin", b =>
                {
                    b.HasOne("BlackBoard.Models.Assignment", "Assignment")
                        .WithMany("GroupHandins")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlackBoard.Models.GroupInfo", "GroupInfo")
                        .WithMany("GroupHandins")
                        .HasForeignKey("GroupInfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlackBoard.Models.Teacher", "Teacher")
                        .WithMany("GroupHandins")
                        .HasForeignKey("TeacherAuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlackBoard.Models.GroupInfo", b =>
                {
                    b.HasOne("BlackBoard.Models.Student", "Student")
                        .WithMany("GroupInfos")
                        .HasForeignKey("StudentAuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlackBoard.Models.Teacher", "Teacher")
                        .WithMany("GroupInfos")
                        .HasForeignKey("TeacherAuId");
                });
#pragma warning restore 612, 618
        }
    }
}
