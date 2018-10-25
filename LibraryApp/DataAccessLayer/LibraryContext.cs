using LibraryApp.Models;
using System.Data.Entity;

namespace LibraryApp.DataAccessLayer
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryApplicaionDB")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }


    }
}