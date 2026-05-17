using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.PublicationData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Repository.PublicationRepository
{
    public interface IPublicationRepository
    {

        Task<bool> AddPublication(Publication publication);

        Task<bool> EditPublication(PublicationDetails publication);
        Task<bool> DeletePublication(int publicationId);
        Task<Publication> GetPublicationDetails(int id);
        Task<List<Publication>> GetPublicationList(string searchText);
    }
}
