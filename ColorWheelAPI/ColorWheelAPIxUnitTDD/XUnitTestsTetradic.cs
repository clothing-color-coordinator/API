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
            DbContextOptions<ColorWheelDbContext> options10 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext10 = new ColorWheelDbContext(options10))
            {
                Color color = new Color();
                color.ColorName = "Red-Violet";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 1;
                tetradic.ColorTwoID = 7;
                tetradic.ColorThreeID = 3;
                tetradic.ColorFourID = 9;
                dbContext10.Add(color);
                dbContext10.Add(tetradic);
                dbContext10.SaveChanges();

                var expected = "Red-Violet";
                var controller = new TetradicController(dbContext10);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TetradicController2()
        {
            DbContextOptions<ColorWheelDbContext> options11 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext11 = new ColorWheelDbContext(options11))
            {
                Color color = new Color();
                color.ColorName = "Green";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 5;
                tetradic.ColorTwoID = 11;
                tetradic.ColorThreeID = 7;
                tetradic.ColorFourID = 1;
                dbContext11.Add(color);
                dbContext11.Add(tetradic);
                dbContext11.SaveChanges();

                var expected = "Green";
                var controller = new TetradicController(dbContext11);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TetradicController3()
        {
            DbContextOptions<ColorWheelDbContext> options12 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext12 = new ColorWheelDbContext(options12))
            {
                Color color = new Color();
                color.ColorName = "Blue-Violet";
                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 10;
                tetradic.ColorTwoID = 4;
                tetradic.ColorThreeID = 12;
                tetradic.ColorFourID = 6;
                dbContext12.Add(color);
                dbContext12.Add(tetradic);
                dbContext12.SaveChanges();

                var expected = "Blue-Violet";
                var controller = new TetradicController(dbContext12);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }
}
