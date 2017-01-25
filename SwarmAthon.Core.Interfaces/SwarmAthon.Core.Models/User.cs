using SwarmAthon.Core.Interfaces.Models;

namespace SwarmAthon.Core.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
