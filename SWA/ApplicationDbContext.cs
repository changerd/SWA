using SWA.Entities;
using System.Data.Entity;

namespace SWA
{
    public class ApplicationDbContext : DbContext
    {
        //yexaciw681@mailnd7.com
        //Qwerty123
        public ApplicationDbContext() : base("ApplicationDbContext") { }

        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<GeneralDocument> GeneralDocuments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffDocument> StaffDocuments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDocument> StudentDocuments { get; set; }
        public DbSet<StudyForm> StudyForms { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
