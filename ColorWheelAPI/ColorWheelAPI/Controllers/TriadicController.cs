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
    public class TriadicController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public TriadicController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get method for Triadic table.  To View.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Triadic> Get()
        {
            return _context.Triadic;
        }
    }
}