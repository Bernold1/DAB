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
        //Group FK
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }


    }
}
