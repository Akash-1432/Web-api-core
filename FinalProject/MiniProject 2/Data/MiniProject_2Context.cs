using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProject_2.Models;

namespace MiniProject_2.Data
{
    public class MiniProject_2Context : DbContext
    {
        public MiniProject_2Context (DbContextOptions<MiniProject_2Context> options)
            : base(options)
        {
        }

        public DbSet<MiniProject_2.Models.Product>? Product { get; set; }
    }
}
