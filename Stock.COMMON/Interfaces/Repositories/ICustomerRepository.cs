using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.COMMON.Entities;


namespace Stock.COMMON.Interfaces.Repositories
{
    public interface ICustomerRepository
    {

        Task Create(Customer cliente);
        Task Delete(int clienteId);
        Task<List<Customer>> GetAllClientesAsync(int Customer);

        //ActualizacionesParaLasVacaciones       
        //Task<Customer> GetClienteByIdAsync(int id);
        //Task<Customer> AddClienteAsync(Customer cliente);
        //Task UpdateClienteAsync(Customer cliente);
        //Task DeleteClienteAsync(int id);
    }
}
