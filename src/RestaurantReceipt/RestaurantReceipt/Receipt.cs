using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReceipt
{
    public class Receipt
    {
        
        public string Name { get; }

        public string Address { get; }

        public Tab Tab { get; }

        public Receipt(string name, string address, Tab tab)
        {
            this.Name = name;
            this.Address = address;
            this.Tab = tab;

        }
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + "\n");
            sb.Append(Address + "\n");
            sb.Append("---------------------------"+ "\n");

            foreach (var item in Tab.Items)
            {

                sb.Append("Price of food item: "+item + "\n");
            }

            return sb.ToString();
            
        }

    }
}