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
    }
}
