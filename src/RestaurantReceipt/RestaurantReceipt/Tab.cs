using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReceipt
{
    public class Tab
    {

        public List<double> Items = new List<double>();

        public void Add(double sum)
        {
            Items.Add(sum);
            
        }
        
    }
}
