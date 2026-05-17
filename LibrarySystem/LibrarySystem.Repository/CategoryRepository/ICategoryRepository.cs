using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<bool> AddCategory( Category category);
        Task<bool> EditCategory(int id);
        List<Category> GetCategoryList();
    }
}
