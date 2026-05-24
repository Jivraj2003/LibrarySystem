using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repository.LocationRepository
{
    public interface ILocationRepository
    {
        Task<bool> AddLocation(Book book);
        Task<bool> EditLocation(BookDetails book);
        Task<Book> GetLocationDetails(int id);
        Task<List<Book>> GetLocationList();
    }
}
}
