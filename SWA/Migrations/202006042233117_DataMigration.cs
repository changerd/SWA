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
                        GeneralDocumentId = c.Int(nullable: false, identity: true),
                        GeneralDocumentName = c.String(),
                        GeneralDocumentDescription = c.String(),
                        GeneralDoucmentCorrespondence = c.String(),
                        GeneralDocumentResolution = c.String(),
                        GeneralDocumentDateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GeneralDocumentId);
            
            CreateTable(
                "dbo.StaffDocuments",
                c => new
                    {
                        StaffDocumentId = c.Int(nullable: false, identity: true),
                        StaffDocumentName = c.String(),
                        StaffDocumentDescription = c.String(),
                        StaffDoucmentCorrespondence = c.String(),
                        StaffDocumentResolution = c.String(),
                        StaffDocumentDateCreation = c.DateTime(nullable: false),
                        StaffId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffDocumentId)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
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
                        Position_PositionId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Positions", t => t.Position_PositionId)
                .Index(t => t.Position_PositionId);
            
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
                        StudentDocumentId = c.Int(nullable: false, identity: true),
                        StudentDocumentName = c.String(),
                        StudentDocumentDescription = c.String(),
                        StudentDoucmentCorrespondence = c.String(),
                        StudentDocumentResolution = c.String(),
                        StudentDocumentDateCreation = c.DateTime(nullable: false),
                        StudentId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentDocumentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
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
                        SpecialtyId = c.Int(nullable: false),
                        Specialty_SpecialtyId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Specialties", t => t.Specialty_SpecialtyId)
                .Index(t => t.Specialty_SpecialtyId);
            
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
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.GeneralDocumentDocumentTypes",
                c => new
                    {
                        GeneralDocument_GeneralDocumentId = c.Int(nullable: false),
                        DocumentType_DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GeneralDocument_GeneralDocumentId, t.DocumentType_DocumentTypeId })
                .ForeignKey("dbo.GeneralDocuments", t => t.GeneralDocument_GeneralDocumentId, cascadeDelete: true)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentType_DocumentTypeId, cascadeDelete: true)
                .Index(t => t.GeneralDocument_GeneralDocumentId)
                .Index(t => t.DocumentType_DocumentTypeId);
            
            CreateTable(
                "dbo.StaffDocumentDocumentTypes",
                c => new
                    {
                        StaffDocument_StaffDocumentId = c.Int(nullable: false),
                        DocumentType_DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StaffDocument_StaffDocumentId, t.DocumentType_DocumentTypeId })
                .ForeignKey("dbo.StaffDocuments", t => t.StaffDocument_StaffDocumentId, cascadeDelete: true)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentType_DocumentTypeId, cascadeDelete: true)
                .Index(t => t.StaffDocument_StaffDocumentId)
                .Index(t => t.DocumentType_DocumentTypeId);
            
            CreateTable(
                "dbo.StudentDocumentDocumentTypes",
                c => new
                    {
                        StudentDocument_StudentDocumentId = c.Int(nullable: false),
                        DocumentType_DocumentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentDocument_StudentDocumentId, t.DocumentType_DocumentTypeId })
                .ForeignKey("dbo.StudentDocuments", t => t.StudentDocument_StudentDocumentId, cascadeDelete: true)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentType_DocumentTypeId, cascadeDelete: true)
                .Index(t => t.StudentDocument_StudentDocumentId)
                .Index(t => t.DocumentType_DocumentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "Position_PositionId", "dbo.Positions");
            DropForeignKey("dbo.StudentDocuments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Specialties", "StudyFormId", "dbo.StudyForms");
            DropForeignKey("dbo.Groups", "Specialty_SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.StudentDocumentDocumentTypes", "DocumentType_DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.StudentDocumentDocumentTypes", "StudentDocument_StudentDocumentId", "dbo.StudentDocuments");
            DropForeignKey("dbo.Works", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffDocuments", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Facts", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.StaffDocumentDocumentTypes", "DocumentType_DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.StaffDocumentDocumentTypes", "StaffDocument_StaffDocumentId", "dbo.StaffDocuments");
            DropForeignKey("dbo.GeneralDocumentDocumentTypes", "DocumentType_DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.GeneralDocumentDocumentTypes", "GeneralDocument_GeneralDocumentId", "dbo.GeneralDocuments");
            DropIndex("dbo.StudentDocumentDocumentTypes", new[] { "DocumentType_DocumentTypeId" });
            DropIndex("dbo.StudentDocumentDocumentTypes", new[] { "StudentDocument_StudentDocumentId" });
            DropIndex("dbo.StaffDocumentDocumentTypes", new[] { "DocumentType_DocumentTypeId" });
            DropIndex("dbo.StaffDocumentDocumentTypes", new[] { "StaffDocument_StaffDocumentId" });
            DropIndex("dbo.GeneralDocumentDocumentTypes", new[] { "DocumentType_DocumentTypeId" });
            DropIndex("dbo.GeneralDocumentDocumentTypes", new[] { "GeneralDocument_GeneralDocumentId" });
            DropIndex("dbo.Specialties", new[] { "StudyFormId" });
            DropIndex("dbo.Groups", new[] { "Specialty_SpecialtyId" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.StudentDocuments", new[] { "StudentId" });
            DropIndex("dbo.Works", new[] { "StaffId" });
            DropIndex("dbo.Facts", new[] { "StaffId" });
            DropIndex("dbo.Staffs", new[] { "Position_PositionId" });
            DropIndex("dbo.StaffDocuments", new[] { "StaffId" });
            DropTable("dbo.StudentDocumentDocumentTypes");
            DropTable("dbo.StaffDocumentDocumentTypes");
            DropTable("dbo.GeneralDocumentDocumentTypes");
            DropTable("dbo.Positions");
            DropTable("dbo.StudyForms");
            DropTable("dbo.Specialties");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.StudentDocuments");
            DropTable("dbo.Works");
            DropTable("dbo.Facts");
            DropTable("dbo.Staffs");
            DropTable("dbo.StaffDocuments");
            DropTable("dbo.GeneralDocuments");
            DropTable("dbo.DocumentTypes");
        }
    }
}
