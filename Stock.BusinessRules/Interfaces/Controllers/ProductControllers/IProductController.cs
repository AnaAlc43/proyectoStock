using Stock.BusinessRules.DTOs.ProductDTOs;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Wrappers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.ProductControllers
{
    public interface IProductController
    {
        Task<WCreateDeleteProduct> CreateProvider (CreateProductRequest request);

    }
    public interface IDeleteProductController
    {
        Task<WDeleteProduct> DeleteProduct(int Id);
    }
    public interface IUpdateProductController
    {
        Task<WCreateDeleteProduct> UpdateProduct(UpdateProductRequest request);
    }
}
