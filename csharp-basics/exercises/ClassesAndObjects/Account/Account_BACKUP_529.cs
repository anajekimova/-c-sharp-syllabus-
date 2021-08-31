namespace Account
{
    public class AccountPersone
    {
        private string _name;
        private double _money;

<<<<<<< HEAD
        public AccountPersone(string name, double money)
=======
        public Account(string name, double money)
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public void Deposit(double i)
        {
            _money += i;
        }

        public double Balance()
        {
            return _money;
        }
<<<<<<< HEAD

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
=======
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0
    }
}
