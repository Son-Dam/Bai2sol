using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Document
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public int NumPrinted{ get; set; }
        public DocType DocType { get; set; }
        public Document(int Id, string Publisher, int NumPrinted, DocType docType)
        {
            this.Id = Id;
            this.Publisher = Publisher;
            this.NumPrinted = NumPrinted;
            DocType = docType;
        }

        public Document(int id, string publisher, int numPrinted)
        {
            Id = id;
            Publisher = publisher;
            NumPrinted = numPrinted;
        }
    }
}
