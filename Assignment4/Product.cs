using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment4
{
    public class Product
    {
        [Column("productid")]

        public int Id { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public string QuantityPerUnit { get; set; }

        public int UnitsInStock { get; set; }

        public Category Category { get; set; }
    }
}
