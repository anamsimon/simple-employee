using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace Employee.Web.Data
{
    public class EmployeeWebContext : DbContext
    {
        public EmployeeWebContext (DbContextOptions<EmployeeWebContext> options)
            : base(options)
        {
        }

        public DbSet<Employee.Models.Employee> Employee { get; set; }
    }
}
