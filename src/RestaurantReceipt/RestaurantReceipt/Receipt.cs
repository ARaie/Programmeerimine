using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReceipt
{
    public class Receipt
    {

        private readonly string _name;

        private readonly string _address;

        private readonly Tab _tab;

        public Receipt(string name, string address, Tab tab)
        {
            this._name = name;
            this._address = address;
            this._tab = tab;

        }
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(_name + "\n");
            sb.Append(_address + "\n");
            sb.Append("---------------------------"+ "\n");

            foreach (var item in _tab.Items)
            {

                sb.Append("Price of food item: "+item + "\n");
            }

            return sb.ToString();
            
        }

    }
}