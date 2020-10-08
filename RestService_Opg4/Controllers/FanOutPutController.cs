using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model_Klasse_Opg1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestService_Opg4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanOutPutController : ControllerBase
    {

        private static readonly List<FanOutPut> fanOutputs = new List<FanOutPut>()
        {
            new FanOutPut(1, "Erik", 16, 35),
            new FanOutPut(2, "Max", 17, 40),
            new FanOutPut(3, "Ida", 18, 45),
            new FanOutPut(4, "Henrik", 19, 50)
        };

        private static int FanOutPutId = 4;

        // GET: api/<FanOutPutController>
        [HttpGet]
        public IEnumerable<FanOutPut> Get()
        {
            return fanOutputs;
        }

        // GET api/<FanOutPutController>/5
        [HttpGet("{id}")]
        public FanOutPut Get(int id)
        {
            return fanOutputs.Find(i => i.Id == id);
        }

        // POST api/<FanOutPutController>
        [HttpPost]
        public void Post([FromBody] FanOutPut value)
        {
            FanOutPutId++;
            value.Id = FanOutPutId;
            fanOutputs.Add(value);

        }

        // PUT api/<FanOutPutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutPut value)
        {
            FanOutPut fanOutput = Get(id);
            if (fanOutput != null)
            {
                fanOutput.Id = value.Id;
                fanOutput.Name = value.Name;
                fanOutput.Temp = value.Temp;
                fanOutput.Moist = value.Moist;
            }
        }

        // DELETE api/<FanOutPutController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FanOutPut fanOutPut = Get(id);
            fanOutputs.Remove(fanOutPut);
        }

    }
}