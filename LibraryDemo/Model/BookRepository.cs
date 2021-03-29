using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryDemo.Model
{
    public class BookRepository
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("BOOKNAME")]
        public string BookName { get; set; }
        [Column("authorname")]
        public string AuthorName { get; set; }
        [Column("BOOKSTATUS")]
        public string BookStatus { get; set; }
    }
}
