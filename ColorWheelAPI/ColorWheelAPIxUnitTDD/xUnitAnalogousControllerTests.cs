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

            using (ColorWheelDbContext dbContext1 = new ColorWheelDbContext(options1))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 12;
                dbContext1.Add(color);
                dbContext1.Add(analogous);
                dbContext1.SaveChanges();

                var expected = "Blue";
                var controller = new AnalogousController(dbContext1);
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

            using (ColorWheelDbContext dbContext2 = new ColorWheelDbContext(options2))
            {
                Color color = new Color();
                color.ColorName = "Green";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 2;
                analogous.ColorTwoID = 3;
                analogous.ColorThreeID = 1;
                dbContext2.Add(color);
                dbContext2.Add(analogous);
                dbContext2.SaveChanges();

                var expected = "Green";
                var controller = new AnalogousController(dbContext2);
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

            using (ColorWheelDbContext dbContext3 = new ColorWheelDbContext(options3))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 9;
                analogous.ColorTwoID = 10;
                analogous.ColorThreeID = 8;
                dbContext3.Add(color);
                dbContext3.Add(analogous);
                dbContext3.SaveChanges();

                var expected = "Yellow";
                var controller = new AnalogousController(dbContext3);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }


    public class CheckAnalogousTests
    {
        [Fact]
        public void CanReturn200StatusCode()
        {
            DbContextOptions<ColorWheelDbContext> fakeOptions = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext fakeDB = new ColorWheelDbContext(fakeOptions))
            {
                Color yellow = new Color { ID = 1, ColorName = "Yellow", HexCode = "#FEFE33" };
                Color yellowOrange = new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" };
                Color yellowGreen = new Color { ID = 2, ColorName = "Yellow-Green", HexCode = "#B2D732" };

                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 12;

                fakeDB.Add(yellow);
                fakeDB.Add(yellowOrange);
                fakeDB.Add(yellowGreen);
                fakeDB.Add(analogous);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Yellow-Orange";
                var color3 = "Yellow-Green";

                var controller = new AnalogousController(fakeDB);
                var actionResult = controller.Get(color1, color2, color3);
                var okObjectResult = actionResult as OkObjectResult;

                Assert.IsType<OkObjectResult>(actionResult);
            }
        }

        [Fact]
        public void CanReturnNotFound()
        {
            
        }

        [Fact]
        public void CanReturnTrue()
        {

        }

        [Fact]
        public void CanReturnFalse()
        {

        }
    }
}
