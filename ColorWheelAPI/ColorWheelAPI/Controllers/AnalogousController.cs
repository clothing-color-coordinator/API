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
            Analogous analogous = _context.Analogous.FirstOrDefault(a => a.Color.ColorName == id);

            if (analogous == null)
            {
                return NotFound();
            }

            return Ok(analogous);
        }


        [HttpGet("{id},{id},{id}")]
        public IActionResult Get(string id1, string id2, string id3)
        {

        }

    }
}