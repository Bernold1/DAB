using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackBoard.Models;

namespace BlackBoard.Controllers
{
    public class CourseDetailsViewModel
    {
        // Might not need be used. But will probably. (Use in details action CourseController.cs)
        public IEnumerable<Course> course { get; set; }
        public IEnumerable<List<Enroll>> enrolls { get; set; }
    }
}
