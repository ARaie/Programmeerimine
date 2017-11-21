using System;
using System.Collections.Generic;

namespace RestaurantReceipt
{
   public class Restaurant
    {


        private readonly string _name;

        private readonly string _address;
        

        public Restaurant(string name, string address)
        {
            this._name = name;
            this._address = address;
         
        }
        public Receipt GetReceipt(Tab tab)
        {

            return new Receipt(_name, _address, tab);
        }

    }
}