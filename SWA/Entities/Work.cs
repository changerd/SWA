using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class Work
    {
        public int WorkId { get; set; }
        public DateTime WorkDate { get; set; }
        public int WorkHours { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
