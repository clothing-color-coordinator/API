using System;
using ColorWheelAPI.Models;
using ColorWheelAPI.Data;
using ColorWheelAPI.Controllers;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace ColorWheelAPIxUnitTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetColors()
        {
            Color testColor = new Color();
            testColor.ColorName = "Green";
            testColor.HexCode = "#008000";

            Assert.Equal("Green", testColor.ColorName);
            Assert.Equal("#008000", testColor.HexCode);
        }

        [Fact]
        public void CanSetColors()
        {
            Color testColor = new Color();
            testColor.ColorName = "Green";
            testColor.HexCode = "#008000";

            testColor.ColorName = "Red";
            testColor.HexCode = "#fff00";

            Assert.Equal("Red", testColor.ColorName);
            Assert.Equal("fff00", testColor.HexCode);
        }

        
        [Fact]
        public async void CrudColorsInDb()
        {
            DbContextOptions<ColorWheelDbContext> options = new DbContextOptionsBuilder<ColorWheelDbContext>()
                .UseInMemoryDatabase("GetColors")
                .Options;

            using (ColorWheelDbContext context = new ColorWheelDbContext(options))
            {
                //Arrange  (CREATE)
                Color color = new Color();
                color.ColorName = "Blue";
                color.HexCode = "#0000ff";

                context.Colors.Add(color);
                context.SaveChanges();

                //Act (READ)
                var colorNew = await context.Colors.FirstOrDefaultAsync(c => c.ColorName == color.ColorName && c.HexCode == color.HexCode);
                //Assert
                Assert.Equal("Blue", colorNew.ColorName);
                Assert.Equal("#0000ff", colorNew.HexCode);

                /*UPDATE
                colorNew.colorName = "Brown";
                colorNew.HexCode = "#654321";
                context.Update(colorNew);
                context.SaveChanges();
                var updateColor = await context.Color.FirstOrDefaultAsync(c => c.ColorName == color.ColorName && c.HexCode == color.HexCode);
                Assert.Equal("Brown", updateColor.ColorName);
                Assert.Equal("#654321", updateColor.HexCode);

                DELETE
                context.Colors.Remove(updateColor);
                context.SaveChanges();
                var deleteColor = await context.Colors.FirstOrDefaultAsync(c => c.ColorName == color.ColorName && c.HexCode == color.HexCode);
                Assert.True(deleteColor == null);
                */
            }
        }

        

    }
}
