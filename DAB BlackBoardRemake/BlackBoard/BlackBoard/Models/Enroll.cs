using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Enroll
    {
        public int EnrollId { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentAuId { get; set; }
        public Student Student { get; set; }       
    }
}
