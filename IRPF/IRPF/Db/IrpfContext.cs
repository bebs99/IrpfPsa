using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace IRPF.Db
{
    public class IrpfContext: DbContext
    {
            public DbSet<User> Users { get; set; }
            public DbSet<Deduction> Deductions { get; set; }
            public DbSet<Declaration> Declarations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBIrpf;Trusted_Connection=True;");
            }
    }
}
