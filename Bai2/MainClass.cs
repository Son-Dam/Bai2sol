using Bai2;
using System;
class Mainclass
{
    enum UserAction
    {
        Add,
        Delete,
        Find,
        Print,
        Quit
    }
    public static void Main()
    {
        DocManager docManager = new DocManager();
        bool quitting = false;
    start:
        Console.WriteLine(
@"Welcome to the library.
Type ""Add"" if you want to add a document into the library.
Type ""Delete"" if you want to remove a document from the library.
Type ""Print"" if you want to see list of documents in details.
Type ""Find"" if you want to find document by type.
Type ""Quit"" if you want to exit the program.");
        string input = Console.ReadLine();
        UserAction action;
        if (!Enum.TryParse(input, true, out action))
        {
            Console.WriteLine("Please enter only one action among Add, Delete, Print, Find and Quit");
            goto start;
        }
        switch (action)
        {
            case UserAction.Add:
                docManager.AddDocument();
                break;
            case UserAction.Delete:
 
                docManager.RemoveDocument();
                break;
            case UserAction.Find:
                Console.WriteLine("Please enter the document type(Book, Magazine, Newspaper):");
                ReadDocType:
                input = Console.ReadLine();
                DocType docType;

                if (!Enum.TryParse(input, true, out docType))
                {
                    Console.WriteLine("You entered an invalid document type. Please only enter \"Book\", \"Magazine\" or\"Newspaper\"!");
                    goto ReadDocType;
                }
                docManager.Print(docManager.FindDocByType(docType));
                break;
             case UserAction.Print:
                docManager.Print(docManager.ListDocuments());
                break;
            case UserAction.Quit:
                Console.WriteLine("Exitting...");
                quitting = true;
                break;
        }
        if(!quitting) goto start;

    }
}