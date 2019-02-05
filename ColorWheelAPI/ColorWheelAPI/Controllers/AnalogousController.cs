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
    public class AnalogousController : ControllerBase
    {
        private ColorWheelDbContext _context;


        /// <summary>
        /// Custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="context"></param>
        public AnalogousController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This action takes in a string id, checks that the id exists, and then returns a palette if it does
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Color color = _context.Colors.FirstOrDefault(c => c.ColorName == id);
            Analogous analogous = _context.Analogous.FirstOrDefault(a => a.ColorOneID == color.ID || a.ColorTwoID == color.ID || a.ColorThreeID == color.ID);

            if (color == null || analogous == null)
            {
                return NotFound();
            }

            Color color1 = _context.Colors.FirstOrDefault(c => c.ID == analogous.ColorOneID);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ID == analogous.ColorTwoID);
            Color color3 = _context.Colors.FirstOrDefault(c => c.ID == analogous.ColorThreeID);

            List<Color> palette = new List<Color> { color1, color2, color3 };

            return Ok(palette);
        }


        //[HttpGet("{id},{id},{id}")]
        //public IActionResult Get(string id1, string id2, string id3)
        //{
            // Bring in context
            //bool temp = false;
            //Analogous analogous = _context.Analogous.FirstOrDefault(a => 
            //{     
            //    for (int i = 0; i < 12; i++)
            //    {
            //        if(a.ColorOneID. == id1)
            //    }
            //});


            //return Ok(false);
                // If id1 has a palette, compare other palette colors to id2 and id3
            // Check for palettes that have all three id colors
            // If palette is found, return true;
            // If not, return false;
        //}

    }
}