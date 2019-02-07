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
            DbContextOptions<ColorWheelDbContext> options1 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options1))
            {
                Color color = new Color();
                color.ColorName = "Red-Orange";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 1;
                split.ColorTwoID = 2;
                split.ColorThreeID = 12;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Red-Orange";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController2()
        {
            DbContextOptions<ColorWheelDbContext> options2 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options2))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 1;
                split.ColorTwoID = 2;
                split.ColorThreeID = 11;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Blue";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController3()
        {
            DbContextOptions<ColorWheelDbContext> options3 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options3))
            {
                Color color = new Color();
                color.ColorName = "Red-Violet";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 1;
                split.ColorTwoID = 9;
                split.ColorThreeID = 10;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Red-Violet";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
