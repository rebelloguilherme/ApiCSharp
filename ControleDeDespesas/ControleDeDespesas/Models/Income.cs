namespace ControleDeDespesas.Models
{
    public class Income : Entity
    {
        public DateTime RegisterDate { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }

    }
}
