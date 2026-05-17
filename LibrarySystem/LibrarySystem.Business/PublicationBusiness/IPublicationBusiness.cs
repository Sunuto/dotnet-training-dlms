using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.PublicationData;

namespace LibrarySystem.Business.PublicationBusiness
{
    public interface IPublicationBusiness
    {
        List<PublicationDetails> GetPublicationList();

        Task<bool> AddPublication(Publication publication);
        Task<bool> EditPublication(Publication publication);
        Task<bool> DeletePublication(int publicationId);
        Task<List<Publication>> ListPublications();
        Task<Publication> PublicationDetails(int publicationId);
        Task<bool> AddPublication(PublicationDetails publication);
    }
}
