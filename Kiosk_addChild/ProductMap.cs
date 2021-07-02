using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_addChild
{
    public class ProductMap
    {
        public Dictionary<String, Product> Map = new Dictionary<string, Product>();

        public ProductMap()
        {

        }
        public Product GetProduct(String name)
        { 
            return Map[name];
        }
        public void SetProduct(String name, Product product)
        {
            Map.Remove(name);
            Map.Add(name, product);
        }
        public void DeleteProduct(String name)
        {
            Map.Remove(name);
        }
        public List<Product> showAll()
        {
            List<Product> list = new List<Product>();
            foreach (Product item in Map.Values)
            {
                list.Add(item);
            }
            return list;
        }
        public List<Product> deleteAll()
        {

            foreach (var item in Map.ToList())
            {
                Map.Remove(item.Key);

            }
            List<Product> list = new List<Product>();
            foreach (Product item in Map.Values)
            {
                list.Add(item);
            }
            return list;
        }
        public void modify(Product product)
        {
            Map[product.GetPname()].SetNum(product.GetNum());
        }
    }
}
