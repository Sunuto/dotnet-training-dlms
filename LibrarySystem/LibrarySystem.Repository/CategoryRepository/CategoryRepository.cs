using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;
using LibrarySystem.Shared.BookData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryList()
        {
            var details = _context.Categories.ToList();
            return details;
        }
    }
}
