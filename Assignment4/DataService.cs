using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    public class DataService
    {

        // --- GetCategory_ValidId_ReturnsCategoryObject() --- //
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

        // --- GetProduct_ValidId_ReturnsProductWithCategory() --- //
        public Product GetProduct(int prodId)
        {
            using (var db = new NorthwindContext())
            {
                List<Product> Products = (List<Product>)db.Products.Where(x => x.Id == prodId);
                if (Products.Any())
                {
                    return Products[0];
                }
            }
            return null;
        }


        // --- public void GetOrder_ValidId_ReturnsCompleteOrder() --- //
        public Order GetOrder(int orderId)
        {
            var db = new NorthwindContext();
            var test = db.Orders.FirstOrDefault(
                x => x.Id == orderId);
            return test;
        }

        // --- public void GetOrders() --- //
        public List<Order> GetOrders()
        {
            var db = new NorthwindContext();
            List<Order> Orders = db.Orders.ToList();
            return Orders;
        }

        public OrderDetails GetOrderDetailsByOrderId(int orderId)
        {
            return new OrderDetails();
        }

        public OrderDetails GetOrderDetailsByProductId(int productId)
        {
            return new OrderDetails();
        }

    }
}
