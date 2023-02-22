using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    internal class Product
    {
        static int _count;
        public Product(string name)
        {
            _count++;
            No = _count;
            Name = name;
        }

        public int No;
        public readonly string Name;
        public double Price;
        public double DiscountPercent;
    }
}
