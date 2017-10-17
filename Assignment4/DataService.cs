using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    public class DataService
    {
        public Category GetCategory(int catId)
        {
            using (var db = new NorthwindContext())
            {
                List<Category> Categories = (List<Category>)db.Categories.Where(x => x.Id == catId);
                if (Categories.Any())
                {
                    return Categories[0];
                }
            }

            return null;
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

        // Test Theis
    }
}
