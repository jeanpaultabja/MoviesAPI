using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data
{
    public class MoviesAPIDBContext : DbContext
    {
        public MoviesAPIDBContext (DbContextOptions<MoviesAPIDBContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesAPI.Models.Movies> Movies { get; set; }
    }
}
