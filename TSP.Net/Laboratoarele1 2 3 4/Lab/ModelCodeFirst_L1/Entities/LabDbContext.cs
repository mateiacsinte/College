
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelCodeFirst_L1.Entities
{
    class LabDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
       public LabDbContext() 
        {

        }
        public System.Data.Entity.DbSet<Client> clients;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetails>()
            .HasOne<Order>(od => od.Order)
            .WithMany(o => o.OrderDetails);
            modelBuilder.Entity<Product>()
            .HasMany<OrderDetails>(p => p.OrderDetails)
            .WithOne(od => od.Product);
        }
    }
    


}
