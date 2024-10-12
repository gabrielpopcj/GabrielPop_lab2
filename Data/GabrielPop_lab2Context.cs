using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GabrielPop_lab2.Models;

namespace GabrielPop_lab2.Data
{
    public class GabrielPop_lab2Context : DbContext
    {
        public GabrielPop_lab2Context (DbContextOptions<GabrielPop_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<GabrielPop_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<GabrielPop_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
