using System;
using System.Collections.Generic;
using System.Text;

namespace GitAantoning
{
    public class RandomClass
    {
        public int EenProperty { get; set; }

        public RandomClass(int eenProperty)
        {
            EenProperty = eenProperty;
        }

        public int MaakGetalletje(int seed)
        {
            Random rnd = new Random(EenProperty);
            return rnd.Next(5);
        }
    }
}
