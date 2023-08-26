using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DataContext
{
    public class DataContexts : DbContext
    {
        public DataContexts(DbContextOptions<DataContexts> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
