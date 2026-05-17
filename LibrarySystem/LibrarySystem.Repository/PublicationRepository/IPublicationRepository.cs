using LibrarySystem.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Repository.PublicationRepository
{
    public interface IPublicationRepository
    {
        
        Task <bool> AddPublication(Publication publication);
        Task <bool> EditPublication(Publication publication);
        Task <bool> DeletePublication(int publicationId);
        Task <List<Publication>> ListPublications();
        Task <Publication> PublicationDetails(int publicationId);

    }
}
