using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster: Advert
    {
        private int _height;
        private int _widht;
        private int _copies;
        private int _costPerCoppy;

        public Poster(int fee): base (fee)
        {

        }

        public Poster(int fee, int height, int widht, int copies, int costPerCopy): base(fee)
        {
            _height = height;
            _widht = widht;
            _copies = copies;
            _costPerCoppy = costPerCopy;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            fee += _copies * _costPerCoppy;
            return fee;
        }

        public override string ToString()
        {
            return $"\nPoster:Cost {base.Cost()}";
        }

    }
}
