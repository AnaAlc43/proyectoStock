using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.ProductControllers
{
    public class IDeleteProductController
    {
        public interface IDeleteProductController
        {
            Task<WDeleteProduct> DeleteProduct(int Id);
        }
}
