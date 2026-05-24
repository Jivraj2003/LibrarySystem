using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repository.LocationRepository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _context;

        public LocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddLocation(Book book)
        {
            await _context.Books.AddAsync(book);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
        }

        public async Task<bool> EditBooks(BookDetails book)
        {
            var bookDetails = _context.Books.FirstOrDefault(x => x.BookId == book.BookId);
            if (bookDetails != null)
            {
                bookDetails.Name = book.Name;
                bookDetails.Author = book.Author;
                bookDetails.Publication = book.Publication;
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                    return true;
            }
            return false;
        }

        public async Task<Book> GetBookDetails(int id)
        {
            var bookDetails = await _context.Books.AsNoTracking().FirstOrDefaultAsync(x => x.BookId == id);
            return bookDetails;
        }

        public async Task<List<Book>> GetBookList()
        {
            var bookList = await _context.Books.AsNoTracking().OrderByDescending(x => x.BookId).ToListAsync();
            return bookList;
        }
    }
}
