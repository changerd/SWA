using System;

namespace SWA.Entities
{
    public class StaffDocument
    {
        public string StaffDocumentId { get; set; }
        public string StaffDocumentName { get; set; }
        public string StaffDocumentDescription { get; set; }
        public string StaffDoucmentFrom { get; set; }
        public string StaffDocumentTo { get; set; }
        public DateTime StaffDocumentDateCreation { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
