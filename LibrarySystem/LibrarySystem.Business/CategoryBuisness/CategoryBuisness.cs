using LibrarySystem.Repository.CategoryRepository;
using LibrarySystem.Shared.CategoryData;

namespace LibrarySystem.Business.CategoryBuisness
{
    public class CategoryBuisness : ICategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBuisness(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<bool> AddCategory( )
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCategory( )
        {
            throw new NotImplementedException();
        }

        public List<CategoryDetails> GetCategoryList()
        {
            List<CategoryDetails> categories = new List<CategoryDetails>();
            var categoryDetails = _categoryRepository.GetCategoryList();
            foreach (var category in categoryDetails)
            {
                categories.Add(new CategoryDetails
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                });
            }
            return categories;
        }
    }
}
