using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ImageProd { get; set; }
        public Categories Category { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
