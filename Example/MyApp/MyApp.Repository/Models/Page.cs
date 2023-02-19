using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Repository.Models
{
    public class Page
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;
        }
    }
}
