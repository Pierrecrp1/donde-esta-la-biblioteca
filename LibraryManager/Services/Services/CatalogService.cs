using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using BusinessLayer.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly CatalogManager _catalogManager;

        public CatalogService(CatalogManager catalogManager)
        {
            _catalogManager = catalogManager;
        }

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public IEnumerable<Book> ShowCatalog(string type)
        {
            return _catalogManager.DisplayCatalog(type);
        }

        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }
    }
}
