using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.COMMON.Entities;
using Stock.COMMON.Interfaces;

namespace Stock.COMMON.Interfaces.Repositories
{
    public  interface IProductRepository : IUnitOfWork<Product>

    {
        Task<Product> GetById(int productId);

        Task Update(Product product);
        Task Delete(int actorId);
        Task<List<Actor>> GetAllActors();
    }
}