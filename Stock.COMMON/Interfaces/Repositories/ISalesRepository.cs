using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.COMMON.Entities;

namespace Stock.COMMON.Interfaces.Repositories
{
    public interface ISalesRepository : IUnitOfWork
    {
        Task Create(Sales sales);
        
        /*Task<List<Sales>> GetAllSales();
        Task<List<Sales>> GetSalesByMarcas(int sales);
        Task<List<Sales>> GetsalesByCatalogo(int generoId);*/
    }
}
