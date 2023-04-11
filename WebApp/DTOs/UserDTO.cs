using Domain.Enums;

namespace WebApp
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HouseUserType HouseUserType { get; set; }
    }
}
