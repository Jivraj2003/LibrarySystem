using LibrarySystem.Shared.BookData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business.LocationBusiness
{
    public interface ILocationBusiness
    {
        Task<bool> AddLocation(BookDetails book);
        Task<bool> EditLocation(BookDetails book);
        Task<BookDetails> GetLocationDetails(int id);
        Task<List<BookDetails>> GetLocationList();
    }
}
