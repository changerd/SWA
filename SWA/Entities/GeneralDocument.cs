using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class GeneralDocument
    {
        public int GeneralDocumentId { get; set; }
        public string GeneralDocumentName { get; set; }
        public string GeneralDocumentDescription { get; set; }
        public string GeneralDoucmentCorrespondence { get; set; }
        public string GeneralDocumentResolution { get; set; }
        public DateTime GeneralDocumentDateCreation { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public GeneralDocument()
        {
            DocumentTypes = new List<DocumentType>();
        }
    }
}
