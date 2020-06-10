using System;

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
