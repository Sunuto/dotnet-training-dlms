using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.AuthorData;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Repository.AuthorRepository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAuthor(Author author)
        {
            await _context.Authors.AddAsync(author);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
                return true;
            return false;
        }

        public async Task<bool> EditAuthor(AuthorDetails author)
        {
            var authorDetails = _context.Authors.FirstOrDefault(x => x.Id == author.AuthorId);
            if (authorDetails != null)
            {
                authorDetails.FirstName = string.IsNullOrEmpty(author.FirstName)?"":author.FirstName;
                authorDetails.MiddleName = string.IsNullOrEmpty(author.MiddleName)?"":author.MiddleName;
                authorDetails.LastName = string.IsNullOrEmpty(author.LastName) ? "" : author.LastName;
                authorDetails.DateOfBirth = author.DateOfBirth;
                authorDetails.Bio = author.Bio;
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                    return true;
            }
            return false;
        }

        public async Task<Author?> GetAuthorDetails(int id)
        {
            var authorDetails = await _context.Authors.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return authorDetails;
        }


        public async Task<List<Author>> GetAuthorList()
        {
            var authorList = await _context.Authors.AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();
            return authorList;
        }
    }
}
