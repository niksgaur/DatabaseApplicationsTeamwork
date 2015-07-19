﻿using System.Collections.Generic;

namespace MS_SQL_Server.Models
{
    public class Measure
    {
        private ICollection<Product> products;

        public Measure()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string MeasureName { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
    }
}