using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDemo.Data;
using LibraryDemo.Model;

namespace LibraryDemo.Service
{
    
    public class BookRepoService:IBookRepoService
    {
        private readonly LibraryContext _libdbcontext;

        public BookRepoService(LibraryContext libcontext)
        {
            _libdbcontext = libcontext;
        }

        public async Task<IQueryable<BookRepository>> ViewAllBooks()
        {
            var booklist = _libdbcontext.bookrepository.OrderBy(x => x.BookStatus);
            if (booklist != null)
            {

                return await Task.FromResult(booklist);
            }
            return null;
        }
    }
}
