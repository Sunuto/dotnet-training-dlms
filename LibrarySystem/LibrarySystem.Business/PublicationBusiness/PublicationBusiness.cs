using LibrarySystem.Repository.Models;
using LibrarySystem.Repository.PublicationRepository;
using LibrarySystem.Shared.BookData;
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
                PContactPersonName = publication.PContactPersonName,
                PContactPhone = publication.PContactPhone,
                PublicationEmail = publication.PublicationEmail
               
            };
            return await _publicationRepository.AddPublication(publicationEntity);
        }

        public Task<bool> DeletePublication(int publicationId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditPublication(PublicationDetails publication)
        {
            return await _publicationRepository.EditPublication(publication);
        }

        public async Task<PublicationDetails> GetPublicationDetails(int id)
        {
            var publicationData = await _publicationRepository.GetPublicationDetails(id);
            var publicationDetails = new PublicationDetails
            {
                PublicationId = publicationData.PublicationId,
                PublicationName = publicationData.PublicationName,
                PublicationAddress = publicationData.PublicationAddress,
                PContactPersonName = publicationData.PContactPersonName,
                PContactPhone = publicationData.PContactPhone,
                PublicationEmail = publicationData.PublicationEmail
            };
            return publicationDetails;
        }

        

        public async Task<List<PublicationDetails>> GetPublicationList(string searchText)
        {
            List<PublicationDetails> publicationList = new List<PublicationDetails>();
            var publications = await _publicationRepository.GetPublicationList(searchText);
            foreach (var publication in publications)
            {
                publicationList.Add(new PublicationDetails
                { 
                    PublicationId = publication.PublicationId,
                    PublicationName = publication.PublicationName,
                    PublicationAddress = publication.PublicationAddress,
                    PContactPersonName = publication.PContactPersonName,
                    PContactPhone = publication.PContactPhone,
                    PublicationEmail= publication.PublicationEmail
                });
            }

            return publicationList;

        }









    }
}
