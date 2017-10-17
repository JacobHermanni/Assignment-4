using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment4
{
    public class Order
    {
        [Column("orderid")]

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Required { get; set; }

        public OrderDetails OrderDetails { get; set; }

        public string ShipName { get; set; }

        public string ShipCity { get; set; }
    }
}
