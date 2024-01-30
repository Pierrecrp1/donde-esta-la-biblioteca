using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        IEnumerable<Book> DisplayCatalog();
        IEnumerable<Book> DisplayCatalog(string type);
        Book FindBook(int id);
        Book GetBestRate();
        IEnumerable<Book> GetFantasy();
    }
}