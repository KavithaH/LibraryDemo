using LibraryDemo.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDemo.Data;
using LibraryDemo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBookRepoService _bookreposervice;
        public ValuesController(IBookRepoService bookRepoService)
        {
            _bookreposervice = bookRepoService;
          
        }
        // GET: api/Values/ViewAllBooks
        [HttpGet]
        [Route("ViewAllBooks")]
        public async Task<IActionResult> ViewAllBooks()
        {
            try
            {
                var allbooks = await _bookreposervice.ViewAllBooks();
                if (allbooks != null)
                    return Ok(allbooks);
                else
                    return BadRequest("No users found.");
            }
            catch (Exception Ex)
            {
                return StatusCode(500);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
