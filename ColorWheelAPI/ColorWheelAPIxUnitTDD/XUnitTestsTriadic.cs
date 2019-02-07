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
    public class XUnitTestsTriadic
    {
        [Fact]
        public void TriadicController1()
        {
            DbContextOptions<ColorWheelDbContext> options13 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext13 = new ColorWheelDbContext(options13))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 5;
                triadic.ColorThreeID = 9;
                dbContext13.Add(color);
                dbContext13.Add(triadic);
                dbContext13.SaveChanges();

                var expected = "Red";
                var controller = new TriadicController(dbContext13);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController2()
        {
            DbContextOptions<ColorWheelDbContext> options14 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext14 = new ColorWheelDbContext(options14))
            {
                Color color = new Color();
                color.ColorName = "Blue-Violet";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 8;
                triadic.ColorThreeID = 12;
                dbContext14.Add(color);
                dbContext14.Add(triadic);
                dbContext14.SaveChanges();

                var expected = "Blue-Violet";
                var controller = new TriadicController(dbContext14);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController3()
        {
            DbContextOptions<ColorWheelDbContext> options15 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext15 = new ColorWheelDbContext(options15))
            {
                Color color = new Color();
                color.ColorName = "Yellow-Green";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 2;
                triadic.ColorThreeID = 6;
                dbContext15.Add(color);
                dbContext15.Add(triadic);
                dbContext15.SaveChanges();

                var expected = "Yellow-Green";
                var controller = new TriadicController(dbContext15);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
