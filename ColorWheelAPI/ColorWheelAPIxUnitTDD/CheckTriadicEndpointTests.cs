using ColorWheelAPI.Controllers;
using ColorWheelAPI.Data;
using ColorWheelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ColorWheelAPIxUnitTDD
{
    public class CheckTriadicEndpointTests
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
                Color blue = new Color { ID = 5, ColorName = "Blue", HexCode = "#0247FE" };
                Color red = new Color { ID = 9, ColorName = "Red", HexCode = "#FE2712" };

                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 5;
                triadic.ColorThreeID = 9;

                fakeDB.Add(yellow);
                fakeDB.Add(blue);
                fakeDB.Add(red);
                fakeDB.Add(triadic);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Blue";
                var color3 = "Red";

                var controller = new TriadicController(fakeDB);
                var actionResult = controller.Get(color1, color2, color3);
                var okObjectResult = actionResult as OkObjectResult;

                Assert.IsType<OkObjectResult>(actionResult);
            }
        }

        [Fact]
        public void CanReturn404StatusCode()
        {
            DbContextOptions<ColorWheelDbContext> moreFakeOptions = new DbContextOptionsBuilder<ColorWheelDbContext>()
                .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
                .Options;

            using (ColorWheelDbContext fakeDB = new ColorWheelDbContext(moreFakeOptions))
            {
                Color yellow = new Color { ID = 1, ColorName = "Yellow", HexCode = "#FEFE33" };
                Color blue = new Color { ID = 5, ColorName = "Blue", HexCode = "#0247FE" };
                Color red = new Color { ID = 9, ColorName = "Red", HexCode = "#FE2712" };

                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 5;
                triadic.ColorThreeID = 9;

                fakeDB.Add(yellow);
                fakeDB.Add(blue);
                fakeDB.Add(red);
                fakeDB.Add(triadic);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Blue-Violet";
                var color3 = "Red";

                var controller = new TriadicController(fakeDB);
                var actionResult = controller.Get(color1, color2, color3);
                var notFoundResult = actionResult as NotFoundResult;

                Assert.IsType<NotFoundResult>(actionResult);
            }
        }
    }
}
