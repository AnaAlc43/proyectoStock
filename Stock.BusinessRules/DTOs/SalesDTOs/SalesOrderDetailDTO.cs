using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.SalesDTOs
{
    public class SalesOrderDetailDTO
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
    }
}
