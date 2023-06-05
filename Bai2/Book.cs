using System;


namespace Bai2
{
    class Book : Document
    {
        public string AuthorName { get; set; }

        public int NumPages { get; set; }
        public DocType DocType { get; set; }    

        public Book(int Id, string Publisher, int NumPrinted, string AuthorName, int numPages,DocType DocType) : base(Id, Publisher, NumPrinted,DocType)
        {
            this.AuthorName = AuthorName;
            this.NumPages = numPages;

        }

        public override string ToString()
        {

            return $@"Id: {Id}  Publisher: {Publisher}  Print Quantity: {NumPrinted}  Author: {AuthorName}  Number of pages: {NumPages}";
        }
    }
}
