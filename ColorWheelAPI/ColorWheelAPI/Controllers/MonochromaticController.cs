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
    [Route("api/[controller]")]
    [ApiController]
    public class MonochromaticController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public MonochromaticController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get method for Monochromatic table.  To View.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Monochromatic> Get()
        {
            return _context.Monochromatic;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Monochromatic monochromatic = _context.Monochromatic.FirstOrDefault(a => a.ID == id);
            if (monochromatic == null)
            {
                return NotFound();
            }
            return Ok(monochromatic);
        }

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="monochromatic"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] Monochromatic monochromatic)
        {
            if (monochromatic != null)
            {
                await _context.Monochromatic.AddAsync(monochromatic);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { monochromatic.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="monocrhomatic"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Monochromatic monochromatic)
        {
            Monochromatic resultChromatic = _context.Monochromatic.FirstOrDefault(m => m.ID == id);

            if (id != resultChromatic.ID)
            {
                return BadRequest(ModelState);
            }

            if (resultChromatic == null)
            {
                return RedirectToAction("Post", resultChromatic);
            }

            resultChromatic.ColorOneID = monochromatic.ColorOneID;
            resultChromatic.ColorTwoID = monochromatic.ColorTwoID;

            _context.Update(resultChromatic);
            await _context.SaveChangesAsync();

            return Ok("MonochromaticColors");
        }

        /// <summary>
        /// To Delete the Monochromatic.  Might not need this for API
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void Delete(int id)
        {

        }
        /*
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.DeleteMonochromatic(id);

        }
        */
    }
}