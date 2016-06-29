using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.DAO.Models
{
    public class Commodity : BaseCommodity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Update(Commodity entity)
        {
            this.Name = entity.Name;
            this.Description = entity.Description;
        }
    }
}
