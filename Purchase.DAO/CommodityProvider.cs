using Purchase.DAO.Interfaces;
using Purchase.DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.DAO
{
    public class CommodityProvider : IDataProvider<Commodity>
    {
        private PurchaseDBContext _context = new PurchaseDBContext();

        public bool Create(Commodity entity)
        {
            _context.Commodities.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int entityId)
        {
            Commodity current = _context.Commodities
                .Where(c => c.Id == entityId)
                .FirstOrDefault();
            if (current != null)
            {
                _context.Commodities.Remove(current);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Commodity GetByName(string name)
        {
            return _context.Commodities
                .Where(c => c.Name.ToLower().Equals(name.ToLower()))
                .FirstOrDefault();
        }

        public IList<Commodity> GetList()
        {
            return _context.Commodities.ToList();
        }

        public Commodity Read(int entityId)
        {
            return _context.Commodities
                .Where(c => c.Id == entityId).FirstOrDefault();
        }

        public bool Update(Commodity entity)
        {
            Commodity current = _context.Commodities
                .Where(c => c.Id == entity.Id).FirstOrDefault();
            if (current != null)
            {
                current.Update(entity);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
