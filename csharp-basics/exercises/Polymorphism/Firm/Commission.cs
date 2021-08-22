using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission: Hourly
    {
        private double _commissionRate;
        private double _totalSale;
        private double _bonus;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,
            double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
            _totalSale = rate;
        }

        public void addSale(double totalSale)
        {
            _totalSale = totalSale;
        }

        public override double Pay()
        {
            var totalPay = base.Pay() + (_commissionRate * _totalSale);
            _totalSale = 0;
            return totalPay;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += $"\nTotal sale: {_totalSale} \nCommision rate: {_commissionRate}";
            return result;
        }

        public void AwardBonus(double execBonus)
        {
            _bonus = execBonus;
        }
    }
}
