using System.Collections.Generic;

namespace SWA.Entities
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public virtual ICollection<StudentDocument> StudentDocuments { get; set; }
        public virtual ICollection<StaffDocument> StaffDocuments { get; set; }
        public virtual ICollection<GeneralDocument> GeneralDocuments { get; set; }
        public DocumentType()
        {
            StudentDocuments = new List<StudentDocument>();
            StaffDocuments = new List<StaffDocument>();
            GeneralDocuments = new List<GeneralDocument>();
        }
    }
}
