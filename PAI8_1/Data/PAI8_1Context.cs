using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PAI8_1.Models;

namespace PAI8_1.Data
{
    public class PAI8_1Context : DbContext
    {
        public PAI8_1Context (DbContextOptions<PAI8_1Context> options)
            : base(options)
        {
        }

        public DbSet<PAI8_1.Models.Movie> Movie { get; set; }
    }
}
