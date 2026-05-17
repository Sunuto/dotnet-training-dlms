using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.AuthorData;

namespace LibrarySystem.Repository.AuthorRepository
{
    public interface IAuthorRepository
    {
        Task<bool> AddAuthor(Author author);
        Task<bool> EditAuthor(AuthorDetails author);
        Task<Author?> GetAuthorDetails(int id);
        Task<List<Author>> GetAuthorList();
    }
}
