using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.Entities
{
    public class GeneralDocument
    {
        public string GeneralDocumentId { get; set; }
        public string GeneralDocumentName { get; set; }
        public string GeneralDocumentDescription { get; set; }
        public string GeneralDoucmentFrom{ get; set; }
        public string GeneralDocumentTo { get; set; }
        public DateTime GeneralDocumentDateCreation { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
