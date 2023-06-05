using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    enum DocType{
        Book,
        Magazine,
        Newspaper
    }

    class DocManager
    {
        List<Document> documents;
        HashSet<int> Ids = new HashSet<int>();
        public DocManager()
        { 
            documents = new List<Document>();  
        }

        public bool docExist(int Id)
        {
            return Ids.Contains(Id);
        }

        public void AddDocument()
        {
            Document doc = null;
            Console.WriteLine("Please type the Id of the document:");
            
        
        ReadID:
            string input = Console.ReadLine();
            int Id;
            if (!int.TryParse(input, out Id) || docExist(Id))
            {
                Console.WriteLine("The ID you entered was either not a number or an existing document's ID. Please type a valid number!");
            goto ReadID;
            }

            Console.WriteLine("Please type the Publisher's Name:");
            string Publisher = Console.ReadLine();

            Console.WriteLine("Please type the print quantity:");
            
        
        ReadNumPrinted:
            input = Console.ReadLine();
            int NumPrinted;
            if (!int.TryParse(input, out NumPrinted))
            {
                Console.WriteLine("Please type a valid number!");
            goto ReadNumPrinted;
            }

            Console.WriteLine("Please enter the document type(Book, Magazine, Newspaper):");
        
        
        ReadDocType:
            input = Console.ReadLine();
            DocType docType;

            if(!Enum.TryParse(input, true,  out docType)) 
            {
                Console.WriteLine("You entered an invalid document type. Please only enter \"Book\", \"Magazine\" or\"Newspaper\"!");
                goto ReadDocType;
            }
            
            
            switch (docType)
            {
                case DocType.Book:
                    Console.WriteLine("Please enter author name:");
                    string AuthorName = Console.ReadLine();
                    Console.WriteLine("Please enter number of pages:");
                    
                ReadNumPages:
                    input = Console.ReadLine();
                    int numPages;
                    if (!int.TryParse(input,out numPages))
                    {
                        Console.WriteLine("Please type a valid number!");
                        goto ReadNumPages;
                    }
                    doc = new Book(Id,Publisher,NumPrinted,AuthorName, numPages,docType);
                    break;
                case DocType.Magazine:
                    Console.WriteLine();
                    
                ReadMonth:
                    input = Console.ReadLine();
                    int month;
                    if (!int.TryParse(input,out month)|| month < 1 || month > 12)
                    {
                        Console.WriteLine("Please enter a valid number from 1 to 12!");
                        goto ReadMonth;
                    }
                    
                ReadNoIssue:
                    input = Console.ReadLine();
                    int NoIssue;
                    if (!int.TryParse(input, out NoIssue))
                    {
                        Console.WriteLine("Please enter a valid number!");
                        goto ReadNoIssue;
                    }
                    doc = new Magazine(Id,Publisher,NumPrinted,month,NoIssue, docType);
                    break;
                case DocType.Newspaper:
                    Console.WriteLine("Please enter date of issue(mm/dd/yyyy)");
                    
                ReadDateTime:
                    input = Console.ReadLine();
                    DateTime date;
                    if (!DateTime.TryParse(input,out date))
                    {
                        Console.WriteLine("Please enter a valid date in format (mm/dd/yyyy)");
                        goto ReadDateTime;
                    }
                    doc = new Newspaper(Id, Publisher, NumPrinted, date,docType);
                    break;
            }

            Ids.Add(Id);
            documents.Add(doc);
            Console.WriteLine("Document added successfully!") ;
        }

        public void RemoveDocument() {
            
            Console.WriteLine("Please enter the ID of the document you are going to delete") ;
        ReadID:
            string input = Console.ReadLine();
            int Id;
            if (!int.TryParse(input, out Id) || docExist(Id))
            {
                Console.WriteLine("The ID you entered was either not a number or an existing document's ID. Please type a valid number!");
                goto ReadID;
            }
            
            for(int i = 0;i<documents.Count;i++) {
                if (documents[i].Id == Id)
                {
                    documents.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Document removed successfully!");
        }

        public List<Document> FindDocByType(DocType type)
        {
            
            return documents.Where(doc=>doc.DocType.Equals(type)).ToList();
        }
        public List<Document> ListDocuments()
        { 
            return documents; 
        }

        public void Print(List<Document> list)
        {
            foreach (Document doc in list)
            {
                Console.WriteLine(doc.ToString());
            }
        }
        
    }
}
