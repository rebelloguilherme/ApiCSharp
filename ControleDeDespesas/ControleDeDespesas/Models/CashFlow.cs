namespace ControleDeDespesas.Models
{
    public class CashFlow
    {
        private Person _person;
        private Account _account;
        private Income? _income;
        private Outcome? _outcome;

        public CashFlow(Person person, Account account)
        {
            _person = person;
            _account = account;
        }
    }
}
