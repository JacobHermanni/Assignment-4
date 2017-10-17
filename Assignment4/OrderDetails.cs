using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class OrderDetails
    {
        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public double Discount { get; set; }

        public double UnitPrice { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

    }
}
