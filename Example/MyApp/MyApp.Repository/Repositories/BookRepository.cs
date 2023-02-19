using MyApp.Repository.Models;

namespace MyApp.Repository.Repositories
{
    public class BookRepository
    {
        private readonly MyAppDbContext dbContext; 
        public BookRepository()
        {
            dbContext = new MyAppDbContext();
        }

        public Book GetBookByName(string name)
        {
            Book book = dbContext.Books.Where<Book>(x => x.Name == name).FirstOrDefault();
            return book;
        }

        public void Add(string name)
        {
            Book book = new Book(name);
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
        }
    }
}
