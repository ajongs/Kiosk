using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_addChild
{
    public class Menu
    {
        public int code { set; get; }
        public string name { set; get; }
        public int price { set; get; }
        public Menu()
        {
            this.code = 0;
            this.name = "";
            this.price = 0;
        }
    }
}
