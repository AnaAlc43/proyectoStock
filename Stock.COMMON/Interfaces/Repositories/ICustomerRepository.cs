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
        //El propósito de esto es definir un contrato para interactuar con una base de datos
        //en el contexto de un repositorio de clientes (ICustomerRepository).
        //Este repositorio proporciona una interfaz común para que las clases que lo implementan
        //realicen operaciones de base de datos, como crear, eliminar y obtener clientes.

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
