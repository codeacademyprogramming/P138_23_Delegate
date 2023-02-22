using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StoreApp
{
    internal class Store
    {
        public List<Product> Products = new List<Product>();

        public List<Product> GetProductsByPriceRange(double minPrice,double maxPrice)
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (Product p in Products)
            {
                if(p.Price>=minPrice && p.Price<=maxPrice)
                {
                    wantedProducts.Add(p);
                }
            }

            return wantedProducts;
        }

        public List<Product> GetDiscountedProducts()
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (Product p in Products)
            {
                if (p.DiscountPercent>0)
                {
                    wantedProducts.Add(p);
                }
            }

            return wantedProducts;
        }

        public List<Product> GetProductsByName(string name)
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (Product p in Products)
            {
                if (p.Name.Contains(name))
                {
                    wantedProducts.Add(p);
                }
            }

            return wantedProducts;
        }

        public List<Product> GetProducts(Predicate<Product> pred)
        {
            List<Product> wantedProducts = new List<Product>();

            foreach (Product p in Products)
            {
                if (pred(p))
                {
                    wantedProducts.Add(p);
                }
            }

            return wantedProducts;
        }

        public Product GetProductByNo(int no)
        {
            foreach (Product p in Products)
            {
                if (p.No == no)
                    return p;
            }

            return null;
        }

        public Product GetProduct(Predicate<Product> pred)
        {
            foreach (Product p in Products)
            {
                if (pred(p))
                    return p;
            }

            return null;
        }
    }
}
