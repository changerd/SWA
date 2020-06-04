using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public Position()
        {
            Staffs = new List<Staff>();
        }
    }
}
