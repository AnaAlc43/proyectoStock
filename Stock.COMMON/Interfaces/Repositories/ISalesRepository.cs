using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entities.Entities;

namespace Stock.COMMON.Interfaces.Repositories
{
    public interface ISalesRepository
    {
        Task<Sales> GetById(int saleId);
        Task Create(Sales sales);
        
        /*Task<List<Sales>> GetAllSales();
        Task<List<Sales>> GetSalesByMarcas(int sales);
        Task<List<Sales>> GetsalesByCatalogo(int generoId);*/
    }
}
