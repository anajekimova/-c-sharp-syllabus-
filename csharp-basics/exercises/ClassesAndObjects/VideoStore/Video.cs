using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _avaible;
        private List<double>  _ratings;
        public Video(string title)
        {
            _title = title;
            _avaible = true;
            _ratings = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _avaible = false;
        }

        public void BeingReturned()
        {
            _avaible = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }

        public bool Available()
        {
            return _avaible;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
