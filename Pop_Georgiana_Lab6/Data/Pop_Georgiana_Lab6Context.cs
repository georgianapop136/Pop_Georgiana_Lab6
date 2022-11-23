using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Georgiana_Lab6.Models;

namespace Pop_Georgiana_Lab6.Data
{
    public class Pop_Georgiana_Lab6Context : DbContext
    {
        public Pop_Georgiana_Lab6Context (DbContextOptions<Pop_Georgiana_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Georgiana_Lab6.Models.Book> Book { get; set; } = default!;

        public DbSet<Pop_Georgiana_Lab6.Models.Publisher> Publisher { get; set; }

        public DbSet<Pop_Georgiana_Lab6.Models.Author> Author { get; set; }

        public DbSet<Pop_Georgiana_Lab6.Models.Category> Category { get; set; }

        public DbSet<Pop_Georgiana_Lab6.Models.Member> Member { get; set; }

        public DbSet<Pop_Georgiana_Lab6.Models.Borrowing> Borrowing { get; set; }
    }
}
