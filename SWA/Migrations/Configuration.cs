namespace SWA.Migrations
{
    using SWA.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SWA.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SWA.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            var dt1 = new DocumentType { DocumentTypeName = "Входящий" };
            var dt2 = new DocumentType { DocumentTypeName = "Исходящий" };
            var dt3 = new DocumentType { DocumentTypeName = "Внутренний" };
            context.DocumentTypes.Add(dt1);
            context.DocumentTypes.Add(dt2);
            context.DocumentTypes.Add(dt3);


            var sf = new StudyForm { StudyFormName = "Дневная" };
            
            var s = new Specialty { SpecialtyId = "Default", SpecialtyName = "Default" };
            
            var g1 = new Group { GroupName = "Абитурьенты"  };
            var g2 = new Group { GroupName = "Отчисленные" };

            context.Groups.Add(g1);
            context.Groups.Add(g2);

            s.Groups.Add(g1);
            s.Groups.Add(g2);

            context.Specialties.Add(s);

            sf.Specialties.Add(s);

            context.StudyForms.Add(sf);                       

            context.SaveChanges();

        }
    }
}
