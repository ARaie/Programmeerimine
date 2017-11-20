using System;
using System.Collections.Generic;

namespace RestaurantReceipt
{
   public class Restaurant
    {


        public string Name { get; }

        public string Address { get; }

        public Restaurant(string name, string address)
        {
            this.Name = name;
            this.Address = address;
         
        }
        public Receipt GetReceipt(Tab tab)
        {

            return new Receipt(this.Name, this.Address, tab);
        }

    }
}