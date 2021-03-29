using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDemo.Model;

namespace LibraryDemo.Service
{
    public interface IBookRepoService
    {
        public Task<IQueryable<BookRepository>> ViewAllBooks();
    }
}
