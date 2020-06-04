using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class StaffDocument
    {
        public int StaffDocumentId { get; set; }
        public string StaffDocumentName { get; set; }
        public string StaffDocumentDescription { get; set; }
        public string StaffDoucmentCorrespondence { get; set; }
        public string StaffDocumentResolution { get; set; }
        public DateTime StaffDocumentDateCreation { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public StaffDocument()
        {
            DocumentTypes = new List<DocumentType>();
        }
    }
}
