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

namespace ColorWheelAPIxUnitTDD
{
    /********************************Models Tests***********************************************/

    public class ModelsTests
    {
        /// <summary>
        /// Models Color for Getter and Swetter
        /// </summary>
        [Fact]
        public void CanGetColorGreen()
        {
            Color testColor = new Color();
            testColor.ColorName = "Green";
            testColor.HexCode = "#008000";

            Assert.Equal("Green", testColor.ColorName);
            Assert.Equal("#008000", testColor.HexCode);
        }
        [Fact]
        public void CanGetColorBlue()
        {
            Color testColor = new Color();
            testColor.ColorName = "Blue";
            testColor.HexCode = "#0247FE";

            Assert.Equal("Blue", testColor.ColorName);
            Assert.Equal("#0247FE", testColor.HexCode);
        }
        [Fact]
        public void CanGetColorYellowOrange()
        {
            Color testColor = new Color();
            testColor.ColorName = "Yellow-Orange";
            testColor.HexCode = "#FCCC1A";

            Assert.Equal("Yellow-Orange", testColor.ColorName);
            Assert.Equal("#FCCC1A", testColor.HexCode);
        }

        /// <summary>
        /// Model Analogous for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforAnalogous1()
        {
            Analogous analogous = new Analogous();
            analogous.ColorOneID = 1;
            analogous.ColorTwoID = 2;
            analogous.ColorThreeID = 12;

            Assert.Equal(1, analogous.ColorOneID);
            Assert.Equal(2, analogous.ColorTwoID);
            Assert.Equal(12, analogous.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforAnalogous2()
        {
            Analogous analogous = new Analogous();
            analogous.ColorOneID = 6;
            analogous.ColorTwoID = 7;
            analogous.ColorThreeID = 5;

            Assert.Equal(6, analogous.ColorOneID);
            Assert.Equal(7, analogous.ColorTwoID);
            Assert.Equal(5, analogous.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforAnalogous3()
        {
            Analogous analogous = new Analogous();
            analogous.ColorOneID = 12;
            analogous.ColorTwoID = 1;
            analogous.ColorThreeID = 11;

            Assert.Equal(12, analogous.ColorOneID);
            Assert.Equal(1, analogous.ColorTwoID);
            Assert.Equal(11, analogous.ColorThreeID);
        }

        /// <summary>
        /// Models Complementary for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforComplementary1()
        {
            Complementary complementary = new Complementary();
            complementary.ColorOneID = 1;
            complementary.ColorTwoID = 7;

            Assert.Equal(1, complementary.ColorOneID);
            Assert.Equal(7, complementary.ColorTwoID);
        }
        [Fact]
        public void CanGetIDforComplementary2()
        {
            Complementary complementary = new Complementary();
            complementary.ColorOneID = 6;
            complementary.ColorTwoID = 12;

            Assert.Equal(6, complementary.ColorOneID);
            Assert.Equal(12, complementary.ColorTwoID);
        }
        [Fact]
        public void CanGetIDforComplementary3()
        {
            Complementary complementary = new Complementary();
            complementary.ColorOneID = 11;
            complementary.ColorTwoID = 5;

            Assert.Equal(11, complementary.ColorOneID);
            Assert.Equal(5, complementary.ColorTwoID);
        }

        /// <summary>
        /// Model SplitComplementary for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforSplitComplementary1()
        {
            SplitComplementary splitComplementary = new SplitComplementary();
            splitComplementary.ColorOneID = 1;
            splitComplementary.ColorTwoID = 6;
            splitComplementary.ColorThreeID = 8;

            Assert.Equal(1, splitComplementary.ColorOneID);
            Assert.Equal(6, splitComplementary.ColorTwoID);
            Assert.Equal(8, splitComplementary.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforSplitComplementary2()
        {
            SplitComplementary splitComplementary = new SplitComplementary();
            splitComplementary.ColorOneID = 7;
            splitComplementary.ColorTwoID = 12;
            splitComplementary.ColorThreeID = 2;

            Assert.Equal(7, splitComplementary.ColorOneID);
            Assert.Equal(12, splitComplementary.ColorTwoID);
            Assert.Equal(2, splitComplementary.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforSplitComplementary3()
        {
            SplitComplementary splitComplementary = new SplitComplementary();
            splitComplementary.ColorOneID = 12;
            splitComplementary.ColorTwoID = 5;
            splitComplementary.ColorThreeID = 7;

            Assert.Equal(12, splitComplementary.ColorOneID);
            Assert.Equal(5, splitComplementary.ColorTwoID);
            Assert.Equal(7, splitComplementary.ColorThreeID);
        }

        /// <summary>
        /// Model Tetradic for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforTetradic1()
        {
            Tetradic tetradic = new Tetradic();
            tetradic.ColorOneID = 1;
            tetradic.ColorTwoID = 7;
            tetradic.ColorThreeID = 3;
            tetradic.ColorFourID = 9;

            Assert.Equal(1, tetradic.ColorOneID);
            Assert.Equal(7, tetradic.ColorTwoID);
            Assert.Equal(3, tetradic.ColorThreeID);
            Assert.Equal(9, tetradic.ColorFourID);
        }
        [Fact]
        public void CanGetIDforTetradic2()
        {
            Tetradic tetradic = new Tetradic();
            tetradic.ColorOneID = 6;
            tetradic.ColorTwoID = 12;
            tetradic.ColorThreeID = 8;
            tetradic.ColorFourID = 2;

            Assert.Equal(6, tetradic.ColorOneID);
            Assert.Equal(12, tetradic.ColorTwoID);
            Assert.Equal(8, tetradic.ColorThreeID);
            Assert.Equal(2, tetradic.ColorFourID);
        }
        [Fact]
        public void CanGetIDforTetradic3()
        {
            Tetradic tetradic = new Tetradic();
            tetradic.ColorOneID = 10;
            tetradic.ColorTwoID = 4;
            tetradic.ColorThreeID = 12;
            tetradic.ColorFourID = 6;

            Assert.Equal(10, tetradic.ColorOneID);
            Assert.Equal(4, tetradic.ColorTwoID);
            Assert.Equal(12, tetradic.ColorThreeID);
            Assert.Equal(6, tetradic.ColorFourID);
        }

        /// <summary>
        /// Model Triadic for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforTriadic1()
        {
            Triadic triadic = new Triadic();
            triadic.ColorOneID = 2;
            triadic.ColorTwoID = 6;
            triadic.ColorThreeID = 10;

            Assert.Equal(2, triadic.ColorOneID);
            Assert.Equal(6, triadic.ColorTwoID);
            Assert.Equal(10, triadic.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforTriadic2()
        {
            Triadic triadic = new Triadic();
            triadic.ColorOneID = 7;
            triadic.ColorTwoID = 11;
            triadic.ColorThreeID = 3;

            Assert.Equal(7, triadic.ColorOneID);
            Assert.Equal(11, triadic.ColorTwoID);
            Assert.Equal(3, triadic.ColorThreeID);
        }
        [Fact]
        public void CanGetIDforTriadic3()
        {
            Triadic triadic = new Triadic();
            triadic.ColorOneID = 12;
            triadic.ColorTwoID = 4;
            triadic.ColorThreeID = 8;

            Assert.Equal(12, triadic.ColorOneID);
            Assert.Equal(4, triadic.ColorTwoID);
            Assert.Equal(8, triadic.ColorThreeID);
            
        }

    }

    /*********************************Controller & Database********************************************/

    public class ControllerTests
    {
        private readonly IConfiguration configuration;
        [Fact]
        public void AnalogousTest1()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "colorWheelDb")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                //Arrange
                Analogous analogous = new Analogous();
                Color color = new Color();
                color.ColorName = "Blue";
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 3;

                //Act
                dbContext.Colors.Add(color);
                dbContext.SaveChanges();

                AnalogousController _controller = new AnalogousController(dbContext);

                var result = _controller.Get(color.ColorName);

                //var result = context.Analogous.FirstOrDefault(a => a.ID == analogous.ColorOneID && a.ID == analogous.ColorTwoID && a.ID == analogous.ColorThreeID);

                Assert.IsType<OkResult>(result);
                //LOOK FOR TESTING NOT FOUND RESULT as well
            }
             //Assert.IsType<o>
        }
        AnalogousController _analogousController;
        [Fact]
        public void AnalogousTest2()
        {
            var result = _analogousController.Get("Yellow");
            Assert.IsType<OkResult>(result);
        }

        /*
        /// <summary>
        /// Models for Getter and Setter
        /// </summary>
        [Fact]
        public void CanGetIDforAnalogous()
        {
            Analogous analogous = new Analogous();
            analogous.ColorOneID = 1;
            analogous.ColorTwoID = 2;
            analogous.ColorThreeID = 12;

            Assert.Equal(1, analogous.ColorOneID);
            Assert.Equal(2, analogous.ColorTwoID);
            Assert.Equal(12, analogous.ColorThreeID);
        }

        [Fact]
        public void CanReceiveInputFromEndPoint()
        {
            // This would verify that we can receive user input via the endpoints
            // Assign


            // Act

            // Assert

        }

        [Fact]
        public void CanGetColorFromDB()
        {
            // This would verify that we can get a color from db
        }

        DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "colorWheelDb")
               .Options;

        [Fact]
        public void Somehting()
        {
            using (ColorWheelDbContext context = new ColorWheelDbContext(options))
            {
                //Arrange
                Analogous analogous = new Analogous();
                Color color = new Color();
                color.ColorName = "Green";
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 3;

                //Act
                context.Colors.Add(color);
                context.SaveChanges();

                AnalogousController _controller = new AnalogousController(context);

                var result = _controller.Get("Green");
            }
        }
        
        [Fact]
        public void CanGetPaletteFromDB()
        {
            // This would verify that we can get a color from db
            
            

            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            var configuration = builder.Build();
            using (var context = new ColorWheelDbContext(options))

            {
                var controller = new AnalogousController(configuration);

                //Act
                var results = controller.Get.CanGetColorFromDB("Green");

                //Assert
                Assert.IsType<Analogous>(results);
            }
        }
        
        [Fact]
        public void CanReturnErrorIfColorIsNotInDb()
        {
            // This would verify that error is sent if color not in db
        }

        [Fact]
        public void CanReturnErrorIfPaletteIsNotInDb()
        {
            // This would verify that error is sent if palette not in db
        }

        [Fact]
        public void CanReturnValidJSON()
        {
            // This would verify that return OK method sends a json object with a key:value pair

        }

        AnalogousController _analogousController;
        [Fact]
        public void AnalogousControllerTest()
        {
            //aRRANGE
            //AnalogousController _analogousController;
            //Act
            var result = _analogousController.Get
            Assert.IsType<object>(result);
        }*/
    }
}
