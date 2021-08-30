namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _liters;
        private double _startKilometers;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return _startKilometers / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return _liters / CalculateConsumption();
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15)
                return true;
            else
                return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
                return true;
            else
                return false;
        }

        public void FillUp(double mileage, double liters)
        {
            _liters += liters;
            _startKilometers += mileage;
        }
    }
}
