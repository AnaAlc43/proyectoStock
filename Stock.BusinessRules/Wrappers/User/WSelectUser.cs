using Stock.BusinessRules.DTOs.UserDTOs;

namespace Stock.BusinessRules.Wrappers.User
{
    public class WSelectUser : WBase
    {
        public UserResponse User { get; set; }
        public int IdUser { get; set; }
        public string NombreUser { get; set; }
    }
}
