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
    public class ComplimentaryController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public ComplimentaryController(ColorWheelDbContext context)
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
            Complimentary complimentary = _context.Complimentary.FirstOrDefault(a => a.Color.ColorName == id);

            if (complimentary == null)
            {
                return NotFound();
            }

            return Ok(complimentary);
        }
    }
}