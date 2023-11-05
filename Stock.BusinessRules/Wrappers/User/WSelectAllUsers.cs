using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;

namespace Stock.BusinessRules.Wrappers.User
{
    public class WSelectAllUsers : WBase
    {
        public List<UserResponse> Users { get; set; } = new List<UserResponse>();

    }
}
