using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Course
    {
        public string CourseId { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Class Time")]
        [DataType(DataType.Date)]
        public DateTime ClassDateTime { get; set; }

        //Teacher FK
        public int TeacherAuId { get; set; }
        public Teacher Teacher { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<CourseContent> CourseContents { get; set; }

        public List<Enroll> Enrolls { get; set; }
    }
}
