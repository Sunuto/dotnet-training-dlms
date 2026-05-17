using LibrarySystem.Repository.AuthorRepository;
using LibrarySystem.Shared.AuthorData;


namespace LibrarySystem.Business.AuthorBusiness
{
    public class AuthorBusiness : IAuthorBusiness
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorBusiness(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<bool> AddAuthor(AuthorDetails author)
        {
            var authorEntity = new Repository.Models.Author
            {
                FirstName = string.IsNullOrEmpty(author.FirstName) ? "" : author.FirstName,
                MiddleName = string.IsNullOrEmpty(author.MiddleName) ? "" : author.MiddleName,
                LastName = string.IsNullOrEmpty(author.LastName) ? "" : author.LastName,
                DateOfBirth = author.DateOfBirth,
                Bio = author.Bio,
            };
            return await _authorRepository.AddAuthor(authorEntity);
        }

        public async Task<bool> EditAuthor(AuthorDetails author)
        {
            return await _authorRepository.EditAuthor(author);
        }

        public async Task<AuthorDetails?> GetAuthorDetails(int id)
        {
            var authorData = await _authorRepository.GetAuthorDetails(id);
            if (authorData == null)
            {
                return null;
            }

            var authorDetails = new AuthorDetails
            {
                AuthorId = authorData.Id,
                FirstName = authorData.FirstName,
                MiddleName = authorData.MiddleName,
                LastName = authorData.LastName,
                DateOfBirth = authorData.DateOfBirth,
                Bio = authorData.Bio,
            };
            return authorDetails;
        }

        public async Task<List<AuthorDetails>> GetAuthorList()
        {
            List<AuthorDetails> authorList = new List<AuthorDetails>();
            var authors = await _authorRepository.GetAuthorList();
            foreach (var author in authors)
            {
                authorList.Add(new AuthorDetails
                {
                    AuthorId = author.Id,
                    FirstName = author.FirstName,
                    MiddleName = author.MiddleName,
                    LastName = author.LastName,
                    DateOfBirth = author.DateOfBirth,
                    Bio = author.Bio,
                });
            }
            return authorList;
        }
    }
}
