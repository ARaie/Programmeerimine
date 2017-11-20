using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReceipt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco Palenque", "1200 Main ST.");
            
            
            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);
            
            Receipt receipt = restaurant.GetReceipt(tab);
            
            Console.Write(receipt);
            Console.WriteLine("---------------------------" + "\n");

           double total = 0;
            foreach(var item in tab.Items)
            {
                total = total + item;
            }
            Console.WriteLine("Subtotal: € " + Math.Round(total, 2));
            double ale = total * 0.15;
            Console.WriteLine("15.00 % Gratuity: € " + Math.Round(ale, 2));
            Console.WriteLine("Total: € " + (Math.Round(total, 2) - Math.Round(ale, 2)));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}