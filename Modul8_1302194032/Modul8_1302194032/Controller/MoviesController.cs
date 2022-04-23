using Microsoft.AspNetCore.Mvc;

namespace Modul8_1302194032.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            // GET: api/<MoviesController>
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // POST api/<MoviesController>
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // GET api/<MoviesController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // DELETE api/<MoviesController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
}
