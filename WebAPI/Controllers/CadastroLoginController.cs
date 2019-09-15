using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CadastroLoginController : ApiController
    {
        // GET: api/CadastroLogin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CadastroLogin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CadastroLogin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CadastroLogin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CadastroLogin/5
        public void Delete(int id)
        {
        }
    }
}
