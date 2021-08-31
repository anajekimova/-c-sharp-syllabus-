using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Date
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
