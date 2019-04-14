using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Student
    {
        [Display (Name = "Students au ID")]
        public int StudentAuId { get; set; }
        [Display(Name = "Student first name")]
        public string FirstName { get; set; }
        [Display(Name = "Student last name")]
        public string LastName { get; set; }
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrolledDate { get; set; }
        [Display(Name = "Graduation Date")]
        [DataType(DataType.Date)]
        public DateTime GradulationDate { get; set; }
        public double Grade { get; set; }
        [Display (Name = "Active Status")]
        public bool isActive { get; set; }

        public List<Enroll> Enrolls { get; set; }
        public List<GroupInfo> GroupInfos { get; set; }
    }
}
