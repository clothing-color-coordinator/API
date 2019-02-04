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


        /// <summary>
        /// This method allows us to seed data in the database when the table is added
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(
                new Color { ID = 1, ColorName = "Yellow", HexCode = "#FEFE33" },
                new Color { ID = 2, ColorName = "Yellow-Green", HexCode = "#B2D732" },
                new Color { ID = 3, ColorName = "Green", HexCode = "#66B032" },
                new Color { ID = 4, ColorName = "Blue-Green", HexCode = "#347C98" },
                new Color { ID = 5, ColorName = "Blue", HexCode = "#0247FE" },
                new Color { ID = 6, ColorName = "Blue-Violet", HexCode = "#4424D6" },
                new Color { ID = 7, ColorName = "Violet", HexCode = "#8601AF" },
                new Color { ID = 8, ColorName = "Red-Violet", HexCode = "#C21460" },
                new Color { ID = 9, ColorName = "Red", HexCode = "#FE2712" },
                new Color { ID = 10, ColorName = "Red-Orange", HexCode = "#FC600A" },
                new Color { ID = 11, ColorName = "Orange", HexCode = "#FB9902" },
                new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" }
            );

            modelBuilder.Entity<Analogous>().HasData(

            );
        }
    }
}
