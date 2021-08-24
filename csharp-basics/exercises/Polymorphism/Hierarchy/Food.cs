using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Food
    {
        public int Quantity { get; }

        protected Food (int quantity)
        {
            Quantity = quantity;
        }

    }
}
