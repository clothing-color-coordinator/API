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
    public class XUnitTestsComplementary
    {
        [Fact]
        public void ComplementaryController1()
        {
            DbContextOptions<ColorWheelDbContext> options4 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options4))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Yellow";
                var controller = new ComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void ComplementaryController2()
        {
            DbContextOptions<ColorWheelDbContext> options5 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options5))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 2;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Red";
                var controller = new ComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void ComplementaryController3()
        {
            DbContextOptions<ColorWheelDbContext> options6 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options6))
            {
                Color color = new Color();
                color.ColorName = "Orange";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 8;
                complementary.ColorTwoID = 3;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Orange";
                var controller = new ComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
