using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackBoard.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public List<GroupInfo> GroupInfos { get; set; }
        public List<GroupHandin> GroupHandins { get; set; }
    }
}
