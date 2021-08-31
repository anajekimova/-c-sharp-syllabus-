using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
<<<<<<< HEAD
    public class Date
=======
    class Date
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int GetDay()
        {
            return _day;
        }

        public int GetMonth()
        {
            return _month;
        }

        public int GetYear()
        {
            return _year;
        }

        public string PrintDays()
        {
            return $"{_day} / {_month} / {_year}";
        }
    }
}
