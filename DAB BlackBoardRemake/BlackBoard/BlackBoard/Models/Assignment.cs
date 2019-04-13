using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        [Display(Name = "Assignment Name")]
        public string AssignmentName { get; set; }
        [Display]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd-hh-mm")]
        public DateTime Deadline { get; set; }

        [Display(Name = "Redo counter")]
        public int RedoCounter { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public List<GroupHandin> GroupHandins { get; set; }
    }
}
