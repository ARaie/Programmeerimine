using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReceipt
{
    class Tab
    {

        private List<double> Items = new List<double>();

        public void Add(double sum)
        {
            Items.Add(sum);
            
        }
        public override string ToString()
        {

            return $"Items sum: {Items.Count}";

        }
    }
}
