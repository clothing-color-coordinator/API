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
   public class CheckTetradicEndpointTests
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
                Color violet = new Color { ID = 7, ColorName = "Violet", HexCode = "#8601AF" };
                Color green = new Color { ID = 3, ColorName = "Green", HexCode = "#66B032" };
                Color red = new Color { ID = 9, ColorName = "Red", HexCode = "#FE2712" };

                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 1;
                tetradic.ColorTwoID = 7;
                tetradic.ColorThreeID = 3;
                tetradic.ColorFourID = 9;

                fakeDB.Add(yellow);
                fakeDB.Add(violet);
                fakeDB.Add(green);
                fakeDB.Add(red);
                fakeDB.Add(tetradic);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Violet";
                var color3 = "Green";
                var color4 = "Red";

                var controller = new TetradicController(fakeDB);
                var actionResult = controller.Get(color1, color2, color3, color4);
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
                Color violet = new Color { ID = 7, ColorName = "Violet", HexCode = "#8601AF" };
                Color green = new Color { ID = 3, ColorName = "Green", HexCode = "#66B032" };
                Color red = new Color { ID = 9, ColorName = "Red", HexCode = "#FE2712" };

                Tetradic tetradic = new Tetradic();
                tetradic.ColorOneID = 1;
                tetradic.ColorTwoID = 7;
                tetradic.ColorThreeID = 3;
                tetradic.ColorFourID = 9;

                fakeDB.Add(yellow);
                fakeDB.Add(violet);
                fakeDB.Add(green);
                fakeDB.Add(red);
                fakeDB.Add(tetradic);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Violet";
                var color3 = "Green";
                var color4 = "Orange";

                var controller = new TetradicController(fakeDB);
                var actionResult = controller.Get(color1, color2, color3, color4);
                var notFoundResult = actionResult as NotFoundResult;

                Assert.IsType<NotFoundResult>(actionResult);
            }
        }
    }
}
