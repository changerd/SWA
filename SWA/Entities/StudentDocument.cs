using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class StudentDocument
    {
        public string StudentDocumentId { get; set; }
        public string StudentDocumentName { get; set; }
        public string StudentDocumentDescription { get; set; }
        public string StudentDoucmentCorrespondence { get; set; }
        public string StudentDocumentResolution { get; set; }
        public DateTime StudentDocumentDateCreation { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
