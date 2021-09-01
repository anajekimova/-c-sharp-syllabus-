using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double price, int amount)
        {
            _name = name;
            _priceAtStart = price;
            _amountAtStart = amount;
        }

        public void ChangePrice(double price)
        {
            _priceAtStart = price;
        }

        public void ChangeAmount(int amount)
        {
            _amountAtStart = amount; 
        }

        public  string PrintPrice()
        {
            return $"{_name}, {_priceAtStart} EUR, {_amountAtStart} units.";
        }
    }
}
