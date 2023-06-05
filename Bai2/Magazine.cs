using System;


namespace Bai2
{
    class Magazine : Document
    {
        public int Month { get; set; }

        public int NoIssue { get; set; }
        

        public Magazine(int Id, string Publisher, int NumPrinted, int Month, int NoIssue,DocType DocType) : base(Id, Publisher, NumPrinted,DocType)
        {
            this.Month = Month;
            this.NoIssue =  NoIssue;

            
        }
        public override string ToString()
        {

            return $@"Id: {Id}  Publisher: {Publisher}  Print Quantity: {NumPrinted}  Issue Month: {Month}  Issue No.: {NoIssue}";
        }
    }
}