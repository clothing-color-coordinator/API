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

    public class AnalogousControllerTests
    {
        [Fact]
        public void AnalogousController1()
        {
            DbContextOptions<ColorWheelDbContext> options1 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options1))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Blue";
                var controller = new AnalogousController(dbContext);
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

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options2))
            {
                Color color = new Color();
                color.ColorName = "Green";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Green";
                var controller = new AnalogousController(dbContext);
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

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options3))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Analogous analogous = new Analogous();
                analogous.ColorOneID = 1;
                analogous.ColorTwoID = 2;
                analogous.ColorThreeID = 3;
                dbContext.Add(color);
                dbContext.Add(analogous);
                dbContext.SaveChanges();

                var expected = "Yellow";
                var controller = new AnalogousController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }

    public class ComplementaryTests
    {
        [Fact]
        public void ComplementaryController1()
        {
            DbContextOptions<ColorWheelDbContext> options4 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options4))
            {
                Color color = new Color();
                color.ColorName = "Yellow";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Yellow";
                var controller = new ComplementaryController(dbContext);
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

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options5))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 1;
                complementary.ColorTwoID = 2;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Red";
                var controller = new ComplementaryController(dbContext);
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

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options6))
            {
                Color color = new Color();
                color.ColorName = "Orange";
                Complementary complementary = new Complementary();
                complementary.ColorOneID = 8;
                complementary.ColorTwoID = 3;
                dbContext.Add(color);
                dbContext.Add(complementary);
                dbContext.SaveChanges();

                var expected = "Orange";
                var controller = new ComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }

    public class SplitComplementaryTests
    {
        [Fact]
        public void SplitComplementaryController1()
        {
            DbContextOptions<ColorWheelDbContext> options7 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options7))
            {
                Color color = new Color();
                color.ColorName = "Red-Orange";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 9;
                split.ColorTwoID = 2;
                split.ColorThreeID = 12;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Red-Orange";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController2()
        {
            DbContextOptions<ColorWheelDbContext> options8 = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options8))
            {
                Color color = new Color();
                color.ColorName = "Blue";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 7;
                split.ColorTwoID = 2;
                split.ColorThreeID = 3;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Blue";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void SplitComplementaryController3()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Red-Violet";
                SplitComplementary split = new SplitComplementary();
                split.ColorOneID = 5;
                split.ColorTwoID = 9;
                split.ColorThreeID = 11;
                dbContext.Add(color);
                dbContext.Add(split);
                dbContext.SaveChanges();

                var expected = "Red-Violet";
                var controller = new SplitComplementaryController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
    }

    public class TetradicTests
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

    public class TriadicTests
    {
        [Fact]
        public void TriadicController1()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Red";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 2;
                triadic.ColorThreeID = 3;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Red";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController2()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Blue-Violet";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 3;
                triadic.ColorThreeID = 4;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Blue-Violet";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        }
        [Fact]
        public void TriadicController3()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
               .UseInMemoryDatabase(databaseName: "ColorWheelDbContext")
               .Options;

            using (ColorWheelDbContext dbContext = new ColorWheelDbContext(options))
            {
                Color color = new Color();
                color.ColorName = "Yellow-Green";
                Triadic triadic = new Triadic();
                triadic.ColorOneID = 1;
                triadic.ColorTwoID = 2;
                triadic.ColorThreeID = 12;
                dbContext.Add(color);
                dbContext.Add(triadic);
                dbContext.SaveChanges();

                var expected = "Yellow-Green";
                var controller = new TriadicController(dbContext);
                var actionResult = controller.Get(expected);
                var okObjectResult = actionResult as OkObjectResult;
                Assert.IsType<OkObjectResult>(actionResult);
            }
        } 
    }
}
