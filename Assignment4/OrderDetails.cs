﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Data.SqlTypes;

namespace Assignment4
{
    public class OrderDetails
    {
        [Column("orderid")]

        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public double Discount { get; set; }

        public double UnitPrice { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }
    
        public OrderDetails First()
        {
            return new OrderDetails();
        }
    
    }
}
