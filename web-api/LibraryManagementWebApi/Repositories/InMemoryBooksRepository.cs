using LibraryManagementWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Repositories
{
    public class InMemoryBooksRepository : IBooksRepository
    {
        private readonly List<Book> books = new()
        {
            new Book { BookId = Guid.NewGuid(), CategoryId = 1, Title = "", CreatedDate = DateTimeOffset.UtcNow },
            new Book { BookId = Guid.NewGuid(), CategoryId = 2, Title = "", CreatedDate = DateTimeOffset.UtcNow },
            new Book { BookId = Guid.NewGuid(), CategoryId = 3, Title = "", CreatedDate = DateTimeOffset.UtcNow }
        };

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
