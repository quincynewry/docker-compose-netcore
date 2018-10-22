using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace web_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var client = new RestClient(Environment.GetEnvironmentVariable("Web2Url"));
            var request = new RestRequest("api/values", Method.GET);

            var response = client.Execute(request);

            return Ok(response.Content);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var client = new RestClient(Environment.GetEnvironmentVariable("Web2Url"));
            var request = new RestRequest($"api/values/{id}", Method.GET);

            var response = client.Execute(request);

            return Ok(response.Content);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
