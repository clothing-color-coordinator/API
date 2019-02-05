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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Triadic triadic = _context.Triadic.FirstOrDefault(t => t.ID == id);
            if (triadic == null)
            {
                return NotFound();
            }
            return Ok(triadic);
        }

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="triadic"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] Triadic triadic)
        {
            if (triadic != null)
            {
                await _context.Triadic.AddAsync(triadic);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { triadic.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="triadic"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Triadic triadic)
        {
            Triadic resultTriadic = _context.Triadic.FirstOrDefault(t => t.ID == id);

            if (id != resultTriadic.ID)
            {
                return BadRequest(ModelState);
            }

            if (resultTriadic == null)
            {
                return RedirectToAction("Post", resultTriadic);
            }

            resultTriadic.ColorOneID = triadic.ColorOneID;
            resultTriadic.ColorTwoID = triadic.ColorTwoID;
            resultTriadic.ColorThreeID = triadic.ColorThreeID;

            _context.Update(resultTriadic);
            await _context.SaveChangesAsync();

            return Ok("TriadicColors");
        }

        /// <summary>
        /// To Delete the Triadic.  Might not need this for API
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
            await _context.DeleteTriadic(id);

        }
        */
    }
}