namespace ControleDeDespesas.Models
{
    public class Account : Entity
    {
        public string BankName { get; set; }
        public string AgencyNumber { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
