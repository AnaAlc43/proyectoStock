using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entities.Entities;

namespace Stock.Entities.Interfaces.Repositories
{
    public interface IProductRepository : IUnitOfWork
    {
        Task<Product> GetById(int productId);
        Task Create(Product product);
        Task Update(string nombre, string vencimiento, string lote);
        Task Delete(int product);
        Task<List<Product>> GetAllproducts();
    }
}