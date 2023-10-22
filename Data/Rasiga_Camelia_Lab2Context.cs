using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rasiga_Camelia_Lab2.Models;

namespace Rasiga_Camelia_Lab2.Data
{
    public class Rasiga_Camelia_Lab2Context : DbContext
    {
        public Rasiga_Camelia_Lab2Context (DbContextOptions<Rasiga_Camelia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rasiga_Camelia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rasiga_Camelia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Rasiga_Camelia_Lab2.Models.Author>? Author { get; set; }
    }
}
