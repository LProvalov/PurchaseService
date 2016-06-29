using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.DAO.Interfaces
{
    public interface ICRUDBase<T>
    {
        bool Create(T entity);
        T Read(int entityId);
        bool Update(T entity);
        bool Delete(int entityId);
    }
}
