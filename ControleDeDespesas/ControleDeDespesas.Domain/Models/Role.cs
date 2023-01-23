namespace ControleDeDespesas.Domain.Models
{
    public enum Permission
    {
        Admin,
        User
    }
    public class Role
    {
        public Permission Permission { get; set; }
    }
}
