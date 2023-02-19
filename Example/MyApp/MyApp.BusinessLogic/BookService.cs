using MyApp.Repository.Models;
using MyApp.Repository.Repositories;

namespace MyApp.BusinessLogic
{
    public class BookService
    {
        private readonly BookRepository bookRepository;
        public BookService() 
        {
            bookRepository = new BookRepository();
        
        }
        public Book GetBookByName(string name)
        {
            Book book = bookRepository.GetBookByName(name);
            return book;
        }

        public void AddBook(string name)
        {
            bookRepository.Add(name);
        }
    }
}
