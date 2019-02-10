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
    public class CheckComplementaryEndpointTests
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

                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 7;

                fakeDB.Add(yellow);
                fakeDB.Add(violet);
                fakeDB.Add(complementary);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Violet";

                var controller = new ComplementaryController(fakeDB);
                var actionResult = controller.Get(color1, color2);
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
                Color moreYellow = new Color { ID = 1, ColorName = "Yellow", HexCode = "#FEFE33" };
                Color moreYellowOrange = new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" };

                Complementary moreComplementary = new Complementary();
                moreComplementary.ColorOneID = 1;
                moreComplementary.ColorTwoID = 2;

                fakeDB.Add(moreYellow);
                fakeDB.Add(moreYellowOrange);
                fakeDB.Add(moreComplementary);
                fakeDB.SaveChanges();

                var moreColor1 = "Red";
                var moreColor2 = "Yellow-Orange";

                var moreController = new ComplementaryController(fakeDB);
                var moreActionResult = moreController.Get(moreColor1, moreColor2);
                var notFoundResult = moreActionResult as NotFoundResult;

                Assert.IsType<NotFoundResult>(moreActionResult);
            }
        }
    }
}
