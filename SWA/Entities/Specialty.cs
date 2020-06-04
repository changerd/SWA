using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class Specialty
    {
        public string SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }
        public string SpecialityTime { get; set; }
        public int StudyFormId { get; set; }
        public StudyForm StudyForm { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public Specialty()
        {
            Groups = new List<Group>();
        }
    }
}
