using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository
    {
        private List<Library> LibraryList = new List<Library>();
        public IEnumerable<Library> GetAll()
        {
            return LibraryList;
        }

        public Library Get(int id)
        {
            return new Library();
        }
    }
}
