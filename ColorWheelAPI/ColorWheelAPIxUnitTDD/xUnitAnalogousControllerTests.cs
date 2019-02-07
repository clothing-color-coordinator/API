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
    public class XUnitTestsAnalogousController
    {
        [Fact]
        public void AnalogousController1()
        {
            DbContextOptions<ColorWheelDbContext> options1 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options1))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Blue";
                var controller = new AnalogousController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void AnalogousController2()
        {
            DbContextOptions<ColorWheelDbContext> options2 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options2))
            {
                Color color = new Color();
                color.ColorName = "Green";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Green";
                var controller = new AnalogousController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void AnalogousController3()
        {
            DbContextOptions<ColorWheelDbContext> options3 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options3))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 3;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Yellow";
                var controller = new AnalogousController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
