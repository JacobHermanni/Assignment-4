using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    public class DataService
    {
        public Category GetCategory(int catId)
        {
            return new Category();
        }

        public Product GetProduct(int catId)
        {
            return new Product();
        }

        public Order GetOrder(int catId)
        {
            return new Order();
        }

        public List<Order> GetOrders()
        { 
            return new List<Order>();
        }

        public List<OrderDetails> GetOrderDetailsByOrderId(int orderId)
        {
            return new List<OrderDetails>();
        }

        public List<OrderDetails> GetOrderDetailsByProductId(int productId)
        {
            return new List<OrderDetails>();
        }
    }
}
