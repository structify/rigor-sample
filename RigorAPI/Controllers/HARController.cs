using Rigor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RigorAPI.Controllers
{
    
    public class HARController : ApiController
    {
        private static readonly IList<HAR> logs = new List<HAR>();

        // GET: api/HAR
        public IEnumerable<HAR> Get()
        {
            return logs;
        }

        // GET: api/HAR/5
        public IHttpActionResult Get(int id)
        {
            if(id < 0 || id >= logs.Count())
            {
                return NotFound();
            }
            return Ok(logs[id]);
        }

        [HttpGet]
        [Route("api/HAR/{id}/Requests")]
        public IHttpActionResult Requests(int id)
        {
            if(id < 0 || id >= logs.Count())
            {
                return NotFound();
            }
            var requests = logs[id].Log.Entries.Select(x => x.Request);
            return Ok(new { requests= requests });
        }

        [HttpGet]
        [Route("api/HAR/{id}/Requests/{reqId}")]
        public IHttpActionResult Requests(int id, int reqId)
        {
            if (id < 0 || id >= logs.Count())
            {
                return NotFound();
            }
            var requests = logs[id].Log.Entries.Select(x => x.Request);
            if(reqId < 0 || reqId >= requests.Count())
            {
                return NotFound();
            }
            return Ok(requests.ToArray()[reqId]);
        }

        // POST: api/HAR
        public IHttpActionResult Post([FromBody]HAR value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            logs.Add(value);
            return Created<HAR>("/api/HAR/" + (logs.Count() - 1), value);
        }

        // PUT: api/HAR/5
        public IHttpActionResult Put(int id, [FromBody]HAR value)
        {
            if(id < 0 || id >= logs.Count())
            {
                return NotFound();
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            logs[id] = value;
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/HAR/5
        public IHttpActionResult Delete(int id)
        {
            if (id < 0 || id >= logs.Count())
            {
                return NotFound();
            }
            logs.RemoveAt(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
