using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;
using LibrarySystem.Shared.PublicationData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Repository.PublicationRepository
{


    public class PublicationRepository : IPublicationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PublicationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddPublication(Publication publication)
        {
            await _dbContext.Publications.AddAsync(publication);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
        }



        public async Task<bool> EditPublication(PublicationDetails publication)
        {
            var publicationDetails = _dbContext.Publications.FirstOrDefault(x => x.PublicationId == publication.PublicationId);
            if (publicationDetails != null)
            {
                publicationDetails.PublicationName = publication.PublicationName;
                publicationDetails.PublicationAddress = publication.PublicationAddress;
                publicationDetails.PContactPersonName = publication.PContactPersonName;
                publicationDetails.PContactPhone = publication.PContactPhone;
                publicationDetails.PublicationEmail = publication.PublicationEmail;
                var result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                    return true;
            }
            return false;
        }

        public Task<bool> DeletePublication(int publicationId)
        {
            throw new NotImplementedException();
        }


        public async Task<Publication> GetPublicationDetails(int id)
        {
            var publicationDetails = await _dbContext.Publications.AsNoTracking().FirstOrDefaultAsync(x => x.PublicationId == id);
            return publicationDetails;
        }


        public async Task<List<Publication>> GetPublicationList(string searchText)
        {
            var pubicationList = await _dbContext.Publications.AsNoTracking().OrderByDescending(x => x.PublicationId).ToListAsync();
            var query = _dbContext.Publications.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(x =>
                    x.PublicationName.Contains(searchText));
            }

            query = query.OrderByDescending(x => x.PublicationId);


            return await query.ToListAsync();

            return pubicationList;

        }


    }
}
