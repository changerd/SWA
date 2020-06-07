namespace SWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GeneralDocuments", "GeneralDoucmentFrom", c => c.String());
            AddColumn("dbo.GeneralDocuments", "GeneralDocumentTo", c => c.String());
            AddColumn("dbo.StaffDocuments", "StaffDoucmentFrom", c => c.String());
            AddColumn("dbo.StaffDocuments", "StaffDocumentTo", c => c.String());
            AddColumn("dbo.StudentDocuments", "StudentDoucmentFrom", c => c.String());
            AddColumn("dbo.StudentDocuments", "StudentDocumentTo", c => c.String());
            DropColumn("dbo.GeneralDocuments", "GeneralDoucmentCorrespondence");
            DropColumn("dbo.GeneralDocuments", "GeneralDocumentResolution");
            DropColumn("dbo.StaffDocuments", "StaffDoucmentCorrespondence");
            DropColumn("dbo.StaffDocuments", "StaffDocumentResolution");
            DropColumn("dbo.StudentDocuments", "StudentDoucmentCorrespondence");
            DropColumn("dbo.StudentDocuments", "StudentDocumentResolution");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentDocuments", "StudentDocumentResolution", c => c.String());
            AddColumn("dbo.StudentDocuments", "StudentDoucmentCorrespondence", c => c.String());
            AddColumn("dbo.StaffDocuments", "StaffDocumentResolution", c => c.String());
            AddColumn("dbo.StaffDocuments", "StaffDoucmentCorrespondence", c => c.String());
            AddColumn("dbo.GeneralDocuments", "GeneralDocumentResolution", c => c.String());
            AddColumn("dbo.GeneralDocuments", "GeneralDoucmentCorrespondence", c => c.String());
            DropColumn("dbo.StudentDocuments", "StudentDocumentTo");
            DropColumn("dbo.StudentDocuments", "StudentDoucmentFrom");
            DropColumn("dbo.StaffDocuments", "StaffDocumentTo");
            DropColumn("dbo.StaffDocuments", "StaffDoucmentFrom");
            DropColumn("dbo.GeneralDocuments", "GeneralDocumentTo");
            DropColumn("dbo.GeneralDocuments", "GeneralDoucmentFrom");
        }
    }
}
