using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        //T Find(int id);
        //List<T> GetAll(int pageNumber, string pageSize);
        //bool Update(T entity);
        //bool Save(T entity);
        //bool Delete(int id, Int64 modifiedBy);
    }
}
