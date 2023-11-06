using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.CustomerControllers
{
    public interface ICreateCustomerControllers
    {
        // La interfaz "ICreateCustomerControllers" define un contrato para las clases que
        // implementan la creación de un nuevo cliente en el sistema.
        
        // Las clases que implementen esta interfaz deben proporcionar una implementación
        // para el método "CreateCustomer" que cumpla con el contrato establecido por la interfaz.
        Task<WCreateDeleteCustomer> CreateCustomer(CreateCustomerRequest request);
    }
}
