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
            modelBuilder.Entity<Student>()
                .HasData(new Student()
                {
                    StudentAuId = 350,
                    EnrolledDate = new DateTime(2016, 1,1),
                    FirstName = "Chris",
                    LastName = "Bernold",
                    Grade = 8.3,


                });

            //Enroll
            //Relationships
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

            //GroupInfo
            modelBuilder.Entity<GroupInfo>()
                .Property(gi => gi.GroupSize)
                .IsRequired();
            //Relationships
            modelBuilder.Entity<GroupInfo>()
                .HasOne(gi => gi.Student)
                .WithMany(s => s.GroupInfos)
                .HasForeignKey(gi => gi.StudentAuId);
            modelBuilder.Entity<GroupInfo>()
                .HasOne(gi => gi.Teacher)
                .WithMany(t => t.GroupInfos);

            //GroupHandin
            //Relationships
            modelBuilder.Entity<GroupHandin>()
                .HasOne(gh => gh.Assignment)
                .WithMany(a => a.GroupHandins)
                .HasForeignKey(gh => gh.AssignmentId);
            modelBuilder.Entity<GroupHandin>()
                .HasOne(gh => gh.GroupInfo)
                .WithMany(gi => gi.GroupHandins)
                .HasForeignKey(gh => gh.GroupInfoId);
            modelBuilder.Entity<GroupHandin>()
                .HasOne(gh => gh.Teacher)
                .WithMany(t => t.GroupHandins)
                .HasForeignKey(gh => gh.TeacherAuId);

            //Course
            modelBuilder.Entity<Course>()
                .Property(c => c.CourseName)
                .IsRequired();
            //Relationships
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherAuId);
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Enroll)
                .WithMany(e => e.Courses)
                .HasForeignKey(c => c.EnrollId);

            //CourseContent
            modelBuilder.Entity<CourseContent>()
                .Property(cc => cc.ContentName)
                .IsRequired();
            modelBuilder.Entity<CourseContent>()
                .HasOne(cc => cc.Course)
                .WithMany(c => c.CourseContents)
                .HasForeignKey(cc => cc.CourseContentId);

            //Assignment
            modelBuilder.Entity<Assignment>()
                .Property(a => a.AssignmentName)
                .IsRequired();

            //Relationships
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId);


        }

    }
}
