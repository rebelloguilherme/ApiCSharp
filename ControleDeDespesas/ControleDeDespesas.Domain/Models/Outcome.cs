namespace ControleDeDespesas.Domain.Models
{
    public class Outcome : Entity
    {
        public DateTime RegisterDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }

    }
}
