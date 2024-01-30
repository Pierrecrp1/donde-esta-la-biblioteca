using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private readonly IGenericRepository<Book> _bookRepository;

        public CatalogManager(IGenericRepository<Book> genericRepository)
        {
            _bookRepository = genericRepository;
        }

        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public IEnumerable<Book> DisplayCatalog(string type)
        {
            if (Enum.TryParse<BookTypes>(type, true, out BookTypes typeEnum))
            {
                return _bookRepository.GetAll().Where(book => book.Type == typeEnum);
            }
            else
            {
                return Enumerable.Empty<Book>();
            }
        }

        public Book FindBook(int id)
        {
            return _bookRepository.Get(id);
        }

        public IEnumerable<Book> GetFantasy()
        {

            IEnumerable<Book> books = _bookRepository.GetAll();

            IEnumerable<Book> query = (from book in books
                                       where book.Type == BookTypes.Fantasy
                                       select book);

            return query;
        }

        public Book GetBestRate()
        {

            IEnumerable<Book> books = _bookRepository.GetAll();

            Book query = (from book in books
                          orderby book.Rate descending
                          select book).FirstOrDefault(books.First());

            return query;
        }

    }
}
