using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentSurName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentSecondName { get; set; }
        public DateTime StudentBirthDate { get; set; }
        public string StudentGender { get; set; }
        public string StudentAdress { get; set; }
        public string StudentTelephone { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? GetOutDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public virtual ICollection<StudentDocument> StudentDocuments { get; set; }
        public Student()
        {
            StudentDocuments = new List<StudentDocument>();
        }
    }
}
