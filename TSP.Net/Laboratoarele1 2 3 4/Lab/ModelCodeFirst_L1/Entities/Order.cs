using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCodeFirst_L1.Entities
{
    public class Order
    {
        public int Id { get; set; }
    
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Client Client { get; set; }
    }
}
