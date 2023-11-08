using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.COMMON.Entities;

namespace Stock.COMMON.Interfaces.Repositories
{
    public interface IProductRepository : IUnitOfWork
    {
        Task Create(Product product);
        Task Update(string nombre, string vencimiento, string lote);
        Task Delete(int product);
        Task<List<Product>> GetAllproducts(int product);
    }
}