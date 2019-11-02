using ProjectStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStore
{
    public class ProductManager : DataBaseManager
    {
        private static ProductManager _instance;

        public static ProductManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProductManager();
            }
            return _instance;
        }

        public ProductManager():base()
        {/*
            ProductList = new List<Product>();
        */
            ProductList = FineBurgerContext.Products.ToList();
        }

        public List<Product> ProductList { get; set; }

        public void AddList(Product newProduct)
        {
            FineBurgerContext.Products.Add(newProduct);
            FineBurgerContext.SaveChanges();
            ProductList = FineBurgerContext.Products.ToList();
        }

        internal void RemoveList(string buttonValue)
        {
            var productForDelete = ProductList.First(u => u.BarCode.Equals(int.Parse(buttonValue)));
            FineBurgerContext.Products.Remove(productForDelete);
            FineBurgerContext.SaveChanges();
            ProductList = FineBurgerContext.Products.ToList();
        }
    }
}
