using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    // Route: api/values
    public class ValuesController : ControllerBase
    {
        // In-memory list for testing
        private static List<string> values = new List<string>
        {
            "Item1", "Item2", "Item3"
        };

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        // GET: api/values/1
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound("Item not found");
            }
            return Ok(values[id]);
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return CreatedAtAction(nameof(Get), new { id = values.Count - 1 }, value);
        }

        // PUT: api/values/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string updatedValue)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound("Item not found");
            }
            values[id] = updatedValue;
            return NoContent();
        }

        // DELETE: api/values/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound("Item not found");
            }
            values.RemoveAt(id);
            return NoContent();
        }
    }
}
