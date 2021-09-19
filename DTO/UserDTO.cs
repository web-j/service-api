using DTO.Base;

namespace DTO
{
    public class UserDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
