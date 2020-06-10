using System;
using System.Collections.Generic;

namespace SWA.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StafftSurName { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffSecondName { get; set; }
        public DateTime StaffBirthDate { get; set; }
        public string StaffGender { get; set; }
        public string StaffAdress { get; set; }
        public string StaffTelephone { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public virtual ICollection<Work> Works { get; set; }
        public virtual ICollection<Fact> Facts { get; set; }
        public virtual ICollection<StaffDocument> StaffDocuments { get; set; }
        public Staff()
        {
            Works = new List<Work>();
            Facts = new List<Fact>();
            StaffDocuments = new List<StaffDocument>();
        }
    }
}
