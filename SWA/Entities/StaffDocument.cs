using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class StaffDocument
    {
        public string StaffDocumentId { get; set; }
        public string StaffDocumentName { get; set; }
        public string StaffDocumentDescription { get; set; }
        public string StaffDoucmentCorrespondence { get; set; }
        public string StaffDocumentResolution { get; set; }
        public DateTime StaffDocumentDateCreation { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
