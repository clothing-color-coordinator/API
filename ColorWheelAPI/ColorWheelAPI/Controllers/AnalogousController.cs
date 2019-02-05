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
    [Route("api/Get[controller]Palettes")]
    [Route("api/Check[controller]")]
    [ApiController]
    public class AnalogousController : ControllerBase
    {
        private ColorWheelDbContext _context;

        public AnalogousController(ColorWheelDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Analogous analogous = _context.Analogous.FirstOrDefault(a => a.ID == id);
            if(analogous == null)
            {
                return NotFound();
            }
            return Ok(analogous);
        }

        /// <summary>
        /// Post method for API.  To Create
        /// </summary>
        /// <param name="analogous"></param>
        /// <returns></returns>
        public async Task<IActionResult> Post([FromBody] Analogous analogous)
        {
            if(analogous != null)
            {
                await _context.Analogous.AddAsync(analogous);
                await _context.SaveChangesAsync();
                return RedirectToAction("Get", new { analogous.ID });
            }

            return NotFound();
        }

        /// <summary>
        /// Put method for API.  To Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="analogous"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Analogous analogous)
        {
            Analogous resultAnalogous = _context.Analogous.FirstOrDefault(a => a.ID == id);

            if(id != resultAnalogous.ID)
            {
                return BadRequest(ModelState);
            }

            if(resultAnalogous == null)
            {
                return RedirectToAction("Post", resultAnalogous);
            }

            resultAnalogous.ColorOneID = analogous.ColorOneID;
            resultAnalogous.ColorTwoID = analogous.ColorTwoID;
            resultAnalogous.ColorThreeID = analogous.ColorThreeID;

            _context.Update(resultAnalogous);
            await _context.SaveChangesAsync();

            return Ok("AnalogousColors");
        }

        /// <summary>
        /// To Delete the Analogous.  Might not need this for API
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
            await _context.DeleteAnalogous(id);

        }
        */
    }
}