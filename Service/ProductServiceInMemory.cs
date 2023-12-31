﻿using Core;
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
            products = DumyData.Products;
        }
        public void AddProduct(Product product)
        {
            if (products != null && products.Count() > 0 && product != null)
            {
                var id = products.Max(p => p.Id);
                product.Id = id + 1;
                products.Add(product);
            }
            else if (product != null && products != null && products.Count() == 0)
            {
                product.Id = 1;
                products.Add(product);
            }
            
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
