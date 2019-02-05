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
    public class ComplimentaryController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public ComplimentaryController(ColorWheelDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get method for Complimentary table.  To View.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Complimentary> Get()
        {
            return _context.Complimentary;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Complimentary complimentary = _context.Complimentary.FirstOrDefault(c => c.ID == id);
            if (complimentary == null)
            {
                return NotFound();
            }
            return Ok(complimentary);
        }

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="complimentary"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] Complimentary complimentary)
        {
            if (complimentary != null)
            {
                await _context.Complimentary.AddAsync(complimentary);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { complimentary.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="complimentary"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Complimentary complimentary)
        {
            Complimentary resultComplimentary = _context.Complimentary.FirstOrDefault(c => c.ID == id);

            if (id != resultComplimentary.ID)
            {
                return BadRequest(ModelState);
            }

            if (resultComplimentary == null)
            {
                return RedirectToAction("Post", resultComplimentary);
            }

            resultComplimentary.ColorOneID = complimentary.ColorOneID;
            resultComplimentary.ColorTwoID = complimentary.ColorTwoID;

            _context.Update(resultComplimentary);
            await _context.SaveChangesAsync();

            return Ok("ComplimentaryColors");
        }

        /// <summary>
        /// To Delete the Complimentary.  Might not need this for API
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
            await _context.DeleteComplimentary(id);

        }
        */
    }
}