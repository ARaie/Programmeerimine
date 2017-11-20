using System;
using System.Collections.Generic;

namespace RestaurantReceipt
{
    class Receipt
    {


        public Receipt(string name, string address, Tab tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine("Prce of food item: " +item);
            }

        }


    }
}