using System.Collections.Generic;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;

namespace Stock.BusinessRules.Wrappers.User
{
    public class WCreateDeleteUser : WBase
    {
        public int IdUser { get; set; }
        public List<ValidationErrorDTOs> ValidationErrors { get; set; }
    }
}
