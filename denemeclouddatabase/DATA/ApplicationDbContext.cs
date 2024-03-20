using Microsoft.EntityFrameworkCore;

namespace denemeclouddatabase.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data ekleme
            modelBuilder.Entity<Employee>().HasData(

                 new Employee { Id = 1, Name = "John", Surname = "Doe", Age = 30 },
                 new Employee { Id = 2, Name = "Jane", Surname = "Smith", Age = 25 },
                 new Employee { Id = 3, Name = "Michael", Surname = "Johnson", Age = 35 },
                 new Employee { Id = 4, Name = "Emily", Surname = "Brown", Age = 28 },
                 new Employee { Id = 5, Name = "James", Surname = "Wilson", Age = 32 },
                 new Employee { Id = 6, Name = "Emma", Surname = "Jones", Age = 29 },
                 new Employee { Id = 7, Name = "William", Surname = "Taylor", Age = 31 },
                 new Employee { Id = 8, Name = "Olivia", Surname = "Anderson", Age = 27 },
                 new Employee { Id = 9, Name = "Alexander", Surname = "Thomas", Age = 33 },
                 new Employee { Id = 10, Name = "Sophia", Surname = "Martinez", Age = 26 }
                 );
        }
    }
}




