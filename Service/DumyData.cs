using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class DumyData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product { Id = 1,Name="Redmi",CategoryId=2,Price=5000,Quantity=10,Rate=5},
            new Product { Id = 2,Name="Rtx5090ti",CategoryId=3,Price=100000,Quantity=10,Rate=5},
            new Product { Id = 3,Name="IPhone",CategoryId=2,Price=40000,Quantity=10,Rate=5},
            new Product { Id = 4,Name="Hdd 1Tb",CategoryId=4,Price=700,Quantity=10,Rate=5},
        };

        public static List<Category> categories = new List<Category>()
        {
            new Category{ Name= "Laptop",Description="Tech",Id=1},
            new Category{ Name= "Phone",Description="Tech",Id=2},
            new Category{ Name= "GraphicCards",Description="Tech",Id=3},
            new Category{ Name= "StorageDisk",Description="Tech",Id=4}
        };
        public static List<Rate> rates = new List<Rate>()
        {
            new Rate{
                Id=1,
                Comment="Comment Comment Comment Comment Comment Comment Comment Comment ",
                ProductId=3,
                ProductName="IPhone",
                RateNum=4
            },
            new Rate{
                Id=2,
                Comment="Comment Comment Comment Comment Comment Comment Comment Comment ",
                ProductId=3,
                ProductName="IPhone",
                RateNum=2.5
            },
            new Rate{
                Id=3,
                Comment="Comment Comment Comment Comment Comment Comment Comment Comment ",
                ProductId=3,
                ProductName="IPhone",
                RateNum=5
            },
            new Rate{
                Id=4,
                Comment="Comment Comment Comment Comment Comment Comment Comment Comment ",
                ProductId=3,
                ProductName="IPhone",
                RateNum=3.4
            },
        };

        public static List<Transaction> transactions = new List<Transaction>();
        //public static List<Account> accounts = new List<Account>()
        //{
        //    new Account{Id = new Guid(),Email="a@a.com",Name="Amr Shalaby",Phone=01152899886,Password="12345678"}
        //};
    }
}
