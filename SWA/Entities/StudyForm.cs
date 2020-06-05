using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class StudyForm
    {
        public int StudyFormId { get; set; }
        public string StudyFormName { get; set; }
        public virtual ICollection<Specialty> Specialties { get; set; }
        public StudyForm()
        {
            Specialties = new List<Specialty>();
        }
    }
}
