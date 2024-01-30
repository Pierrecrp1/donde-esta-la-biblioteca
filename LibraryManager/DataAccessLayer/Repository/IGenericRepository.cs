using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IGenericRepository<type_retour>
    {
        IEnumerable<type_retour> GetAll();
        type_retour Get(int id);
    }

}
