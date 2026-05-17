using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;
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
        

        public Task<bool> DeletePublication(int publicationId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditPublication(Publication publication)
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
