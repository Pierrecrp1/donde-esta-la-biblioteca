using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        Book FindBook(int id);
        IEnumerable<Book> ShowCatalog();
        IEnumerable<Book> ShowCatalog(string type);
    }
}