using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
<<<<<<< HEAD
    public class Product
=======
    class Product
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0
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

<<<<<<< HEAD
        public  string PrintPrice()
        {
            return $"{_name}, {_priceAtStart} EUR, {_amountAtStart} units.";
=======
        public void PrintPrice()
        {
            Console.WriteLine($"{_name}, {_priceAtStart} EUR, {_amountAtStart} units.");
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0
        }
    }
}
