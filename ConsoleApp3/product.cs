using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class product
    {
       public string Name { get; set; }
       public string price { get; set; }
       public string description { get; set; }
       public string priceType { get; set; }

        public product(string name, string price, string description, string priceType)
        {
            Name = name;
            this.price = price;
            this.description = description;
            this.priceType = priceType;
        }

    }
    class items : product
    {
        public string powerOfitem { get; set; }
        public items(string name, string price, string description, string priceType, string powerOfitem) : base(name, price, description, priceType)
        {
            this.powerOfitem = powerOfitem;

        }
        

        
    }
}
