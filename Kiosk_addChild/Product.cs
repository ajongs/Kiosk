using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_addChild
{
    public class Product 
    {
        public int pcode;
        public string pname;

        public int pcount;

        public int price;
        public Product()
        {

        }
        public Product(int pcode, string pname, int num, int price)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.pcount = num;
            this.price = price;
        }
        public int GetPcode()
        {
            return pcode;
        }
        public void SetPcode(int pcode)
        {
            this.pcode = pcode;
        }
        public string GetPname()
        {
            return pname;
        }
        public void SetPanme(string pname)
        {
            this.pname = pname;
        }
        public int GetNum()
        {
            return pcount;
        }
        public void SetNum(int num)
        {
            this.pcount = num;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
    }
}
