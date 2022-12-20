using Microsoft.EntityFrameworkCore;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=RAMAZANSURUCU; initial catalog=UpSchoolCQRS; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
