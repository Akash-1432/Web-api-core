using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodebaseCoreexam.Models;

namespace CodebaseCoreexam.Data
{
    public class CodebaseCoreexamContext : DbContext
    {
        public CodebaseCoreexamContext (DbContextOptions<CodebaseCoreexamContext> options)
            : base(options)
        {
        }

        public DbSet<CodebaseCoreexam.Models.Students>? Students { get; set; }
    }
}
