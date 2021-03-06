﻿using System;
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
        public ColorWheelDbContext _context;


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

            return Ok(new { palette });
        }


        /// <summary>
        /// This action takes a number of colors, checks that they exist in the database, checks if they exist as a palette in the database, and then returns true or false depending on whether or not the colors match the intended color palette.
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="id3"></param>
        /// <returns>True or False</returns>
        [HttpGet("{id1},{id2},{id3}")]
        public IActionResult Get(string id1, string id2, string id3)
        {
            Color color1 = _context.Colors.FirstOrDefault(c => c.ColorName == id1);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ColorName == id2);
            Color color3 = _context.Colors.FirstOrDefault(c => c.ColorName == id3);

            if (color1 == null || color2 == null || color3 == null)
            {
                return NotFound();
            }

            Analogous palette = new Analogous();

            palette.ColorOneID = color1.ID;
            palette.ColorTwoID = color3.ID;
            palette.ColorThreeID = color2.ID;

            Analogous analogous = _context.Analogous.FirstOrDefault(a => a.ColorOneID == palette.ColorOneID);

            if (palette.ColorOneID == analogous.ColorOneID && palette.ColorTwoID == analogous.ColorTwoID && palette.ColorThreeID == analogous.ColorThreeID)
            {
                return Ok(true);
            }

            return Ok(false);
        }

    }
}