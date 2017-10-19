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
                var Products = db.Products.Where(x => x.Id == prodId);
                if (Products.Any())
                {
                    return Products.First();
                }
            }
            return null;
        }

        public List<ValueTuple<string, string>> GetProductBySubstring(string substring)
        {
            List<ValueTuple<string, string>> returnTuples = null;
            List<Product> matchingProducts = null;

            using (var db = new NorthwindContext())
            {
                matchingProducts = db.Products.Where(x => x.Name.Contains(substring)).ToList();
                if (matchingProducts.Any())
                {
                    returnTuples = new List<(string, string)>();
                    foreach (var matchingProduct in matchingProducts)
                    {
                        returnTuples.Add(new ValueTuple<string, string>(matchingProduct.Name, matchingProduct.Category.Name));
                    }
                }
            }
            // return list of tuples even if null. Null should be checked 
            return returnTuples;
        }

        public List<ValueTuple<string, string>> GetProductsByCategoryId(int catId)
        {
            List<ValueTuple<string, string>> returnTuples = null;
            List<Product> matchingProducts = null;

            using (var db = new NorthwindContext())
            {
                matchingProducts = db.Products.Where(x => x.CategoryId == catId).ToList();
                if (matchingProducts.Any())
                {
                    returnTuples = new List<(string, string)>();
                    foreach (var matchingProduct in matchingProducts)
                    {
                        returnTuples.Add(new ValueTuple<string, string>(matchingProduct.Name, matchingProduct.Category.Name));
                    }
                }
            }
            // return list of tuples even if null. Null should be checked 
            return returnTuples;
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
