using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Models
{
    public class EmployeeDBcontext : DbContext
    {
        public EmployeeDBcontext(DbContextOptions<EmployeeDBcontext>options):base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
