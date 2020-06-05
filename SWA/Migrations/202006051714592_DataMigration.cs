namespace SWA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentTypes",
                c => new
                    {
                        DocumentTypeId = c.Int(nullable: false, identity: true),
                        DocumentTypeName = c.String(),
                    })
                .PrimaryKey(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.GeneralDocuments",
                c => new
                    {
                        GeneralDocumentId = c.String(nullable: false, maxLength: 128),
                        GeneralDocumentName = c.String(),
                        GeneralDocumentDescription = c.String(),
                        GeneralDoucmentCorrespondence = c.String(),
                        GeneralDocumentResolution = c.String(),
                        GeneralDocumentDateCreation = c.DateTime(nullable: false),
                        DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GeneralDocumentId)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeId, cascadeDelete: true)
                .Index(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.StaffDocuments",
                c => new
                    {
                        StaffDocumentId = c.String(nullable: false, maxLength: 128),
                        StaffDocumentName = c.String(),
                        StaffDocumentDescription = c.String(),
                        StaffDoucmentCorrespondence = c.String(),
                        StaffDocumentResolution = c.String(),
                        StaffDocumentDateCreation = c.DateTime(nullable: false),
                        StaffId = c.Int(nullable: false),
                        DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffDocumentId)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StafftSurName = c.String(),
                        StaffFirstName = c.String(),
                        StaffSecondName = c.String(),
                        StaffBirthDate = c.DateTime(nullable: false),
                        StaffGender = c.String(),
                        StaffAdress = c.String(),
                        StaffTelephone = c.String(),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Facts",
                c => new
                    {
                        FactId = c.Int(nullable: false, identity: true),
                        FactName = c.String(),
                        StaffId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FactId)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        WorkId = c.Int(nullable: false, identity: true),
                        WorkDate = c.DateTime(nullable: false),
                        WorkHours = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkId)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.StudentDocuments",
                c => new
                    {
                        StudentDocumentId = c.String(nullable: false, maxLength: 128),
                        StudentDocumentName = c.String(),
                        StudentDocumentDescription = c.String(),
                        StudentDoucmentCorrespondence = c.String(),
                        StudentDocumentResolution = c.String(),
                        StudentDocumentDateCreation = c.DateTime(nullable: false),
                        StudentId = c.String(maxLength: 128),
                        DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentDocumentId)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 128),
                        StudentSurName = c.String(),
                        StudentFirstName = c.String(),
                        StudentSecondName = c.String(),
                        StudentBirthDate = c.DateTime(nullable: false),
                        StudentGender = c.String(),
                        StudentAdress = c.String(),
                        StudentTelephone = c.String(),
                        AdmissionDate = c.DateTime(nullable: false),
                        GetOutDate = c.DateTime(nullable: false),
                        GraduationDate = c.DateTime(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        GroupCourse = c.Int(nullable: false),
                        GroupCount = c.Int(nullable: false),
                        GroupEndStudy = c.Int(nullable: false),
                        SpecialtyId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Specialties", t => t.SpecialtyId)
                .Index(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        SpecialtyId = c.String(nullable: false, maxLength: 128),
                        SpecialtyName = c.String(),
                        SpecialityTime = c.String(),
                        StudyFormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SpecialtyId)
                .ForeignKey("dbo.StudyForms", t => t.StudyFormId, cascadeDelete: true)
                .Index(t => t.StudyFormId);
            
            CreateTable(
                "dbo.StudyForms",
                c => new
                    {
                        StudyFormId = c.Int(nullable: false, identity: true),
                        StudyFormName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudyFormId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDocuments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Specialties", "StudyFormId", "dbo.StudyForms");
            DropForeignKey("dbo.Groups", "SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.StudentDocuments", "DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.Works", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffDocuments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Facts", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffDocuments", "DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.GeneralDocuments", "DocumentTypeId", "dbo.DocumentTypes");
            DropIndex("dbo.Specialties", new[] { "StudyFormId" });
            DropIndex("dbo.Groups", new[] { "SpecialtyId" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.StudentDocuments", new[] { "DocumentTypeId" });
            DropIndex("dbo.StudentDocuments", new[] { "StudentId" });
            DropIndex("dbo.Works", new[] { "StaffId" });
            DropIndex("dbo.Facts", new[] { "StaffId" });
            DropIndex("dbo.Staffs", new[] { "PositionId" });
            DropIndex("dbo.StaffDocuments", new[] { "DocumentTypeId" });
            DropIndex("dbo.StaffDocuments", new[] { "StaffId" });
            DropIndex("dbo.GeneralDocuments", new[] { "DocumentTypeId" });
            DropTable("dbo.StudyForms");
            DropTable("dbo.Specialties");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.StudentDocuments");
            DropTable("dbo.Works");
            DropTable("dbo.Positions");
            DropTable("dbo.Facts");
            DropTable("dbo.Staffs");
            DropTable("dbo.StaffDocuments");
            DropTable("dbo.GeneralDocuments");
            DropTable("dbo.DocumentTypes");
        }
    }
}
