using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.PublicationData;

namespace LibrarySystem.Business.PublicationBusiness
{
    public interface IPublicationBusiness
    {
        Task<bool> AddPublication(PublicationDetails publication);

        Task<bool> EditPublication(PublicationDetails publication);
        Task<bool> DeletePublication(int publicationId);
        Task<PublicationDetails> GetPublicationDetails(int id);
        Task<List<PublicationDetails>> GetPublicationList(string searchText);
    }
}
