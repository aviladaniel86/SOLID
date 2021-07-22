using SOLID.DIP.Interfaces;

namespace SOLID.DIP.Implementations
{
    public class Person : IPerson
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
