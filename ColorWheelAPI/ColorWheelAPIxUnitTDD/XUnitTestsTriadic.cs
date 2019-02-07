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
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 2;
                triadic.ColorThreeID = 3;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Red";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController2()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Blue-Violet";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 3;
                triadic.ColorThreeID = 4;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Blue-Violet";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController3()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Yellow-Green";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 2;
                triadic.ColorThreeID = 12;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Yellow-Green";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
