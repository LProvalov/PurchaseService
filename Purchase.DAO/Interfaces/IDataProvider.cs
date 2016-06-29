using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.DAO.Interfaces
{
    public interface IDataProvider<T> : ICRUDBase<T>
    {
        IList<T> GetList();
        T GetByName(string name);
    }
}
