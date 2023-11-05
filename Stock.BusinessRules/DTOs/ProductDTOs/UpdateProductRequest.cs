using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.ProductDTOs
{
    public class UpdateProductRequest
    {
        public int Id { get; set;}
        public int ProductName { get; set;}
    }
}
