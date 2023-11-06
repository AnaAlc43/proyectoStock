using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;


namespace Stock.BusinessRules.Wrappers.Provider
{
    public class WCreateDeleteProvider : WBase
    {
        public int IdProvider { get; set; }
        public List<ValidationErrorDTOs> ValidationErrors { get; set; }
    }
}
