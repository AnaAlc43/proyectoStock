using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Controllers.ProductControllers
{
    public interface ICreateProductController
    {
        Task<WCreateDeleteProduct> CreateProvider (CreateProductRequest request);

    }
}
