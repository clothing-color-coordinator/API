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

        public TetradicController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get method for Tetradic table.  To View.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Tetradic> Get()
        {
            return _context.Tetradic;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Tetradic tetradic = _context.Tetradic.FirstOrDefault(t => t.Color.ColorName == id);
            if (tetradic == null)
            {
                return NotFound();
            }
            return Ok(tetradic);
        }
    }
}