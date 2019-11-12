using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Interface_de_votantes.Models;
using Interface_de_votantes.Services;

namespace Interface_de_votantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotantesController : ControllerBase
    {
        Storage Temp = Storage.GetInstance();
        // GET: api/Votantes
        [HttpGet]
        public IEnumerable<Votantes> Get()
        {
            return Temp.Listado;
        }

        // GET: api/Votantes/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Votantes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Votantes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}