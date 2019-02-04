using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorWheelAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ColorWheelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalogousController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public AnalogousController(ColorWheelDbContext context)
        {
            _context = context;
        }

        //GET
        
    }
}