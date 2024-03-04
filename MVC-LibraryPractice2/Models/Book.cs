using System.ComponentModel.DataAnnotations;

namespace MVC_LibraryPractice2.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string CallNumber { get; set; }

        public string Author { get; set; }

    }
}
