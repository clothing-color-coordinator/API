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
        /// Database is constructed with the color information to go into the database tables.
        /// </summary>
        /// <param name="options"></param>
        public ColorWheelDbContext(DbContextOptions<ColorWheelDbContext> options) : base(options)
        {
 
        }


        /// <summary>
        /// This method allows seed data to be inserted into database when a migration is run
        /// </summary>
        /// 
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analogous>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID, ce.ColorThreeID });
            modelBuilder.Entity<Complementary>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID });
            modelBuilder.Entity<Monochromatic>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID });
            modelBuilder.Entity<SplitComplementary>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID, ce.ColorThreeID });
            modelBuilder.Entity<Tetradic>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID, ce.ColorThreeID, ce.ColorFourID });
            modelBuilder.Entity<Triadic>().HasKey(ce => new { ce.ColorOneID, ce.ColorTwoID, ce.ColorThreeID });

            modelBuilder.Entity<Color>()
                .HasData(
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
                    new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" });

            modelBuilder.Entity<Analogous>()
                .HasData(
                    new Analogous { ID = 1, ColorOneID = 1, ColorTwoID = 2, ColorThreeID = 12 },
                    new Analogous { ID = 2, ColorOneID = 2, ColorTwoID = 3, ColorThreeID = 1 },
                    new Analogous { ID = 3, ColorOneID = 3, ColorTwoID = 4, ColorThreeID = 2 },
                    new Analogous { ID = 4, ColorOneID = 4, ColorTwoID = 5, ColorThreeID = 3 },
                    new Analogous { ID = 5, ColorOneID = 5, ColorTwoID = 6, ColorThreeID = 4 },
                    new Analogous { ID = 6, ColorOneID = 6, ColorTwoID = 7, ColorThreeID = 5 },
                    new Analogous { ID = 7, ColorOneID = 7, ColorTwoID = 8, ColorThreeID = 6 },
                    new Analogous { ID = 8, ColorOneID = 8, ColorTwoID = 9, ColorThreeID = 7 },
                    new Analogous { ID = 9, ColorOneID = 9, ColorTwoID = 10, ColorThreeID = 8 },
                    new Analogous { ID = 10, ColorOneID = 10, ColorTwoID = 11, ColorThreeID = 9 },
                    new Analogous { ID = 11, ColorOneID = 11, ColorTwoID = 12, ColorThreeID = 10 },
                    new Analogous { ID = 12, ColorOneID = 12, ColorTwoID = 1, ColorThreeID = 11 });

            modelBuilder.Entity<Complementary>()
                .HasData(
                    new Complementary { ID = 1, ColorOneID = 1, ColorTwoID = 7 },
                    new Complementary { ID = 2, ColorOneID = 2, ColorTwoID = 8 },
                    new Complementary { ID = 3, ColorOneID = 3, ColorTwoID = 9 },
                    new Complementary { ID = 4, ColorOneID = 4, ColorTwoID = 10 },
                    new Complementary { ID = 5, ColorOneID = 5, ColorTwoID = 11 },
                    new Complementary { ID = 6, ColorOneID = 6, ColorTwoID = 12 },
                    new Complementary { ID = 7, ColorOneID = 7, ColorTwoID = 1 },
                    new Complementary { ID = 8, ColorOneID = 8, ColorTwoID = 2 },
                    new Complementary { ID = 9, ColorOneID = 9, ColorTwoID = 3 },
                    new Complementary { ID = 10, ColorOneID = 10, ColorTwoID = 4 },
                    new Complementary { ID = 11, ColorOneID = 11, ColorTwoID = 5 },
                    new Complementary { ID = 12, ColorOneID = 12, ColorTwoID = 6 });

            modelBuilder.Entity<SplitComplementary>()
                .HasData(
                    new SplitComplementary { ID = 1, ColorOneID = 1, ColorTwoID = 6, ColorThreeID = 8 },
                    new SplitComplementary { ID = 2, ColorOneID = 2, ColorTwoID = 7, ColorThreeID = 9 },
                    new SplitComplementary { ID = 3, ColorOneID = 3, ColorTwoID = 8, ColorThreeID = 10 },
                    new SplitComplementary { ID = 4, ColorOneID = 4, ColorTwoID = 9, ColorThreeID = 11 },
                    new SplitComplementary { ID = 5, ColorOneID = 5, ColorTwoID = 10, ColorThreeID = 12 },
                    new SplitComplementary { ID = 6, ColorOneID = 6, ColorTwoID = 11, ColorThreeID = 1 },
                    new SplitComplementary { ID = 7, ColorOneID = 7, ColorTwoID = 12, ColorThreeID = 2 },
                    new SplitComplementary { ID = 8, ColorOneID = 8, ColorTwoID = 1, ColorThreeID = 3 },
                    new SplitComplementary { ID = 9, ColorOneID = 9, ColorTwoID = 2, ColorThreeID = 4 },
                    new SplitComplementary { ID = 10, ColorOneID = 10, ColorTwoID = 3, ColorThreeID = 5 },
                    new SplitComplementary { ID = 11, ColorOneID = 11, ColorTwoID = 4, ColorThreeID = 6 },
                    new SplitComplementary { ID = 12, ColorOneID = 12, ColorTwoID = 5, ColorThreeID = 7 });

            modelBuilder.Entity<Tetradic>()
                .HasData(
                    new Tetradic { ID = 1, ColorOneID = 1, ColorTwoID = 7, ColorThreeID = 3, ColorFourID = 9 },
                    new Tetradic { ID = 2, ColorOneID = 2, ColorTwoID = 8, ColorThreeID = 4, ColorFourID = 10 },
                    new Tetradic { ID = 3, ColorOneID = 3, ColorTwoID = 9, ColorThreeID = 5, ColorFourID = 11 },
                    new Tetradic { ID = 4, ColorOneID = 4, ColorTwoID = 10, ColorThreeID = 6, ColorFourID = 12 },
                    new Tetradic { ID = 5, ColorOneID = 5, ColorTwoID = 11, ColorThreeID = 7, ColorFourID = 1 },
                    new Tetradic { ID = 6, ColorOneID = 6, ColorTwoID = 12, ColorThreeID = 8, ColorFourID = 2 },
                    new Tetradic { ID = 7, ColorOneID = 7, ColorTwoID = 1, ColorThreeID = 9, ColorFourID = 3 },
                    new Tetradic { ID = 8, ColorOneID = 8, ColorTwoID = 2, ColorThreeID = 10, ColorFourID = 4 },
                    new Tetradic { ID = 9, ColorOneID = 9, ColorTwoID = 3, ColorThreeID = 11, ColorFourID = 5 },
                    new Tetradic { ID = 10, ColorOneID = 10, ColorTwoID = 4, ColorThreeID = 12, ColorFourID = 6 },
                    new Tetradic { ID = 11, ColorOneID = 11, ColorTwoID = 5, ColorThreeID = 1, ColorFourID = 7 },
                    new Tetradic { ID = 12, ColorOneID = 12, ColorTwoID = 6, ColorThreeID = 2, ColorFourID = 8 });

            modelBuilder.Entity<Triadic>()
                .HasData(
                    new Triadic { ID = 1, ColorOneID = 1, ColorTwoID = 5, ColorThreeID = 9 },
                    new Triadic { ID = 2, ColorOneID = 2, ColorTwoID = 6, ColorThreeID = 10 },
                    new Triadic { ID = 3, ColorOneID = 3, ColorTwoID = 7, ColorThreeID = 11 },
                    new Triadic { ID = 4, ColorOneID = 4, ColorTwoID = 8, ColorThreeID = 12 },
                    new Triadic { ID = 5, ColorOneID = 5, ColorTwoID = 9, ColorThreeID = 1 },
                    new Triadic { ID = 6, ColorOneID = 6, ColorTwoID = 10, ColorThreeID = 2 },
                    new Triadic { ID = 7, ColorOneID = 7, ColorTwoID = 11, ColorThreeID = 3 },
                    new Triadic { ID = 8, ColorOneID = 8, ColorTwoID = 12, ColorThreeID = 4 },
                    new Triadic { ID = 9, ColorOneID = 9, ColorTwoID = 1, ColorThreeID = 5 },
                    new Triadic { ID = 10, ColorOneID = 10, ColorTwoID = 2, ColorThreeID = 6 },
                    new Triadic { ID = 11, ColorOneID = 11, ColorTwoID = 3, ColorThreeID = 7 },
                    new Triadic { ID = 12, ColorOneID = 12, ColorTwoID = 4, ColorThreeID = 8 });
        }

        public DbSet<Color> Colors { get; set; } 
        public DbSet<Analogous> Analogous { get; set; }
        public DbSet<Complementary> Complementary { get; set; }
        public DbSet<SplitComplementary> SplitComplementary { get; set; }
        public DbSet<Tetradic> Tetradic { get; set; }
        public DbSet<Triadic> Triadic { get; set; }
    }
}
