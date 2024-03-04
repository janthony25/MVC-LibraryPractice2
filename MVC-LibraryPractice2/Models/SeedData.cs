using Microsoft.EntityFrameworkCore;
using MVC_LibraryPractice2.Data;

namespace MVC_LibraryPractice2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryPractice2Context(
                    serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryPractice2Context>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book { Title = "Mini dot-net project", CallNumber = "ASD 142"},
                    new Book { Title = "test1", CallNumber = "TRY 145"}
                    );
                context.SaveChanges();
            }
        }
    }
}
