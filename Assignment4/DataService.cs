using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                var Categories = db.Categories.Where(x => x.Id == catId);
                if (Categories.Any())
                {
                    return Categories.First();
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
