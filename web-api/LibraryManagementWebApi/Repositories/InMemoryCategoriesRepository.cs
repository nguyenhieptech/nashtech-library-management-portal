using LibraryManagementWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Repositories
{
    public class InMemoryCategoriesRepository : ICategoriesRepository
    {
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }   

        public async Task UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
