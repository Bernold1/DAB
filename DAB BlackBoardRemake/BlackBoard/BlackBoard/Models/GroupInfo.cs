using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class GroupInfo
    {
        public int GroupInfoId { get; set; }
        [Display(Name = "Max Group Size")]
        public int GroupSize { get; set; }

        //Student FK
        public int StudentAuId { get; set; }
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public List<GroupHandin> GroupHandins { get; set; }


    }
}
