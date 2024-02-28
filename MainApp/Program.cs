using Domain;
using Infrastructure;

var books = new List<BookServices>();

var book1 = new Book();
book1.Id = 1;
book1.Tittle = "ZabonShinos";
book1.Description = "Sarlavhai donish";
book1.Year = new DateTime(1988, 02, 21);
book1.Author = "Saidshukuri Janubi";

var book2 = new Book();
book2.Id = 2;
book2.Tittle = "Bedonish";
book2.Description = "Donishi bemaini";
book2.Year = new DateTime(1999, 01, 11);
book2.Author = "AbdughforJon";

var book3 = new Book();
book3.Id = 3;
book3.Tittle = "Roxi Maktab";
book3.Description = "Sari Raxi kucha";
book3.Year = new DateTime(1922, 12, 11);
book3.Author = "Abdulghanei Bedil";

books.Add(book1);
books.Add(book2);
books.Add(book3);



foreach (var it in books)
{
    
}

// System.Console.WriteLine("Baroi giriftani malumot <<info>>-po yo <<Get>>-po navised");
// while(true)
// {
//     string command = Console.ReadLine();
//     switch(command)
//     {
//         case "info":
        
//     }

// }

