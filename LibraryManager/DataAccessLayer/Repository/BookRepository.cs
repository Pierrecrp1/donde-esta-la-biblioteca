using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IGenericRepository<Book>
    {
        private List<Book> BookList = new List<Book>();
        public IEnumerable<Book> GetAll() {
            return BookList;
        }

        public Book Get(int id)
        {
            return new Book();
        }
    }
}
