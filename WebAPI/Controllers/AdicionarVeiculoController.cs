﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AdicionarVeiculoController : ApiController
    {   
        // GET: api/AdicionarVeiculo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AdicionarVeiculo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AdicionarVeiculo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AdicionarVeiculo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AdicionarVeiculo/5
        public void Delete(int id)
        {
        }
    }
}
