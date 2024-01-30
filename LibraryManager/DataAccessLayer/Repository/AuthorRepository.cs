using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IGenericRepository<Author>
    {
        private List<Author> AuthorList = new List<Author>();
        public IEnumerable<Author> GetAll()
        {
            return AuthorList;
        }

        public Author Get(int id)
        {
            return new Author();
        }
    }
}
