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

            using (ColorWheelDbContext dbContext4 = new ColorWheelDbContext(options4))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 7;
                dbContext4.Add(color);
                dbContext4.Add(complementary);
                dbContext4.SaveChanges();

                var expected = "Yellow";
                var controller = new ComplementaryController(dbContext4);
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

            using (ColorWheelDbContext dbContext5 = new ColorWheelDbContext(options5))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 10;
                dbContext5.Add(color);
                dbContext5.Add(complementary);
                dbContext5.SaveChanges();

                var expected = "Red";
                var controller = new ComplementaryController(dbContext5);
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

            using (ColorWheelDbContext dbContext6 = new ColorWheelDbContext(options6))
            {
                Color color = new Color();
                color.ColorName = "Orange";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 4;
                dbContext6.Add(color);
                dbContext6.Add(complementary);
                dbContext6.SaveChanges();

                var expected = "Orange";
                var controller = new ComplementaryController(dbContext6);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
