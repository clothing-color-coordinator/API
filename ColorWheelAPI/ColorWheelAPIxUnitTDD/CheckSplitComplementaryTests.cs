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
    public class CheckSplitComplementaryTests
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
                Color blueViolet = new Color { ID = 6, ColorName = "Blue-Violet", HexCode = "#4424D6" };
                Color redViolet = new Color { ID = 8, ColorName = "Red-Violet", HexCode = "#C21460" };

                SplitComplementary splitComplementary = new SplitComplementary();
                splitComplementary.ColorOneID = 1;
                splitComplementary.ColorTwoID = 6;
                splitComplementary.ColorThreeID = 8;

                fakeDB.Add(yellow);
                fakeDB.Add(blueViolet);
                fakeDB.Add(redViolet);
                fakeDB.Add(splitComplementary);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Blue-Violet";
                var color3 = "Red-Violet";

                var controller = new SplitComplementaryController(fakeDB);
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
                Color blueViolet = new Color { ID = 6, ColorName = "Blue-Violet", HexCode = "#4424D6" };
                Color redViolet = new Color { ID = 8, ColorName = "Red-Violet", HexCode = "#C21460" };

                SplitComplementary splitComplementary = new SplitComplementary();
                splitComplementary.ColorOneID = 1;
                splitComplementary.ColorTwoID = 6;
                splitComplementary.ColorThreeID = 8;

                fakeDB.Add(yellow);
                fakeDB.Add(blueViolet);
                fakeDB.Add(redViolet);
                fakeDB.Add(splitComplementary);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Blue-Violet";
                var color3 = "Red";

                var controller = new SplitComplementaryController(fakeDB);
                var moreActionResult = controller.Get(color1, color2, color3);
                var notFoundResult = moreActionResult as NotFoundResult;

                Assert.IsType<NotFoundResult>(moreActionResult);
            }
        }
    }
}
