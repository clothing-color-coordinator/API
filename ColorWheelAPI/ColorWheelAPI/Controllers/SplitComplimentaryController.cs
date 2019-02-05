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
    public class SplitComplimentaryController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public SplitComplimentaryController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get method for SplitComplimentary table.  To View.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<SplitComplimentary> Get()
        {
            return _context.SplitComplimentary;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            SplitComplimentary splitComplimentary = _context.SplitComplimentary.FirstOrDefault(s => s.Color.ColorName == id);
            if (splitComplimentary == null)
            {
                return NotFound();
            }
            return Ok(splitComplimentary);
        }
    }
}