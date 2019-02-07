using System;
using ColorWheelAPI.Models;
using ColorWheelAPI.Data;
using ColorWheelAPI.Controllers;
using Xunit;
using Microsoft.EntityFrameworkCore;
using ColorWheelAPI;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace ColorWheelAPIxUnitTDD
{
    /// <summary>
    /// Controller and Database Tests.  Creating and checking database using controller.
    /// </summary>
    public class XUnitTestsSplitComplementary
    {
        [Fact]
        public void SplitComplementaryController1()
        {
            DbContextOptions<ColorWheelDbContext> options7 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext7 = new ColorWheelDbContext(options7))
            {
                Color color = new Color();
                color.ColorName = "Red-Orange";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 1;
                split.ColorTwoID = 6;
                split.ColorThreeID = 8;
                dbContext7.Add(color);
                dbContext7.Add(split);
                dbContext7.SaveChanges();

                var expected = "Red-Orange";
                var controller = new SplitComplementaryController(dbContext7);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController2()
        {
            DbContextOptions<ColorWheelDbContext> options8 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext8 = new ColorWheelDbContext(options8))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 1;
                split.ColorTwoID = 10;
                split.ColorThreeID = 12;
                dbContext8.Add(color);
                dbContext8.Add(split);
                dbContext8.SaveChanges();

                var expected = "Blue";
                var controller = new SplitComplementaryController(dbContext8);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController3()
        {
            DbContextOptions<ColorWheelDbContext> options9 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext9 = new ColorWheelDbContext(options9))
            {
                Color color = new Color();
                color.ColorName = "Red-Violet";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 10;
                split.ColorTwoID = 3;
                split.ColorThreeID = 5;
                dbContext9.Add(color);
                dbContext9.Add(split);
                dbContext9.SaveChanges();

                var expected = "Red-Violet";
                var controller = new SplitComplementaryController(dbContext9);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
