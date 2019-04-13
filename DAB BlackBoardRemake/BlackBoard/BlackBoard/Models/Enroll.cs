using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Enroll
    {
        public int EnrollId { get; set; }

        //Student FK
        public int StudentAuId { get; set; }
        public Student Student { get; set; }

        public List<Course> Courses { get; set; }
    }
}
