using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackBoard.Data
{
    public class MyDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<GroupInfo> GroupsInfo { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupHandin> GroupHandins { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignment { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Student
            //Primary key definition
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentAuId);
            //Specifying required properties
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .IsRequired();
            //Data seeding Student
            modelBuilder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        StudentAuId = 350,
                        EnrolledDate = new DateTime(2016, 1, 1),
                        FirstName = "Chris",
                        LastName = "Bernold",
                        Grade = 8.3,
                        GradulationDate = new DateTime(2020, 1, 1)
                    },
                    new Student
                        {
                        StudentAuId = 320,
                        EnrolledDate = new DateTime(2016, 1, 1),
                        FirstName = "Mads",
                        LastName = "Bjerg",
                        Grade = 8.3,
                        GradulationDate = new DateTime(2020, 1, 1),
                    },
                    new Student
                    {
                        StudentAuId = 330,
                        EnrolledDate = new DateTime(2016, 1, 1),
                        FirstName = "Harold",
                        LastName = "Nyborg",
                        Grade = 8.3,
                        GradulationDate = new DateTime(2020, 1, 1),
                    },
                    new Student
                    {
                        StudentAuId = 340,
                        EnrolledDate = new DateTime(2016, 1, 1),
                        FirstName = "Jens",
                        LastName = "Flix",
                        Grade = 8.3,
                        GradulationDate = new DateTime(2020, 1, 1),
                    },
                    new Student
                    {
                        StudentAuId = 360,
                        EnrolledDate = new DateTime(2016, 1, 1),
                        FirstName = "Bill",
                        LastName = "Ka",
                        Grade = 8.3,
                        GradulationDate = new DateTime(2020, 1, 1),
                    }
                    );

            //Enroll
            //Relationships
            modelBuilder.Entity<Enroll>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrolls)
                .HasForeignKey(e => e.CourseId);
            modelBuilder.Entity<Enroll>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrolls)
                .HasForeignKey(e => e.StudentAuId);
            //Teacher    
            //Primary key definition
            modelBuilder.Entity<Teacher>()
                .HasKey(s => s.TeacherAuId);
            //Required properties
            modelBuilder.Entity<Teacher>()
                .Property(t => t.FirstName)
                .IsRequired();
            modelBuilder.Entity<Teacher>()
                .Property(t => t.LastName)
                .IsRequired();
            modelBuilder.Entity<Teacher>()
                .Property(t => t.IsAssistant)
                .IsRequired();
            //Data seeding Teacher
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherAuId = 1,
                    FirstName = "Lars",
                    LastName = "Jensen",
                    IsAssistant = false,
                    Birthday = new DateTime(1980, 1, 1)
                },
                new Teacher
                {
                    TeacherAuId = 3,
                    FirstName = "Karen",
                    LastName = "Blixen",
                    IsAssistant = false,
                    Birthday = new DateTime(1980, 2, 20)
                },
                new Teacher
                {
                    TeacherAuId = 10,
                    FirstName = "Thomas",
                    LastName = "Rasmussen",
                    IsAssistant = false,
                    Birthday = new DateTime(1960, 1, 20)
                });

            //Group data seeding
            modelBuilder.Entity<Group>().HasData(
            new Group { GroupId = 1 },
            new Group { GroupId = 5 },
            new Group { GroupId = 6 },
            new Group { GroupId = 7 },
            new Group { GroupId = 8 },
            new Group { GroupId = 9 },
            new Group { GroupId = 10 }

                );

            //GroupInfo
            modelBuilder.Entity<GroupInfo>()
                .Property(gi => gi.GroupSize)
                .IsRequired();
            modelBuilder.Entity<GroupInfo>()
                .HasOne(gi => gi.Group)
                .WithMany(g => g.GroupInfos)
                .HasForeignKey(gi => gi.GroupId);
            //Relationships
            modelBuilder.Entity<GroupInfo>()
                .HasOne(gi => gi.Student)
                .WithMany(s => s.GroupInfos)
                .HasForeignKey(gi => gi.StudentAuId);
            modelBuilder.Entity<GroupInfo>()
                .HasOne(gi => gi.Teacher)
                .WithMany(t => t.GroupInfos);
            //Data seeding groupinfo
            modelBuilder.Entity<GroupInfo>()
                .HasData(
                    new GroupInfo() { GroupInfoId = 1, GroupId = 1, GroupSize = 3, StudentAuId = 350 },
                    new GroupInfo() { GroupInfoId = 2, GroupId = 1, GroupSize = 3, StudentAuId = 330 },
                    new GroupInfo() { GroupInfoId = 3, GroupId = 1, GroupSize = 3, StudentAuId = 320 },
                    new GroupInfo() { GroupInfoId = 4, GroupId = 9, GroupSize = 1, StudentAuId = 360 },
                    new GroupInfo() { GroupInfoId = 5, GroupId = 10, GroupSize = 1, StudentAuId = 340 });

            //GroupHandin
            //Relationships
            modelBuilder.Entity<GroupHandin>()
                .HasOne(gh => gh.Assignment)
                .WithMany(a => a.GroupHandins)
                .HasForeignKey(gh => gh.AssignmentId);
            modelBuilder.Entity<GroupHandin>()
                .HasOne(gh => gh.Teacher)
                .WithMany(t => t.GroupHandins)
                .HasForeignKey(gh => gh.TeacherAuId);
            modelBuilder.Entity<GroupHandin>()
                .HasOne<Group>(gh => gh.Group)
                .WithMany(g => g.GroupHandins)
                .HasForeignKey(gh => gh.GroupId);
            //Data seeding GroupHandin
            modelBuilder.Entity<GroupHandin>()
                .HasData(
                    new GroupHandin() { GroupHandinId = 1, AssignmentId = 1, GroupId = 1, TeacherAuId = 1, Grade = 12 },
                    new GroupHandin() { GroupHandinId = 2, AssignmentId = 1, GroupId = 9, TeacherAuId = 10, Grade = 4 },
                    new GroupHandin() { GroupHandinId = 3, AssignmentId = 1, GroupId = 10, TeacherAuId = 3, Grade = 2 }
                    );
            //Course
            modelBuilder.Entity<Course>()
                .Property(c => c.CourseName)
                .IsRequired();
            //Data seeding Course
            modelBuilder.Entity<Course>()
                .HasData(
                    new Course { CourseId = "DAB", CourseName = "Databases", ClassDateTime = new DateTime(2016, 1, 1)},
                    new Course { CourseId = "IKN", CourseName = "Network communication", ClassDateTime = new DateTime(2016, 1, 2) },
                    new Course { CourseId = "ISU", CourseName = "Embedded software development", ClassDateTime = new DateTime(2016, 1, 3) });
            //CourseContent
            modelBuilder.Entity<CourseContent>()
                .Property(cc => cc.ContentName)
                .IsRequired();
            modelBuilder.Entity<CourseContent>()
                .HasOne(cc => cc.Course)
                .WithMany(c => c.CourseContents)
                .HasForeignKey(cc => cc.CourseId);
            //Data seeding CourseContent
            modelBuilder.Entity<CourseContent>()
                .HasData(
                    new CourseContent { CourseContentId = 1, ContentName = "Intro", CourseId = "DAB" },
                    new CourseContent { CourseContentId = 2, ContentName = "EF core", CourseId = "DAB" },
                    new CourseContent { CourseContentId = 3, ContentName = "Intro", CourseId = "IKN" },
                    new CourseContent { CourseContentId = 4, ContentName = "HTTP", CourseId = "IKN" },
                    new CourseContent { CourseContentId = 5, ContentName = "Intro", CourseId = "ISU" },
                    new CourseContent { CourseContentId = 6, ContentName = "Threads", CourseId = "ISU" }
                    );
            //Assignment
            modelBuilder.Entity<Assignment>()
                .Property(a => a.AssignmentName)
                .IsRequired();
            //Relationships
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId);
            //Data seeding Assignment
            modelBuilder.Entity<Assignment>()
                .HasData(
                    new Assignment
                    {
                    AssignmentId = 1,
                    AssignmentName = "EF core",
                    Deadline = new DateTime(2016, 1, 1),
                    RedoCounter = 1,
                    CourseId = "DAB"
                    },
                    new Assignment
                    {
                        AssignmentId = 2,
                        AssignmentName = "TCP",
                        Deadline = new DateTime(2016, 1, 1),
                        RedoCounter = 2,
                        CourseId = "IKN"
                    },
                    new Assignment
                    {
                        AssignmentId = 3,
                        AssignmentName = "Mutexes",
                        Deadline = new DateTime(2016, 1, 1),
                        RedoCounter = 1,
                        CourseId = "ISU"
                    });

            //CourseManagement
            modelBuilder.Entity<CourseManagement>()
                .HasOne(cm => cm.Course)
                .WithMany(c => c.CourseManagements)
                .HasForeignKey(cm => cm.CouseId);
            modelBuilder.Entity<CourseManagement>()
                .HasOne(cm => cm.Teacher)
                .WithMany(t => t.CourseManagements)
                .HasForeignKey(cm => cm.TeacherAuId);

            modelBuilder.Entity<CourseManagement>().HasData(
                new CourseManagement { CourseManagementId = 1, CouseId = "IKN", TeacherAuId = 1 },
                new CourseManagement { CourseManagementId = 2, CouseId = "IKN", TeacherAuId = 3 },
                new CourseManagement { CourseManagementId = 3, CouseId = "ISU", TeacherAuId = 1 },
                new CourseManagement { CourseManagementId = 4, CouseId = "DAB", TeacherAuId = 10 }
                );

        }

        public DbSet<BlackBoard.Models.CourseManagement> CourseManagement { get; set; }

        

    }
}
