using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_LibraryPractice2.Models;

namespace MVC_LibraryPractice2.Data
{
    public class LibraryPractice2Context : DbContext
    {
        public LibraryPractice2Context (DbContextOptions<LibraryPractice2Context> options)
            : base(options)
        {
        }

        public DbSet<MVC_LibraryPractice2.Models.Book> Book { get; set; } = default!;
    }
}
