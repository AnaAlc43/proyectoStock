using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.SalesDTOs
{
    public class SalesHeaderDTO
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }

        public List<SalesOrderDetailDTO> SalesOrderDetails { get; set; }

    }
}
