namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTime;
        private int _peekTime;
        private bool _hasPeekTime;

        public TVAd(int fee) : base(fee)
        {
        }

        public TVAd(int fee, int airTime, int peekTime, bool hasPeekTime = false)
        {
            _airTime = airTime;
            _hasPeekTime = hasPeekTime;
            _peekTime = peekTime;
        }     
        public new int Cost() 
        {
            var free = base.Cost();
            var cost = (_airTime - _peekTime) * free; 
            if(_hasPeekTime)
               cost += free * _peekTime *2;
            return cost;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}