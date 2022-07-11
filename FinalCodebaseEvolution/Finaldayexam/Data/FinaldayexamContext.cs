using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finaldayexam.Models;

namespace Finaldayexam.Data
{
    public class FinaldayexamContext : DbContext
    {
        public FinaldayexamContext (DbContextOptions<FinaldayexamContext> options)
            : base(options)
        {
        }

        public DbSet<Finaldayexam.Models.Employee>? Employee { get; set; }
    }
}
