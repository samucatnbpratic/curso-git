﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleComparison.Entities
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
