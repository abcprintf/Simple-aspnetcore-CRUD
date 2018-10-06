using EmpApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpApp.EmpDataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}