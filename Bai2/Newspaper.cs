using System;
using System.Reflection;
using System.Xml.Linq;


namespace Bai2
{
    class Newspaper : Document
    {
        

        public DateTime DateIssue { get; set; }
        
        public Newspaper(int Id, string Publisher, int NumPrinted, DateTime DateIssue, DocType DocType) : base(Id, Publisher, NumPrinted, DocType)
        {
            this.DateIssue = DateIssue;
           
        }
        public override string ToString()
        {
           
            return $@"Id: {Id}  Publisher: {Publisher}  Print Quantity: {NumPrinted}  Issue Date: {DateIssue}";
        }
        
    }
}
