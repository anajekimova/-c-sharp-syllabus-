namespace AdApp
{
    public class Hoarding: Advert
    {
        
        //per day
        private int _numDays;
        private int _surCharge;
        private bool _isPrimeLocation;

        public Hoarding(int fee) : base(fee)
        {
        }

        public Hoarding(int fee, int days, int surCharge, bool isPrimeLocation = false) : base(fee)
        {
            _numDays = days;
            _surCharge = surCharge;
            _isPrimeLocation = isPrimeLocation;
        }

        public new int Cost() 
        {
            var cost = base.Cost() * _numDays;

            if (_isPrimeLocation)
                cost += _surCharge;
                return cost; 
        }

        public override string ToString() 
        {
            return "\nHoarding:";
        }
    }
}