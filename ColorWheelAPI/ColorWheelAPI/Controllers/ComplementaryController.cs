using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorWheelAPI.Data;
using ColorWheelAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ColorWheelAPI.Controllers
{
    [Route("api/Get[controller]Palette")]
    [Route("api/Check[controller]")]
    [ApiController]
    public class ComplementaryController : ControllerBase
    {
        public ColorWheelDbContext _context;


        /// <summary>
        /// Custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="context"></param>
        public ComplementaryController(ColorWheelDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// This action takes in a string id, checks that the id exists, and then returns a palette if it does
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A JSON object</returns>
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Color color = _context.Colors.FirstOrDefault(c => c.ColorName == id);
            Complementary complimentary = _context.Complementary.FirstOrDefault(a => a.ColorOneID == color.ID || a.ColorTwoID == color.ID);

            if (color == null || complimentary == null)
            {
                return NotFound();
            }

            Color color1 = _context.Colors.FirstOrDefault(c => c.ID == complimentary.ColorOneID);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ID == complimentary.ColorTwoID);

            List<Color> palette = new List<Color> { color1, color2 };

            return Ok(new { palette });
        }



        /// <summary>
        /// This action takes a number of colors, checks that they exist in the database, checks if they exist as a palette in the database, and then returns true or false depending on whether or not the colors match the intended color palette.
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="id3"></param>
        /// <returns>True or False</returns>
        [HttpGet("{id1},{id2}")]
        public IActionResult Get(string id1, string id2, string id3)
        {
            Color color1 = _context.Colors.FirstOrDefault(c => c.ColorName == id1);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ColorName == id2);

            if (color1 == null || color2 == null)
            {
                return NotFound();
            }

            Complementary palette = new Complementary();

            palette.ColorOneID = color1.ID;
            palette.ColorTwoID = color2.ID;

            Complementary complementary = _context.Complementary.FirstOrDefault(a => a.ColorOneID == palette.ColorOneID);

            if (palette.ColorOneID == complementary.ColorOneID && palette.ColorTwoID == complementary.ColorTwoID)
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}