using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApp1
{
    public class OrdersController:ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1,Name ="Tomato soup", Category = "Groceries", Price = 1},
            new Order { Id = 2,Name ="Yo-yo", Category = "Toys", Price = 3.75M},
            new Order { Id = 3,Name ="Hammer", Category = "Hardware", Price = 16.99M},
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

    }

    public class Order
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string  Category { get; set; }
        public decimal Price { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductsCotnroller : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id= 1, Name= "p1"},
            new Product{Id= 2, Name= "p2"},
            new Product{Id= 3, Name= "p3"},
        };


        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}
