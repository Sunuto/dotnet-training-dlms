using LibrarySystem.Shared.AuthorData;

namespace LibrarySystem.Business.AuthorBusiness
{
    public interface IAuthorBusiness
    {
        Task<bool> AddAuthor(AuthorDetails author);
        Task<bool> EditAuthor(AuthorDetails author);
        Task<AuthorDetails?> GetAuthorDetails(int id);
        Task<List<AuthorDetails>> GetAuthorList();
    }
}
