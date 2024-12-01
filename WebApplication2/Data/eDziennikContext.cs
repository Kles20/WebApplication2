using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eDziennik.Models;

namespace eDziennik.Data
{
    public class eDziennikContext : DbContext
    {
        public eDziennikContext (DbContextOptions<eDziennikContext> options)
            : base(options)
        {
        }

        public DbSet<eDziennik.Models.Grade> Grade { get; set; } = default!;
    }
}
