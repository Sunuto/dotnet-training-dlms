using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;

namespace LibrarySystem.Business.LocationBusiness
{
    public interface ILocationBusiness
    {
        Task<bool> AddLocation(LibraryLocationDetails location);
        Task<bool> EditLocation(LibraryLocationDetails location);
        Task<LibraryLocationDetails> GetLocationDetails(int id);
        Task<List<LibraryLocationDetails>> GetLocationList();
    }
}
