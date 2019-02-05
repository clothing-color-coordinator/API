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
    public class SplitComplimentaryController : ControllerBase
    {
        private ColorWheelDbContext _context;


        /// <summary>
        /// Custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="context"></param>
        public SplitComplimentaryController(ColorWheelDbContext context)
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
            SplitComplimentary splitComplimentary = _context.SplitComplimentary.FirstOrDefault(a => a.ColorOneID == color.ID || a.ColorTwoID == color.ID || a.ColorThreeID == color.ID);

            if (color == null || splitComplimentary == null)
            {
                return NotFound();
            }

            Color color1 = _context.Colors.FirstOrDefault(c => c.ID == splitComplimentary.ColorOneID);
            Color color2 = _context.Colors.FirstOrDefault(c => c.ID == splitComplimentary.ColorTwoID);
            Color color3 = _context.Colors.FirstOrDefault(c => c.ID == splitComplimentary.ColorThreeID);

            List<Color> palette = new List<Color> { color1, color2, color3 };

            return Ok(palette);
        }
    }
}