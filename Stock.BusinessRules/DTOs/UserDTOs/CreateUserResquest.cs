using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.UserDTOs
{
    public class CreateUserResquest
    {
        public int Id { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }

    }
}
