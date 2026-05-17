using LibrarySystem.Shared.CategoryData;

namespace LibrarySystem.Business.CategoryBuisness
{
    public interface ICategoryBusiness
    {
        Task<bool> AddCategory( );
        Task<bool> EditCategory( );
        List<CategoryDetails> GetCategoryList();
    }
}
