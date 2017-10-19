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

        // Korrekt
        public List<Product> GetProductByName(string substring)
        {
            List<Product> matchingProducts = null;

            using (var db = new NorthwindContext())
            {
                matchingProducts = db.Products.Where(x => x.Name.Contains(substring)).ToList();
                if (matchingProducts.Any())
                {

                    return matchingProducts.ToList();
                }
            }
            // return list of tuples even if null. Null should be checked 
            return null;
        }

        public List<Product> GetProductByCategory(int catId)
        {
            List<Product> matchingProducts = null;

            using (var db = new NorthwindContext())
            {
                matchingProducts = db.Products.Where(x => x.CategoryId == catId).ToList();
                if (matchingProducts.Any())
                {
                    return matchingProducts.ToList();
                }
            }
            // return list of tuples even if null. Null should be checked 
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
            Console.WriteLine(Orders);
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




        //måske problem med return
        public List<Category> GetCategories()
        {
            using (var db = new NorthwindContext())
            {
                var categories = db.Categories;

                return categories.ToList();
            }
            return null;
        }



        //Måske færdig tjek igen 
        public Category CreateCategory(String name, String description)
        {
            using (var db = new NorthwindContext())
            {
                var category = new Category
                {
                    Name = name,
                    Description = description
                };

                db.Categories.Add(category);

                db.SaveChanges();

                {
                    return category;
                }
            }
        }


        //Færdig
        public bool UpdateCategory(int id, string name, string description)
        {
            using (var db = new NorthwindContext())
            {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);

                if (category != null)
                {
                    category.Name = name;
                    category.Description = description;
                    return true;
                }
                db.SaveChanges();

            }

            return false;
        }
        //Færdig
        public bool DeleteCategory(int id)
        {

            using (var db = new NorthwindContext())
            {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);

                if (category != null)
                {
                    db.Categories.Remove(category);
                    return true;
                }
                db.SaveChanges();
            }

            return false;
        }




    }
}
