using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class GroupHandin
    {
        public int GroupHandinId { get; set; }

        //Assignment FK
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        //Grade of Handin
        public int Grade { get; set; }

        //Group FK
        public int GroupId { get; set; }
        public Group Group { get; set; }

        //Teacher FK
        public int TeacherAuId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
