using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyMvcCrud1.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TFQ9M1R;Database=EmployDB;Integrated Security=true;");
                // need to add connection string here after that do migration.
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
