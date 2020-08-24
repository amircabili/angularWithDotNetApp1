using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using angularWithDotNetApp1.Model;
using System.Diagnostics;

namespace angularWithDotNetApp1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class phoenixController : Controller
    {
        private const string Json_url = "https://api.github.com/search/repositories?q=YOUR_SEARCH_KEYWORD.json";

        [HttpGet]
        public IEnumerable<item> Get()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString("https://api.github.com/search/repositories?q=YOUR_SEARCH_KEYWORD.json");
            var items = JsonConvert.DeserializeObject<Models.Items>(json);
             
            return (IEnumerable<Model.item>)View(items);
        }


        // GET api/<phoenixController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<phoenixController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<phoenixController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<phoenixController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
