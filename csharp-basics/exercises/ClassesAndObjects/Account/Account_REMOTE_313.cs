namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
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
    }
}
