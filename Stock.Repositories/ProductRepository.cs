using Stock.COMMON.Interfaces;
using Stock.COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public List<Product> Read => throw new NotImplementedException();

        public bool Create(Product entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product originalEntity, Product modifiedEntity)
        {
            throw new NotImplementedException();
        }
    }
}
