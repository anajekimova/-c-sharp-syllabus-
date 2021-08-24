using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
     abstract class Felime: Mammal
    {

       protected Felime(string name, int weight, string type, string region):
            base(name, weight, type, region)
        {

        }
    }
}
