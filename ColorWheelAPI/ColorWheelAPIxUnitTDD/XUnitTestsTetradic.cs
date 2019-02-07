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
    public class XUnitTestsTetradic
    {
        [Fact]
        public void TetradicController1()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Red-Violet";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 1;
                tetradic.ColorTwoID = 4;
                tetradic.ColorThreeID = 8;
                tetradic.ColorFourID = 12;
                dbContext.Add(color);
                dbContext.Add(tetradic);
                dbContext.SaveChanges();

                var expected = "Red-Violet";
                var controller = new TetradicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TetradicController2()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Green";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 1;
                tetradic.ColorTwoID = 2;
                tetradic.ColorThreeID = 3;
                tetradic.ColorFourID = 4;
                dbContext.Add(color);
                dbContext.Add(tetradic);
                dbContext.SaveChanges();

                var expected = "Green";
                var controller = new TetradicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TetradicController3()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Blue-Violet";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 11;
                tetradic.ColorTwoID = 4;
                tetradic.ColorThreeID = 6;
                tetradic.ColorFourID = 7;
                dbContext.Add(color);
                dbContext.Add(tetradic);
                dbContext.SaveChanges();

                var expected = "Blue-Violet";
                var controller = new TetradicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
