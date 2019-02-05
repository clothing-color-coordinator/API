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
        public IActionResult Get(int id)
        {
            SplitComplimentary splitComplimentary = _context.SplitComplimentary.FirstOrDefault(s => s.ID == id);
            if (splitComplimentary == null)
            {
                return NotFound();
            }
            return Ok(splitComplimentary);
        }

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="splitComplimentary"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] SplitComplimentary splitComplimentary)
        {
            if (splitComplimentary != null)
            {
                await _context.SplitComplimentary.AddAsync(splitComplimentary);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { splitComplimentary.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="splitComplimentary"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] SplitComplimentary splitComplimentary)
        {
            SplitComplimentary resultSplitComplimentary = _context.SplitComplimentary.FirstOrDefault(s => s.ID == id);

            if (id != resultSplitComplimentary.ID)
            {
                return BadRequest(ModelState);
            }

            if (resultSplitComplimentary == null)
            {
                return RedirectToAction("Post", resultSplitComplimentary);
            }

            resultSplitComplimentary.ColorOneID = resultSplitComplimentary.ColorOneID;
            resultSplitComplimentary.ColorTwoID = resultSplitComplimentary.ColorTwoID;
            resultSplitComplimentary.ColorThreeID = resultSplitComplimentary.ColorThreeID;

            _context.Update(resultSplitComplimentary);
            await _context.SaveChangesAsync();

            return Ok("SplitComplimentaryColors");
        }

        /// <summary>
        /// To Delete the SplitComplimentary.  Might not need this for API
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
            await _context.DeleteSplitComplimentary(id);

        }
        */
    }
}