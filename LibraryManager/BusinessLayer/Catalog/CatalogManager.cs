using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        private readonly BookRepository _bookRepository;

        public CatalogManager(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> DisplayCatalog() {
            return _bookRepository.GetAll();
        }

        public IEnumerable<Book> DisplayCatalog(string type)
        {
            return _bookRepository.GetAll().Where(book => book.Type != null && book.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        public Book FindBook(int id) {
            return _bookRepository.Get(id);
        }

    }
}
