using Microsoft.EntityFrameworkCore;
using WebAPIProject.Model;
using System.Collections.Generic;
using WebAPIProject.Model;

namespace WebAPIProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}