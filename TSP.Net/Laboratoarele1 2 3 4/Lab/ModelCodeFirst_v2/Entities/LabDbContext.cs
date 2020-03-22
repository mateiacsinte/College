using Microsoft.EntityFrameworkCore;


namespace ModelCodeFirst_L1.Entities
{
    class LabDbContext: DbContext
    {
        public LabDbContext() : base()
        {

        }
        public DbSet<Person> Persons;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-8QP7DJ6;Database=LabCodeFirst;Trusted_Connection=True;");
        }

    }

}
