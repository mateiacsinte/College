using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Context
{
    class BusinessContext : DbContext
    {
        DbSet<Business> bus;
    }
}
