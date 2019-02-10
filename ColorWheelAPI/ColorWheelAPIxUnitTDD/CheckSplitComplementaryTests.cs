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
                Color yellowOrange = new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" };
                Color yellowGreen = new Color { ID = 2, ColorName = "Yellow-Green", HexCode = "#B2D732" };

                SplitComplementary splitComplementary = new SplitComplementary();
                splitComplementary.ColorOneID = 1;
                splitComplementary.ColorTwoID = 2;
                splitComplementary.ColorThreeID = 12;

                fakeDB.Add(yellow);
                fakeDB.Add(yellowOrange);
                fakeDB.Add(yellowGreen);
                fakeDB.Add(splitComplementary);
                fakeDB.SaveChanges();

                var color1 = "Yellow";
                var color2 = "Yellow-Orange";
                var color3 = "Yellow-Green";

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
                Color moreYellow = new Color { ID = 1, ColorName = "Yellow", HexCode = "#FEFE33" };
                Color moreYellowOrange = new Color { ID = 12, ColorName = "Yellow-Orange", HexCode = "#FCCC1A" };
                Color moreYellowGreen = new Color { ID = 2, ColorName = "Yellow-Green", HexCode = "#B2D732" };

                Analogous moreAnalogous = new Analogous();
                moreAnalogous.ColorOneID = 1;
                moreAnalogous.ColorTwoID = 2;
                moreAnalogous.ColorThreeID = 12;

                fakeDB.Add(moreYellow);
                fakeDB.Add(moreYellowOrange);
                fakeDB.Add(moreYellowGreen);
                fakeDB.Add(moreAnalogous);
                fakeDB.SaveChanges();

                var moreColor1 = "Red";
                var moreColor2 = "Yellow-Orange";
                var moreColor3 = "Yellow-Green";

                var moreController = new AnalogousController(fakeDB);
                var moreActionResult = moreController.Get(moreColor1, moreColor2, moreColor3);
                var notFoundResult = moreActionResult as NotFoundResult;

                Assert.IsType<NotFoundResult>(moreActionResult);
            }
        }
    }
}
