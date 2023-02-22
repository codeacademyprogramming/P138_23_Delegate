using System;
using System.Collections.Generic;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            List<Product> discountedProducts = store.GetDiscountedProducts();
            discountedProducts = store.GetProducts(x => x.DiscountPercent > 0);

            List<Product> productsByPriceRange = store.GetProductsByPriceRange(10, 100);
            productsByPriceRange = store.GetProducts(x => x.Price >= 10 && x.Price <= 100);

            List<Product> productsByName = store.GetProductsByName("cola");
            productsByName = store.GetProducts(x => x.Name.Contains("cola"));


            Product prod = store.GetProductByNo(5);
            prod = store.GetProduct(x => x.No == 5);

            prod = store.GetProduct(x => x.Name == "Coca Cola 1L");

            List<int> nums = new List<int> { 43, 54, 66, 23, 6 };

            int num = nums.Find(x => x % 2 == 0);

            var wantedNums = nums.FindAll(x=>x % 2 == 0);

            List<Product> products = new List<Product>();
            products.Add(new Product("Product1") { Price = 45 });
            products.Add(new Product("Product2") { Price = 15 });
            products.Add(new Product("Product3") { Price = 25 });


            products.ForEach(x => x.Price = x.Price + 10);
            //nums.RemoveAll(x => x % 2 == 0);


            foreach (var item in products)
            {
                Console.WriteLine(item.Price);
            }

            Console.WriteLine(products.Exists(x=>x.Price>100));
        }
    }
}
