using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class CourseContent
    {
        public int CourseContentId { get; set; }
        [Display(Name = "Name of Course Content")]
        public string ContentName { get; set; }

        //FK Course
        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}
