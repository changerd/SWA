namespace SWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AdmissionDate", c => c.DateTime());
            AlterColumn("dbo.Students", "GetOutDate", c => c.DateTime());
            AlterColumn("dbo.Students", "GraduationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "GraduationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "GetOutDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "AdmissionDate", c => c.DateTime(nullable: false));
        }
    }
}
