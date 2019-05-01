using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class CourseManagement
    {
        public int CourseManagementId { get; set; }

        public string CouseId { get; set; }
        public Course Course { get; set; }

        public int TeacherAuId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
