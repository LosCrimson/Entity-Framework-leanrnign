
using MyApp.BusinessLogic;
using MyApp.Repository.Models;

var bookService = new BookService();
var bookName = "Harry Potter";
bookService.AddBook(bookName);

var book = (Book)bookService.GetBookByName("Harry Potter");
Console.WriteLine(book.Name);
Console.ReadKey();
