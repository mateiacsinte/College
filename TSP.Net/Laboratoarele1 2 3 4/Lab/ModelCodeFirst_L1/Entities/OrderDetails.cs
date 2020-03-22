using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCodeFirst_L1.Entities
{
    public class OrderDetails
    {
        public string Description { get; set;}
        public Order Order;
        public Product Product;
    }
}
