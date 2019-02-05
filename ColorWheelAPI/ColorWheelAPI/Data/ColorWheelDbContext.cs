using ColorWheelAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorWheelAPI.Data
{
    public class ColorWheelDbContext : DbContext
    {
        /// <summary>
        /// Database is being constructed with the color information to go into the database tables.
        /// </summary>
        /// <param name="options"></param>
        public ColorWheelDbContext(DbContextOptions<ColorWheelDbContext> options) : base(options)
        {
 
        }
        public DbSet<Analogous> Analogous { get; set; }
        public DbSet<Complimentary> Complimentary { get; set; }
        public DbSet<Monochromatic> Monochromatic { get; set; }
        public DbSet<SplitComplimentary> SplitComplimentary { get; set; }
        public DbSet<Tetradic> Tetradic { get; set; }
        public DbSet<Triadic> Triadic { get; set; }
    }
}
