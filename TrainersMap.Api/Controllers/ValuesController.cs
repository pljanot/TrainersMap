using System.Collections.Generic;
using System.Web.Http;

namespace TrainersMap.Api.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("version")]
        public string ApiVersion()
        {
            return "0.1";
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            return Ok("value");
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
