﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SourcehqAPI.Controllers
{
    [Route("api/minutes")]
    [ApiController]
    public class MinutesController : ControllerBase
    {
        // GET: api/<MinutesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MinutesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MinutesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MinutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MinutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
