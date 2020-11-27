using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chisu_Diana_Lab8.Models;

namespace Chisu_Diana_Lab8.Data
{
    public class Chisu_Diana_Lab8Context : DbContext
    {
        public Chisu_Diana_Lab8Context (DbContextOptions<Chisu_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Chisu_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Chisu_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Chisu_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
