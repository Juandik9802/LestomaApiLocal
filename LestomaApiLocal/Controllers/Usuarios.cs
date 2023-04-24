using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LestomaApiLocal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuarios : ControllerBase
    {
        // GET: api/<Usuarios>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // Obtencion de datos de api de 
        // GET api/<Usuarios>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Usuarios>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Usuarios>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Usuarios>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

