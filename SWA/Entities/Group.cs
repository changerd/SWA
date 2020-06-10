using System.Collections.Generic;

namespace SWA.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupCourse { get; set; }
        public int GroupCount { get; set; }
        public int GroupEndStudy { get; set; }
        public string SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Group()
        {
            Students = new List<Student>();
        }
    }
}
