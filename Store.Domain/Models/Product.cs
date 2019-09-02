﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public string Category { get; set; }

        public ICollection<Stock> Stock { get; set; }       
    }
}
