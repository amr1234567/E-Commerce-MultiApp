using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductServiceInMemory : IProductService
    {
        private List<Product> products;
        public ProductServiceInMemory()
        {
            products = new List<Product>()
            {
                new Product { Id = 1,Name="Redmi",CategoryId=2,Price=5000,Quantity=10,Rate=5},
                new Product { Id = 2,Name="Rtx5090ti",CategoryId=3,Price=100000,Quantity=10,Rate=5},
                new Product { Id = 3,Name="IPhone",CategoryId=2,Price=40000,Quantity=10,Rate=5},
                new Product { Id = 4,Name="Hdd 1Tb",CategoryId=4,Price=700,Quantity=10,Rate=5},
            };
        }
        public void AddProduct(Product product)
        {
            if (products != null)
                products.Add(product);
        }

        public void DeleteProduct(int Id)
        {
           var product = GetProduct(Id);
            if (product != null)
                products.Remove(product);
        }

        public Product GetProduct(int Id)
        {
            var product = products.FirstOrDefault(x => x.Id == Id);
            return product;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Product> GetProductsByCategoryId(int CategoryId)
        {
            var ReturnProducts = products.Where(p=>p.CategoryId == CategoryId);
            if (ReturnProducts.Count() > 0 && ReturnProducts != null)
                return ReturnProducts.ToList();
            else
                return null;
        }

        public void UpdateProduct(Product product)
        {
            if (product != null)
            {
                var originalProduct = GetProduct(product.Id);
                if(originalProduct != null)
                {
                    originalProduct.Price = product.Price;
                    originalProduct.Quantity = product.Quantity;
                    originalProduct.Rate = product.Rate;
                    originalProduct.Name = product.Name;
                }
            }
        }
    }
}
