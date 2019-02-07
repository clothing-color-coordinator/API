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
    public class TetradicController : ControllerBase
    {
        private ColorWheelDbContext _context;


        /// <summary>
        /// Custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="context"></param>
        public TetradicController(ColorWheelDbContext context)
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
            Color color = _context.Colors.FirstOrDefault(t => t.ColorName == id);
            Tetradic tetradic = _context.Tetradic.FirstOrDefault(t => t.ColorOneID == color.ID || t.ColorTwoID == color.ID || t.ColorThreeID == color.ID || t.ColorFourID == color.ID);
            if (color == null || tetradic == null)
            {
                return NotFound();
            }

            Color color1 = _context.Colors.FirstOrDefault(t => t.ID == tetradic.ColorOneID);
            Color color2 = _context.Colors.FirstOrDefault(t => t.ID == tetradic.ColorTwoID);
            Color color3 = _context.Colors.FirstOrDefault(t => t.ID == tetradic.ColorThreeID);
            Color color4 = _context.Colors.FirstOrDefault(t => t.ID == tetradic.ColorFourID);

            List<Color> palette = new List<Color> { color1, color2, color3, color4 };

            return Ok(new { palette });
        }


        /// <summary>
        /// This action takes a number of colors, checks that they exist in the database, checks if they exist as a palette in the database, and then returns true or false depending on whether or not the colors match the intended color palette.
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="id3"></param>
        /// <returns>True or False</returns>
        [HttpGet("{id1},{id2},{id3},{id4}")]
        public IActionResult Get(string id1, string id2, string id3, string id4)
        {
            Color color1 = _context.Colors.FirstOrDefault(c => c.ColorName == id1);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ColorName == id2);
            Color color3 = _context.Colors.FirstOrDefault(c => c.ColorName == id3);
            Color color4 = _context.Colors.FirstOrDefault(c => c.ColorName == id4);

            if (color1 == null || color2 == null || color3 == null || color4 == null)
            {
                return NotFound();
            }

            Tetradic palette = new Tetradic();

            palette.ColorOneID = color1.ID;
            palette.ColorTwoID = color2.ID;
            palette.ColorThreeID = color3.ID;
            palette.ColorFourID = color4.ID;

            Tetradic tetradic = _context.Tetradic.FirstOrDefault(a => a.ColorOneID == palette.ColorOneID);

            if (palette.ColorOneID == tetradic.ColorOneID && palette.ColorTwoID == tetradic.ColorTwoID && palette.ColorThreeID == tetradic.ColorThreeID && tetradic.ColorFourID == palette.ColorFourID)
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}