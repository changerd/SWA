using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupCourse { get; set; }
        public int GroupCount { get; set; }
        public int GroupEndStudy { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Group()
        {
            Students = new List<Student>();
        }
    }
}
