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

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="tetradic"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] Tetradic tetradic)
        {
            if (tetradic != null)
            {
                await _context.Tetradic.AddAsync(tetradic);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { tetradic.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tetradic"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Tetradic tetradic)
        {
            Tetradic resultTetradic = _context.Tetradic.FirstOrDefault(t => t.ID == id);

            if (id != resultTetradic.ID)
            {
                return BadRequest(ModelState);
            }

            if (resultTetradic == null)
            {
                return RedirectToAction("Post", resultTetradic);
            }

            resultTetradic.ColorOneID = tetradic.ColorOneID;
            resultTetradic.ColorTwoID = tetradic.ColorTwoID;
            resultTetradic.ColorThreeID = tetradic.ColorThreeID;
            resultTetradic.ColorFourID = tetradic.ColorFourID;

            _context.Update(resultTetradic);
            await _context.SaveChangesAsync();

            return Ok("TetradicColors");
        }

        /// <summary>
        /// To Delete the Tetradic.  Might not need this for API
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
            await _context.DeleteTetradic(id);

        }
        */
    }
}