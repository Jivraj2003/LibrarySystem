using LibrarySystem.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibrarySystem.Repository.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LibraryLocation> LibraryLocations { get; set; }
        public DbSet<Publication> Publications { get; set; }
    }
}