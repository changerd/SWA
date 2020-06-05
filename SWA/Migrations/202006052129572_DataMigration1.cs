namespace SWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudyForms", "StudyFormName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudyForms", "StudyFormName", c => c.Int(nullable: false));
        }
    }
}
