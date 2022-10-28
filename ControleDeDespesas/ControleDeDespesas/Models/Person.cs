namespace ControleDeDespesas.Models
{
    public class Person : Entity
    {
        public string Document {get; set;}
        public string Name { get; set; }
        public string Password { get; set; }
        private Role _role;

        public Person(string document, string name, string password, Role role)
        {
            Document = document;
            Name = name;
            Password = password;
            _role = role;
        }


    }
}
