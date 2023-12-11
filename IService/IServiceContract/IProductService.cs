using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.IServiceContract
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        public void DeleteProduct(int Id);
        public void UpdateProduct(Product product);
        public Product GetProduct(int Id);
        public List<Product> GetProducts();
        public List<Product> GetProductsByCategoryId(int CategoryId);
    }
}
