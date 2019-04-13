using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Teacher
    {
        public int TeacherAuId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Assistant")]
        public bool IsAssistant { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime Birthday { get; set; }

        public List<GroupHandin> GroupHandins { get; set; }
        public List<GroupInfo> GroupInfos { get; set; }
        public List<Course> Courses { get; set; }
    }
}
