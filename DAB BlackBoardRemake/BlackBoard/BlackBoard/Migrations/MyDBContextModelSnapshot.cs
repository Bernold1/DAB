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
                        },
                        new
                        {
                            AssignmentId = 2,
                            AssignmentName = "TCP",
                            CourseId = "IKN",
                            Deadline = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RedoCounter = 2
                        },
                        new
                        {
                            AssignmentId = 3,
                            AssignmentName = "Mutexes",
                            CourseId = "ISU",
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

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = "DAB",
                            ClassDateTime = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseName = "Databases"
                        },
                        new
                        {
                            CourseId = "IKN",
                            ClassDateTime = new DateTime(2016, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseName = "Network communication"
                        },
                        new
                        {
                            CourseId = "ISU",
                            ClassDateTime = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseName = "Embedded software development"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.CourseContent", b =>
                {
                    b.Property<int>("CourseContentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentName")
                        .IsRequired();

                    b.Property<string>("CourseId");

                    b.HasKey("CourseContentId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseContents");

                    b.HasData(
                        new
                        {
                            CourseContentId = 1,
                            ContentName = "Intro",
                            CourseId = "DAB"
                        },
                        new
                        {
                            CourseContentId = 2,
                            ContentName = "EF core",
                            CourseId = "DAB"
                        },
                        new
                        {
                            CourseContentId = 3,
                            ContentName = "Intro",
                            CourseId = "IKN"
                        },
                        new
                        {
                            CourseContentId = 4,
                            ContentName = "HTTP",
                            CourseId = "IKN"
                        },
                        new
                        {
                            CourseContentId = 5,
                            ContentName = "Intro",
                            CourseId = "ISU"
                        },
                        new
                        {
                            CourseContentId = 6,
                            ContentName = "Threads",
                            CourseId = "ISU"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.CourseManagement", b =>
                {
                    b.Property<int>("CourseManagementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CouseId");

                    b.Property<int>("TeacherAuId");

                    b.HasKey("CourseManagementId");

                    b.HasIndex("CouseId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("CourseManagement");

                    b.HasData(
                        new
                        {
                            CourseManagementId = 1,
                            CouseId = "IKN",
                            TeacherAuId = 1
                        },
                        new
                        {
                            CourseManagementId = 2,
                            CouseId = "IKN",
                            TeacherAuId = 3
                        },
                        new
                        {
                            CourseManagementId = 3,
                            CouseId = "ISU",
                            TeacherAuId = 1
                        },
                        new
                        {
                            CourseManagementId = 4,
                            CouseId = "DAB",
                            TeacherAuId = 10
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Enroll", b =>
                {
                    b.Property<int>("EnrollId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseId");

                    b.Property<int>("StudentAuId");

                    b.HasKey("EnrollId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentAuId");

                    b.ToTable("Enrolls");

                    b.HasData(
                        new
                        {
                            EnrollId = 1,
                            CourseId = "DAB",
                            StudentAuId = 350
                        },
                        new
                        {
                            EnrollId = 2,
                            CourseId = "DAB",
                            StudentAuId = 330
                        },
                        new
                        {
                            EnrollId = 3,
                            CourseId = "DAB",
                            StudentAuId = 320
                        },
                        new
                        {
                            EnrollId = 4,
                            CourseId = "DAB",
                            StudentAuId = 340
                        },
                        new
                        {
                            EnrollId = 5,
                            CourseId = "IKN",
                            StudentAuId = 350
                        },
                        new
                        {
                            EnrollId = 6,
                            CourseId = "IKN",
                            StudentAuId = 330
                        },
                        new
                        {
                            EnrollId = 7,
                            CourseId = "IKN",
                            StudentAuId = 320
                        },
                        new
                        {
                            EnrollId = 8,
                            CourseId = "IKN",
                            StudentAuId = 340
                        },
                        new
                        {
                            EnrollId = 9,
                            CourseId = "ISU",
                            StudentAuId = 360
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("GroupId");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupId = 1
                        },
                        new
                        {
                            GroupId = 5
                        },
                        new
                        {
                            GroupId = 6
                        },
                        new
                        {
                            GroupId = 7
                        },
                        new
                        {
                            GroupId = 8
                        },
                        new
                        {
                            GroupId = 9
                        },
                        new
                        {
                            GroupId = 10
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.GroupHandin", b =>
                {
                    b.Property<int>("GroupHandinId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentId");

                    b.Property<double>("Grade");

                    b.Property<int>("GroupId");

                    b.Property<int>("TeacherAuId");

                    b.HasKey("GroupHandinId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("GroupId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("GroupHandins");

                    b.HasData(
                        new
                        {
                            GroupHandinId = 1,
                            AssignmentId = 1,
                            Grade = 12.0,
                            GroupId = 1,
                            TeacherAuId = 1
                        },
                        new
                        {
                            GroupHandinId = 2,
                            AssignmentId = 1,
                            Grade = 4.0,
                            GroupId = 9,
                            TeacherAuId = 10
                        },
                        new
                        {
                            GroupHandinId = 3,
                            AssignmentId = 1,
                            Grade = 2.0,
                            GroupId = 10,
                            TeacherAuId = 3
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<int>("GroupSize");

                    b.Property<int>("StudentAuId");

                    b.Property<int?>("TeacherAuId");

                    b.HasKey("GroupInfoId");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentAuId");

                    b.HasIndex("TeacherAuId");

                    b.ToTable("GroupsInfo");

                    b.HasData(
                        new
                        {
                            GroupInfoId = 1,
                            GroupId = 1,
                            GroupSize = 3,
                            StudentAuId = 350
                        },
                        new
                        {
                            GroupInfoId = 2,
                            GroupId = 1,
                            GroupSize = 3,
                            StudentAuId = 330
                        },
                        new
                        {
                            GroupInfoId = 3,
                            GroupId = 1,
                            GroupSize = 3,
                            StudentAuId = 320
                        },
                        new
                        {
                            GroupInfoId = 4,
                            GroupId = 9,
                            GroupSize = 1,
                            StudentAuId = 360
                        },
                        new
                        {
                            GroupInfoId = 5,
                            GroupId = 10,
                            GroupSize = 1,
                            StudentAuId = 340
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

                    b.Property<bool>("isActive");

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
                            LastName = "Bernold",
                            isActive = false
                        },
                        new
                        {
                            StudentAuId = 320,
                            EnrolledDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mads",
                            Grade = 8.3000000000000007,
                            GradulationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Bjerg",
                            isActive = false
                        },
                        new
                        {
                            StudentAuId = 330,
                            EnrolledDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Harold",
                            Grade = 8.3000000000000007,
                            GradulationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nyborg",
                            isActive = false
                        },
                        new
                        {
                            StudentAuId = 340,
                            EnrolledDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jens",
                            Grade = 8.3000000000000007,
                            GradulationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Flix",
                            isActive = false
                        },
                        new
                        {
                            StudentAuId = 360,
                            EnrolledDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bill",
                            Grade = 8.3000000000000007,
                            GradulationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ka",
                            isActive = false
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
                        },
                        new
                        {
                            TeacherAuId = 3,
                            Birthday = new DateTime(1980, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Karen",
                            IsAssistant = false,
                            LastName = "Blixen"
                        },
                        new
                        {
                            TeacherAuId = 10,
                            Birthday = new DateTime(1960, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Thomas",
                            IsAssistant = false,
                            LastName = "Rasmussen"
                        });
                });

            modelBuilder.Entity("BlackBoard.Models.Assignment", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("BlackBoard.Models.CourseContent", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("CourseContents")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("BlackBoard.Models.CourseManagement", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("CourseManagements")
                        .HasForeignKey("CouseId");

                    b.HasOne("BlackBoard.Models.Teacher", "Teacher")
                        .WithMany("CourseManagements")
                        .HasForeignKey("TeacherAuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlackBoard.Models.Enroll", b =>
                {
                    b.HasOne("BlackBoard.Models.Course", "Course")
                        .WithMany("Enrolls")
                        .HasForeignKey("CourseId");

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

                    b.HasOne("BlackBoard.Models.Group", "Group")
                        .WithMany("GroupHandins")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlackBoard.Models.Teacher", "Teacher")
                        .WithMany("GroupHandins")
                        .HasForeignKey("TeacherAuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlackBoard.Models.GroupInfo", b =>
                {
                    b.HasOne("BlackBoard.Models.Group", "Group")
                        .WithMany("GroupInfos")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

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
