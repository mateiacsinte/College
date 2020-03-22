using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCodeFirst_L1.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set;}
        public ICollection<OrderDetails> OrderDetails;
    }
}
