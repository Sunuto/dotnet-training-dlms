using LibrarySystem.Repository.Models;
using LibrarySystem.Repository.PublicationRepository;
using LibrarySystem.Shared.PublicationData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Business.PublicationBusiness
{
    public class PublicationBusiness : IPublicationBusiness
    {
        private readonly IPublicationRepository _publicationRepository;

        public PublicationBusiness(IPublicationRepository publicationRepository)
        {
            _publicationRepository = publicationRepository;
        }

       

        public async Task<bool> AddPublication(PublicationDetails publication)
        {
            var publicationEntity = new Repository.Models.Publication
            {
                PublicationName = publication.PublicationName,
                PublicationAddress = publication.PublicationAddress,
               
            };
            return await _publicationRepository.AddPublication(publicationEntity);
        }

        public Task<bool> AddPublication(Publication publication)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePublication(int publicationId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditPublication(Publication publication)
        {
            throw new NotImplementedException();
        }

        public List<PublicationDetails> GetPublicationList()
        {
            throw new NotImplementedException();
        }

        public Task<List<Publication>> ListPublications()
        {
            throw new NotImplementedException();
        }

        public Task<Publication> PublicationDetails(int publicationId)
        {
            throw new NotImplementedException();
        }
    }
}
